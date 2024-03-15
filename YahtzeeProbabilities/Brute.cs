using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeProbabilities
{
    internal class Brute
    {

        public void execute()
        {
            double total = 0.0;
            int[] roll = new int[5];
            int[] temp = new int[] { 3, 2, 5, 6, 5, 5};

            //BruteRecurse(4, ref total, ref roll);
            //Console.WriteLine(IsOfAKind(2, temp));
            //Console.WriteLine(IsOfAKind(1, temp));
            //Console.WriteLine(IsOfAKind(3, temp));
            BruteRecurse2(4, ref total, ref roll);

            //Console.WriteLine(Math.Pow(1.0 / 7776.0, 2.0));

            Console.WriteLine(total);
        }

        public void BruteRecurse3(int diceNum, ref double total, ref int[] roll, int ofAKind, int diceNumToGet)
        {
            if (diceNum < 0)
            {
                //Console.Write(" | " + roll[0] + " " + roll[1] + " " + roll[2] + " " + roll[3] + " " + roll[4]);
                int[] filtered = Filter(roll);
                if (filtered[diceNumToGet] == ofAKind)
                {
                    total += ((1.0 / Math.Pow(6.0, (double)diceNumToGet)) * (1.0 / Math.Pow(6.0, 5.0)));
                }
                    
                return;
            }
            for (int i = 6; i > 0; i--)
            {
                roll[diceNum] = i;
                BruteRecurse3(diceNum - 1, ref total, ref roll, ofAKind, diceNumToGet);
            }
            return;
        }

        public void BruteRecurse2(int diceNum, ref double total, ref int[] roll)
        {
            if (diceNum < 0)
            {
                Console.WriteLine(roll[0] + " " + roll[1] + " " + roll[2] + " " + roll[3] + " " + roll[4] + " Total: " + total);
                int[] filtered = Filter(roll);
                int diceNumToGet = numDice(filtered);
                int numDiceLeft = 5 - filtered[diceNumToGet];
                int[] nextRoll = new int[5];
                BruteRecurse3(numDiceLeft - 1, ref total, ref nextRoll, numDiceLeft, diceNumToGet);
                return;
            }
            for (int i = 6; i > 0; i--)
            {
                roll[diceNum] = i;
                BruteRecurse2(diceNum - 1, ref total, ref roll);
            }
            return;
        }

        public void BruteRecurse(int diceNum, ref double total, ref int[] roll)
        {
            if (diceNum < 0)
            {
                //Console.WriteLine(roll[0] + " " + roll[1] + " " + roll[2] + " " + roll[3] + " " + roll[4]);
                if (IsOfAKind(5,roll))
                {
                    total += 1.0 / 7776.0;
                }
                return;
            }
            for (int i = 6; i > 0; i--)
            {
                roll[diceNum] = i;
                BruteRecurse(diceNum - 1, ref total, ref roll);
            }
            return;
        }

        public int[] Filter(int[] roll)
        {
            int[] temp = new int[7];

            foreach (int j in roll)
            {
                if (j != 0)
                    temp[j] += 1;
            }

            int largest = 1;
            foreach (int j in temp)
            {
                if (j > largest)
                    largest = j;
            }

            bool done = false;
            for (int i = 0; i < temp.Length; i++)
            {
                if ((temp[i] < largest) || (done == true))
                {
                    temp[i] = 0;
                }
                else if (temp[i] == largest)
                {
                    done = true;
                }
            }
            return temp;
        }
        public bool IsOfAKind(int kind, int[] roll)
        {
            int[] temp = new int[7];
            bool flag = false;

            foreach(int j in roll)
            {
                temp[j] += 1;
            }

            foreach (int j in temp)
            {
                if (j == kind)
                    flag = true;
                else if (j > kind)
                    return false;
            }
            return flag;
        }

        public int numDice(int[] roll)
        {
            for (int i = 0; i < roll.Length; i++)
            {
                if (roll[i] > 0)
                    return i;
            }
            return -1;
        }
    }
}
