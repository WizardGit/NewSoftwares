using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeProbabilities
{
    public class Probability
    {
        public double Combination(int n, int r)
        {
            if ((n < r) || (n < 0) || (r < 0))
                throw new Exception("Exception in function Combination");

            double result = 1.0;

            int startFrom;

            if (r > (n-r))
                startFrom = n - r;
            else
                startFrom = r;

            for (int i = startFrom; i > 0; i--, n--)
            {
                result *= (double)n / (double)i;
            }
            //Console.WriteLine("CombinationE is returning " + result);
            return result;
        }

        public double Permutation(int n, int r)
        {
            if ((n < r) || (n < 0) || (r < 0))
                throw new Exception("Exception in function Permutation");

            double result = 1.0;
            //Note that the denominator of (n-r)! cancels out that part of the n!, so we only need n to (n-r) of the !
            for (int i = n; i > (n - r); i--)
            {
                result *= i;
            }
            //Console.WriteLine("Combination is returning " + result);
            return result;
        }

        /// <summary>
        /// Returns the probability of getting numWant of one specific number out of numDice
        /// </summary>
        /// <param name="diceSides">Number of sides on the dice</param>
        /// <param name="numDice">Number of dice we are given</param>
        /// <param name="numWant">Number of dice that we want to be our specific number</param>
        /// <param name="numWork">Number of different dice that are part of the specific number(s)</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double OfASpecificNumbers(int diceSides, int numDice, int numWant, int numWork = 1)
        {
            if (numWant > numDice)
                throw new Exception("OfASpecificNumbers: numWant is more than numDice");
            if (numWork > diceSides)
                throw new Exception("OfASpecificNumbers: numWork is more than diceSides");

            double a = (double)diceSides;
            double d = (double)numWork; 

            // How many ways are there to arrange our numWant dice across our numDice dice
            double result = Combination(numDice, numWant);
            // Any of numWork numbers can be on a dice and we want numWant dice of any of those numbers
            result *= Math.Pow(d / a, numWant);
            // Each dice that is not the specific number can any of the dicesides-1 other numbers
            // We need to raise that number th the power of the number of dice we have left that will not be the specific number
            result *= Math.Pow((a - d) / a, numDice - numWant);
            // Each dice has diceSides choices for numbers, so we just need to divide by diceSides to the numDice power - done in the above steps
            return result;
        }

        //I want x of b specific number(s)
        //I want x of a kind where b specific number(s) count


        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="diceSides"></param>
        /// <param name="numDice"></param>
        /// <returns></returns>
        public double AofaB(int a, int b, int diceSides, int numDice)
        {
            return b * OfASpecificNumbers(diceSides, numDice, a);
        }

        public double XSets(int diceSides, int numDice, int numWant, int setNum, int diceBefore = 0)
        {
            double numSets = Math.Floor((double)numDice / (double)numWant);
            //Perform A1/A3
            //Needs more testing!
            double a = (double)diceSides;
            double b = (double)numDice;
            double c = (double)numWant;

            //perform A2
            //We've already done a set, 
            //result should be 1.0 but we're multiplying by what should be numwork (6 in our case rn, should be changed later!)
            double result = 6.0;
            int currentSet = setNum;
            int setsFinished = setNum - 1;

            //look this logic over again
            if ((c > 1.0) || (diceBefore > 0))
                result *= Combination(numDice, numWant);

            //In this loop, i is taking the place of sets finished - looping through them per say...
            for (int i = 1; i < setNum; i++)
            {
                result *= diceSides - i;
                result *= Combination(numDice - (i * numWant), numWant);
            }

            int diceLeft = numDice - (setNum * numWant);
            int nextDiceNum = diceSides - setNum;
            for (int i = 0; i < diceLeft; i++, nextDiceNum--)
            {
                //Do we need if clause?
                result *= nextDiceNum;
                //I'm thinking this might just always be 1?
                //result *= Combination((numDice - (currentSet * numWant)), 1);
            }
            //But this is wrong because we count each of the two pairs twice, so let's divide by how much we overcount
            //In reality the hardcoded 2 should be replaced with the number of pairs that we have!
            result /= Permutation((int)setNum, (int)setNum);
            //Divide by all of dice
            result /= Math.Pow(a, b);

            return result;

            //Theoretically, now,all we need to do is just loop and add up set 1 prob + set 2 prob + set 3 prob + etc
        }

        
        public double PairRoll(int diceSides, int numDice, int numWant, int diceBefore = 0)
        {

            double numSets = Math.Floor((double)numDice / (double)numWant);
            double result = 0.0;
            for (int i = 1; i <= numSets; i++)
            {
                result += XSets(diceSides, numDice, numWant, i);
            }           
            //because we are doing our multiplation by 6, we should leave it out for later
            return result / 6;
        }

        /// <summary>
        /// does one roll
        /// </summary>
        /// <param name="a">dice sides</param>
        /// <param name="b">number of dice</param>
        /// <param name="c">how many of the same type you want</param>
        /// <param name="d">how many dice numbers/side work</param>
        /// <returns>number</returns>
        public double OneRoll(int diceSides, int numDice, int numWant, int diceBefore=0)
        {          
            //Needs more testing!
            double result;

            if ((numWant > 1) && ((double)numDice / (double)numWant >= 2))
            {
                return PairRoll(diceSides, numDice, numWant);
            }

            double a = (double)diceSides;
            double b = (double)numDice;
            double c = (double)numWant;

            result = Math.Pow(1 / a, c);
            if ((c > 1.0) || (diceBefore > 0))
                result *= Combination(numDice, numWant);

            double z = 1.0;
            int numZ = 0;
            for (int i = 0; i < b - c; i++)
            {
                //took out of this if clause: (c != 0.0) && 
                if ((numZ >= (numWant+diceBefore)))
                {
                    numZ = 0;
                    z++;
                    if (z >= a)
                        throw new Exception("One Roll is having trouble setting up probability!");
                }
                result *= (a - z) / a;
                numZ++;
            }
            //Console.WriteLine("OneRoll is returning " + result);
            //How much extra on double to return?
            return result;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="multProb">Use default of 1.0</param>
        /// <param name="ultimateSumProb">Will just add onto what you already have - you probably want 0.0</param>
        /// <param name="numRolls">number of rolls (3,2,1, etc)</param>
        /// <param name="currRoll">current roll. Should be equal to numRolls</param>
        /// <param name="diceSides">sides on a dice, default to 6</param>
        /// <param name="numDice">number of dice given, default to 5</param>
        /// <param name="numWant">number of dice you need, should be equal to numDice</param>
        /// <param name="numWork">number of dice that work, for instance maybe you only want 5's. default is 6 (for all six numbers work for a yahtzee, all 5 dice just need to be the same)</param>
        /// <param name="allDice">absolute number of dice that you have, default to 5</param>
        public void Recurse(double multProb, ref double ultimateSumProb, int numRolls, int currRoll, int diceSides, int numDice, int numWant, int numWork, int allDice)
        {
            //Console.WriteLine("We got " + numDice + " Dice!");
            if (numDice == 0)
            {
                double temp = numWork * multProb;
                Console.WriteLine("TempNumWork0Dice is " + temp);
                ultimateSumProb = ultimateSumProb + temp;
                return;
            }
            if (numRolls <= 0)
            {
                throw new Exception("Recurse: No rolls left!");
            }

            if (currRoll == numRolls)
            {
                double temp = OneRoll(diceSides, numDice, numWant, allDice - numDice);
                Console.WriteLine("TempBefore is " + temp);
                temp *= numWork * multProb;
                Console.WriteLine("TempNumWork is " + temp);
                ultimateSumProb = ultimateSumProb + temp;
                return;
            }

            for (int i = numWant; i >= 0; i--)
            {
                Console.WriteLine("We are on Roll " + currRoll + " and are on Dice " + i);
                //how is numWant related to the number of dice we are given
                //let's assume we always want to max out for now!
                if ((i != 0) || (numDice != allDice))
                {
                    double temp = OneRoll(diceSides, numDice, i, allDice - numDice);
                    Console.WriteLine(" " + i + " out of " + numDice + " is " + temp);
                    Recurse(multProb * temp, ref ultimateSumProb, numRolls, currRoll + 1, diceSides, numDice - i, numWant - i, numWork, allDice);
                }                                  
            }
            return;
        }

        public double PercentOfAKind(int numRolls, int numWant, int numWork)
        {
            double result = 0.0;

            //for (int roll = numRolls; roll > 0; roll--)
            //{
            //    if ((roll < numRolls) && (numWant == 1))
            //    {
            //        //Do Nothing 
            //        //we don't do the cases of not getting a dice in first round
            //        //This is because we are guaranteed to at least get 1 number in the first round which immediately puts us into the first case again
            //    }
            //    else
            //    {
                    Recurse(1.0, ref result, numRolls, 1, 6, 5, numWant, numWork, 5);
            //    }
            //}

            //Console.WriteLine("PercentOfAKind is returning " + result);
            return result * 100;
        }
    }
}
