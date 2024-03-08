//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace YahtzeeProbabilities
//{
//    internal class Experimental
//    {
//        //2 out of 2 is (1+0)
//        //2 out of 3 is (2+1+0)
//        //2 out of 4 is (3+2+1+0)
//        //2 out of 5 is (4+3+2+1+0)

//        //3 out of 3 is (1+0) = 1
//        //3 out of 4 is (2+1+0) + (1+0) = 3+1 = 4 = (4)/(1)
//        //3 out of 5 is (3+2+1+0) + (2+1+0) + (1+0) = 6+3+1=10 = (5*4)/(2*1)
//        //3 out of 6 is (4+3+2+1+0) + (3+2+1+0) + (2+1+0) + (1+0)=10+6+3+1=20= (6*5*4)/(3*2*1)

//        //4 out of 4 is (1+0) = 1
//        //4 out of 5 is (2+1+0) + (1+0) + (1+0) = 4 + 1 = 5 = (5)/(1)
//        //4 out of 6 is (3+2+1+0) + (2+1+0) + (1+0) + (2+1+0) + (1+0) + (1+0) = 10 + 4 + 1 = 15 = (6*5)/(2*1)
//        //4 out of 7 is (4+3+2+1+0) + (3+2+1+0) + (2+1+0) + (1+0) + (3+2+1+0) + (2+1+0) + (1+0) + (2+1+0) + (1+0) + (1+0) = 20 + 10 + 4 + 1 = 35 = (7*6*5)/(3*2*1)


//        //Number of combinations that "selectDice" dice can be selected with selectDice particular number out of "numDice" dice
//        // (selectDice out of numDice)
//        // i.e. how many ways can there be two dice with selectDice number 1 when you have three dice
//        //combination formula

//        private void Execute()
//        {
//            int totalDice = 0;
//            for (int i = 1; i < haveNum.Count(); i++)
//            {
//                totalDice += haveNum[i];
//            }
//            if (totalDice > 5)
//                warningLbl.Text = "You have more dice listed than dice you actually have! \n Remember, you only have 5 dice!";

//            if (selectNum[1] > haveNum[1])
//                probOneTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, selectNum[1] - haveNum[1], 5 - haveNum[1]), 4).ToString() + "%";
//            else
//                probOneTxtBox.Text = "100%";
//            if (selectNum[2] > haveNum[2])
//                probTwoTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, selectNum[2] - haveNum[2], 5 - haveNum[2]), 4).ToString() + "%";
//            else
//                probTwoTxtBox.Text = "100%";
//            if (selectNum[3] > haveNum[3])
//                probThreeTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, selectNum[3] - haveNum[3], 5 - haveNum[3]), 4).ToString() + "%";
//            else
//                probThreeTxtBox.Text = "100%";
//            if (selectNum[4] > haveNum[4])
//                probFourTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, selectNum[4] - haveNum[4], 5 - haveNum[4]), 4).ToString() + "%";
//            else
//                probFourTxtBox.Text = "100%";
//            if (selectNum[5] > haveNum[5])
//                probFiveTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, selectNum[5] - haveNum[5], 5 - haveNum[5]), 4).ToString() + "%";
//            else
//                probFiveTxtBox.Text = "100%";
//            if (selectNum[6] > haveNum[6])
//                probSixTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, selectNum[6] - haveNum[6], 5 - haveNum[6]), 4).ToString() + "%";
//            else
//                probSixTxtBox.Text = "100%";
//            probCTxtBox.Text = "100%";

//            //Many of these are wrong!
//            //The liklihood that all six numbers will NOT be rolled to get three/four is
//            //The likelihood that one of them won't be rolled to get three/four multipled by itself 6 times (since six numbers)
//            // 1- that answer is then the likelihood one of them WILL be rolled to get three/four - multiply this by 100 since the 
//            //ultimate function does not and round to four decimal places
//            prob3KTxtBox.Text = Math.Round(100 * (1.0 - Math.Pow(UltimateProbAtMost(3, currRoll, 2, 5), 6)), 4).ToString() + "%";
//            prob4KTxtBox.Text = Math.Round(100 * (1.0 - Math.Pow(UltimateProbAtMost(3, currRoll, 3, 5), 6)), 4).ToString() + "%";

//            //Same sort of reasoning as above
//            probYTxtBox.Text = Math.Round(100 * (1.0 - Math.Pow(UltimateProbAtMost(3, currRoll, 4, 5), 6)), 4).ToString() + "%";


//            //Locked on three rolls - need to be modified for less
//            probFHTxtBox.Text = Math.Round((100 * 300 / Math.Pow(6, 5)), 4).ToString() + "%";
//            probSSTxtBox.Text = Math.Round(ExperimentalOutOf(4, 5), 4).ToString() + "%";
//            probLSTxtBox.Text = Math.Round(ExperimentalOutOf(5, 5), 4).ToString() + "%";
//        }



//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="numDice"></param>
//        /// <param name="selectDice"></param>
//        /// <param name="sidedDice"></param>
//        /// <returns>Probability of getting selectDice out of NumDice</returns>
//        /// <exception cref="Exception"></exception>
//        private double OutOf(int selectDice, int numDice, int sidedDice = 6)
//        {
//            if ((numDice < selectDice) || (numDice < 0) || (selectDice < 0) || (sidedDice < 0))
//                throw new Exception("Exception in function OutOf");

//            double numerator = Math.Pow(sidedDice - 1, numDice - selectDice) * Combination(selectDice, numDice);
//            double denominator = Math.Pow(sidedDice, numDice);

//            return numerator / denominator;
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="selectDice"></param>
//        /// <param name="numDice"></param>
//        /// <param name="sidedDice"></param>
//        /// <returns>Probability of getting unique selectDice out of NumDice</returns>
//        /// <exception cref="Exception"></exception>
//        private double UniqueOutOf(int selectDice, int numDice, int sidedDice = 6)
//        {
//            if ((numDice < selectDice) || (numDice < 0) || (selectDice < 0) || (sidedDice < 0))
//                throw new Exception("Exception in function OutOf");

//            double numerator = 1.0;
//            for (int i = (sidedDice - 5 + selectDice); i > 1; i--)
//            {
//                numerator *= i;
//            }
//            numerator *= Math.Pow(selectDice, (numDice - selectDice));

//            double denominator = Math.Pow(sidedDice, numDice);

//            Debug.Write("Numerator: " + numerator.ToString() + " Denominator: " + denominator.ToString() + "\n");

//            return numerator / denominator;
//        }

//        // Make more powerful later
//        private double NumsInRow(int inARow, int amountInSet = 5)
//        {
//            int[] numbers = { 1, 2, 3, 4, 5, 6 };
//            int num = 6;

//            double maxSets = Combination(amountInSet, 6);

//            if (inARow <= (num / (num - amountInSet + 1)))
//            {
//                return maxSets;
//            }
//            else if (inARow == 5)
//            {
//                return 2;
//            }
//            else if (inARow == 4)
//            {
//                return 3;
//            }

//            return maxSets;
//        }

//        private double Factorial(int num)
//        {
//            double sum = 1;
//            for (int i = num; i > 0; i--)
//            {
//                sum *= i;
//            }
//            return sum;
//        }

//        private double ExperimentalOutOf(int selectDice, int numDice, int sidedDice = 6)
//        {
//            double numerator = 1.0;
//            double denominator = 1.0;

//            //Deal with Sets
//            double sets = NumsInRow(selectDice);
//            //Deal with repeated elemnts
//            double ele = Combination(numDice - selectDice + 1, numDice);
//            //Deal with distinct elements
//            double dist = Factorial(selectDice - 1);
//            double multisets = 0;

//            if (selectDice == 5)
//                multisets = 0;
//            else if (selectDice == 4)
//                multisets = 5 + 4 + 5 - 2;
//            else if (selectDice == 3)
//                multisets = Math.Pow(5, 2) + Math.Pow(4, 2) + Math.Pow(4, 2) + Math.Pow(5, 2) - 2;
//            else if (selectDice == 2)
//                multisets = Math.Pow(4, 3) + Math.Pow(3, 3) + Math.Pow(4, 3) + Math.Pow(3, 3) + Math.Pow(4, 3) - 2;
//            else if (selectDice == 1)
//                multisets = 1 * 6;

//            numerator = (2 * Factorial(numDice)) + (ele * dist * multisets);
//            denominator = Math.Pow(sidedDice, numDice);


//            Debug.Write(numerator + " " + sets + " " + ele + " " + dist + " " + multisets + "\n");

//            return numerator / denominator * 100;
//        }

//        private void UniqueRecurse(double multProb, ref double ultimateSumProb, int numRolls, int currRoll, int selectDice, int numDice)
//        {
//            if (currRoll == numRolls)
//            {
//                ultimateSumProb = ultimateSumProb + (multProb * UniqueOutOf(selectDice, numDice));
//                return;
//            }

//            for (int i = selectDice; i >= 0; i--)
//            {
//                UniqueRecurse(multProb * UniqueOutOf(i, numDice), ref ultimateSumProb, numRolls, currRoll + 1, selectDice - i, numDice - i);
//            }
//            return;
//        }

//        private double UniqueUltimateProbAtLeast(int numRolls, int currRoll, int selectDice, int numDice)
//        {
//            double ultimateSumProb = 0.0;

//            double sum = 0;
//            for (int i = selectDice; i <= numDice; i++)
//            {
//                ultimateSumProb = 0.0;
//                UniqueRecurse(1.0, ref ultimateSumProb, numRolls, currRoll, i, numDice);


//                sum += ultimateSumProb;
//            }

//            return sum * 100;
//        }

//        private double UniqueUltimateProbAtMost(int numRolls, int currRoll, int selectDice, int numDice)
//        {
//            double ultimateSumProb = 0.0;

//            double sum = 0;
//            for (int i = 0; i <= selectDice; i++)
//            {
//                ultimateSumProb = 0.0;
//                UniqueRecurse(1.0, ref ultimateSumProb, numRolls, currRoll, i, numDice);

//                Debug.Write(ultimateSumProb + "\n");
//                sum += ultimateSumProb;
//            }

//            return sum;
//        }

//        /// <summary>
//        /// Probability of getting at least "numDice" of (selectDice number on selectDice six-sided dice) with "selectDice" dice in 1 roll
//        /// </summary>
//        /// <param name="selectDice"></param>
//        /// <param name="numDice"></param>
//        /// <returns>Probability of getting at least selectDice out of NumDice</returns>
//        private double AtLeastOutOf(int selectDice, int numDice)
//        {
//            double prob = 0.0;

//            for (int i = selectDice; i <= numDice; i++)
//            {
//                prob += OutOf(i, numDice);
//            }

//            return prob;
//        }

//        /// <summary>
//        /// Probability of getting at mostt "numDice" of (selectDice number on selectDice six-sided dice) with "selectDice" dice in 1 roll
//        /// </summary>
//        /// <param name="selectDice"></param>
//        /// <param name="numDice"></param>
//        /// <returns>Probability of getting at most selectDice out of NumDice</returns>
//        private double AtMostOutOf(int selectDice, int numDice)
//        {
//            double prob = 0.0;

//            for (int i = selectDice; i >= 0; i--)
//            {
//                prob += OutOf(i, numDice);
//            }

//            return prob;
//        }

//        private double UltimateProbAtLeast(int numRolls, int currRoll, int selectDice, int numDice)
//        {
//            double ultimateSumProb = 0.0;

//            double sum = 0;
//            for (int i = selectDice; i <= numDice; i++)
//            {
//                ultimateSumProb = 0.0;
//                Recurse(1.0, ref ultimateSumProb, numRolls, currRoll, i, numDice);
//                sum += ultimateSumProb;
//            }

//            return sum * 100;
//        }

//        /// <summary>
//        /// THIS WILL NOT RETURN THE ANSWER * 100!
//        /// </summary>
//        /// <param name="numRolls"></param>
//        /// <param name="currRoll"></param>
//        /// <param name="selectDice"></param>
//        /// <param name="numDice"></param>
//        /// <returns></returns>
//        private double UltimateProbAtMost(int numRolls, int currRoll, int selectDice, int numDice)
//        {
//            double ultimateSumProb = 0.0;

//            double sum = 0;
//            for (int i = 0; i <= selectDice; i++)
//            {
//                ultimateSumProb = 0.0;
//                Recurse(1.0, ref ultimateSumProb, numRolls, currRoll, i, numDice);
//                sum += ultimateSumProb;
//            }

//            return sum;
//        }

//        private void Recurse(double multProb, ref double ultimateSumProb, int numRolls, int currRoll, int selectDice, int numDice)
//        {
//            if (currRoll == numRolls)
//            {
//                ultimateSumProb = ultimateSumProb + (multProb * OutOf(selectDice, numDice));
//                return;
//            }

//            for (int i = selectDice; i >= 0; i--)
//            {
//                Recurse(multProb * OutOf(i, numDice), ref ultimateSumProb, numRolls, currRoll + 1, selectDice - i, numDice - i);
//            }
//            return;
//        }
//    }
//}
