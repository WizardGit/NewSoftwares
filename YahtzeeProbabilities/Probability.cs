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
                throw new Exception("Exception in function NumCombin");

            double result;
            //Top of fraction
            double numerator = 1.0;
            //Bottom of fraction
            double denominator = 1.0;

            for (int i = (n - r); i > 0; i--)
            {
                numerator *= (n + 1 - i);
                denominator *= i;

                //numbers get way too big at times!
                //possibly could try dividing as we go!
            }
            result = numerator / denominator;
            Console.WriteLine("Combination is returning " + result);
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
        public double OneRoll(int diceSides, int numDice, int numWant)
        {
            //Needs more testing!
            double result;
            double a = (double)diceSides;
            double b = (double)numDice;
            double c = (double)numWant;

            result = Combination(numDice, numWant) * Math.Pow(1 / a, c) * Math.Pow((a - 1) / a, b - c);
            //Debug.Write("OneRoll is returning " + result);
            Console.WriteLine("OneRoll is returning " + result);
            //How much extra on double to return?
            return result;
        }

        public double Yahtzee()
        {
            double result = 0.0;

            Recurse(1.0, ref result, 3, 1, 6, 5, 5, 6);

            Console.WriteLine("Yahtzee is returning " + result);
            return result;
        }

        private void Recurse(double multProb, ref double ultimateSumProb, int numRolls, int currRoll, int diceSides, int numDice, int numWant, int numWork)
        {
            if (currRoll == numRolls)
            {
                double temp = numWork * (multProb * OneRoll(diceSides, numDice, numWant));
                Console.WriteLine("Temp is " + temp);
                ultimateSumProb = ultimateSumProb + temp;
                return;
            }

            for (int i = numDice; i >= 0; i--)
            {
                //how is numWant related to the number of dice we are given
                //let's assume we always want to max out for now!
                Recurse(multProb * OneRoll(diceSides, numDice, i), ref ultimateSumProb, numRolls, currRoll + 1, diceSides, numDice - i, numDice - i, numWork);                
            }
            //multProb = 1.0;
            return;
        }
    }
}
