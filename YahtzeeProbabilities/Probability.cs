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
            double result = 1.0;
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

            return result;
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
                if ((c != 0.0) && (numZ >= (numWant+diceBefore)))
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
            if ((numWant == 0) || (numRolls <= 0))
            {
                ultimateSumProb += 0.0;
                return;
            }

            if (currRoll == numRolls)
            {
                double temp = numWork * (multProb * OneRoll(diceSides, numDice, numWant, allDice - numDice));
                //Console.WriteLine("Temp is " + temp);
                ultimateSumProb = ultimateSumProb + temp;
                return;
            }

            for (int i = numWant; i >= 0; i--)
            {
                //Console.WriteLine("We are on Dice " + i);
                //how is numWant related to the number of dice we are given
                //let's assume we always want to max out for now!
                if ((i != 0) || (numDice != allDice))
                    Recurse(multProb * OneRoll(diceSides, numDice, i, allDice - numDice), ref ultimateSumProb, numRolls, currRoll + 1, diceSides, numDice - i, numWant - i, numWork, allDice);                
            }
            return;
        }

        public double PercentOfAKind(int numRolls, int numWant, int numWork)
        {
            double result = 0.0;

            for (int roll = numRolls; roll > 0; roll--)
            {
                Recurse(1.0, ref result, roll, 1, 6, 5, numWant, numWork, 5);
            }

            //Console.WriteLine("PercentOfAKind is returning " + result);
            return result * 100;
        }
    }
}
