using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YahtzeeProbabilities.Properties;

namespace YahtzeeProbabilities
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }  

        //2 out of 2 is (1+0)
        //2 out of 3 is (2+1+0)
        //2 out of 4 is (3+2+1+0)
        //2 out of 5 is (4+3+2+1+0)

        //3 out of 3 is (1+0) = 1
        //3 out of 4 is (2+1+0) + (1+0) = 3+1 = 4 = (4)/(1)
        //3 out of 5 is (3+2+1+0) + (2+1+0) + (1+0) = 6+3+1=10 = (5*4)/(2*1)
        //3 out of 6 is (4+3+2+1+0) + (3+2+1+0) + (2+1+0) + (1+0)=10+6+3+1=20= (6*5*4)/(3*2*1)

        //4 out of 4 is (1+0) = 1
        //4 out of 5 is (2+1+0) + (1+0) + (1+0) = 4 + 1 = 5 = (5)/(1)
        //4 out of 6 is (3+2+1+0) + (2+1+0) + (1+0) + (2+1+0) + (1+0) + (1+0) = 10 + 4 + 1 = 15 = (6*5)/(2*1)
        //4 out of 7 is (4+3+2+1+0) + (3+2+1+0) + (2+1+0) + (1+0) + (3+2+1+0) + (2+1+0) + (1+0) + (2+1+0) + (1+0) + (1+0) = 20 + 10 + 4 + 1 = 35 = (7*6*5)/(3*2*1)


        //Number of combinations that "selectDice" dice can be selected with selectDice particular number out of "numDice" dice
        // (selectDice out of numDice)
        // i.e. how many ways can there be two dice with selectDice number 1 when you have three dice
        private double NumCombin(int selectDice, int numDice)
        {
            if ((numDice < selectDice) || (numDice < 0) || (selectDice < 0))
                throw new Exception("Exception in function NumCombin");

            double topsum = 1;
            double bottomsum = 1;
            for (int i = (numDice - selectDice); i > 0; i--)
            {
                topsum *= (numDice + 1 - i);
                bottomsum *= i;

                //numbers get way too big at times!
            }
            
            return topsum / bottomsum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numDice"></param>
        /// <param name="selectDice"></param>
        /// <param name="sidedDice"></param>
        /// <returns>Probability of getting selectDice out of NumDice</returns>
        /// <exception cref="Exception"></exception>
        private double OutOf(int selectDice, int numDice, int sidedDice = 6)
        {
            if ((numDice < selectDice) || (numDice < 0) || (selectDice < 0) || (sidedDice < 0))
                throw new Exception("Exception in function OutOf");
            
            double denominator = Math.Pow(sidedDice, numDice);
            double numerator = Math.Pow(sidedDice - 1, numDice - selectDice);

            return numerator * NumCombin(selectDice, numDice) / denominator;
            // 
        }

        /// <summary>
        /// Probability of getting at least "numDice" of (selectDice number on selectDice six-sided dice) with "selectDice" dice in 1 roll
        /// </summary>
        /// <param name="selectDice"></param>
        /// <param name="numDice"></param>
        /// <returns>Probability of getting at least selectDice out of NumDice</returns>
        private double AtLeastOutOf(int selectDice, int numDice)
        {
            double prob = 0.0;

            for (int i = selectDice; i <= numDice; i++)
            {
                prob += OutOf(i, numDice);
            }

            return prob;
        }

        /// <summary>
        /// Probability of getting at mostt "numDice" of (selectDice number on selectDice six-sided dice) with "selectDice" dice in 1 roll
        /// </summary>
        /// <param name="selectDice"></param>
        /// <param name="numDice"></param>
        /// <returns>Probability of getting at most selectDice out of NumDice</returns>
        private double AtMostOutOf(int selectDice, int numDice)
        {
            double prob = 0.0;

            for (int i = selectDice; i >= 0; i--)
            {
                prob += OutOf(i, numDice);
            }

            return prob;
        }

        private void calbut2_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int.TryParse(textBox1.Text, out a);
            int.TryParse(textBox2.Text, out b);
            int.TryParse(textBoxRolls.Text, out int currRoll);
            templbl.Text = UltimateProbAtLeast(3, currRoll, a, b).ToString() + "%";
        }

        private double UltimateProbAtLeast(int numRolls, int currRoll, int selectDice, int numDice)
        {
            double ultimateSumProb = 0.0;

            double sum = 0;
            for (int i = selectDice; i <= numDice; i++)
            {
                ultimateSumProb = 0.0;
                Recurse(1.0, ref ultimateSumProb, numRolls, currRoll, i, numDice);
                sum += ultimateSumProb;
            }            

            return sum * 100;
        }

        /// <summary>
        /// THIS WILL NOT RETURN THE ANSWER * 100!
        /// </summary>
        /// <param name="numRolls"></param>
        /// <param name="currRoll"></param>
        /// <param name="selectDice"></param>
        /// <param name="numDice"></param>
        /// <returns></returns>
        private double UltimateProbAtMost(int numRolls, int currRoll, int selectDice, int numDice)
        {
            double ultimateSumProb = 0.0;

            double sum = 0;
            for (int i = 0; i <= selectDice; i++)
            {
                ultimateSumProb = 0.0;
                Recurse(1.0, ref ultimateSumProb, numRolls, currRoll, i, numDice);
                sum += ultimateSumProb;
            }

            return sum;
        }

        private void Recurse(double multProb, ref double ultimateSumProb, int numRolls, int currRoll, int selectDice, int numDice)
        {
            if (currRoll == numRolls)
            {
                ultimateSumProb = ultimateSumProb + (multProb * OutOf(selectDice, numDice));
                return;
            }

            for (int i = selectDice; i >= 0; i--)
            {
                Recurse(multProb * OutOf(i, numDice), ref ultimateSumProb, numRolls, currRoll + 1, selectDice-i, numDice-i);
            }
            return;
        }

        private void tempFunc()
        {

        }

        private void calcProbsBtn_Click(object sender, EventArgs e)
        {
            // Index 0 is empty/doesn't represent anything in both of these arrays
            int[] selectNum = new int[7];
            int[] haveNum = new int[] { 0,0,0,0,0,0,0 };
            
            int.TryParse(getOneComboBox.Text, out selectNum[1]);
            int.TryParse(getTwoComboBox.Text, out selectNum[2]);
            int.TryParse(getThreeComboBox.Text, out selectNum[3]);
            int.TryParse(getFourComboBox.Text, out selectNum[4]);
            int.TryParse(getFiveComboBox.Text, out selectNum[5]);
            int.TryParse(getSixComboBox.Text, out selectNum[6]);

            int.TryParse(currRollComboBox.Text, out int currRoll);
            int.TryParse(currRollComboBox.Text, out int tempvar);           
            
            if (tempvar > 1)
            {
                int.TryParse(numOneTxtBox.Text, out haveNum[1]);
                int.TryParse(numTwoTxtBox.Text, out haveNum[2]);
                int.TryParse(numThreeTxtBox.Text, out haveNum[3]);
                int.TryParse(numFourTxtBox.Text, out haveNum[4]);
                int.TryParse(numFiveTxtBox.Text, out haveNum[5]);
                int.TryParse(numSixTxtBox.Text, out haveNum[6]);
            }

            int totalDice = 0;
            for (int i = 1; i < haveNum.Count(); i++)
            {
                totalDice += haveNum[i];
            }
            if (totalDice > 5)
                warningLbl.Text = "You have more dice listed than dice you actually have! \n Remember, you only have 5 dice!";

            if (selectNum[1] > haveNum[1])
                probOneTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, selectNum[1] - haveNum[1], 5 - haveNum[1]), 4).ToString() + "%";
            else
                probOneTxtBox.Text = "100%";
            if (selectNum[2] > haveNum[2])
                probTwoTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, selectNum[2] - haveNum[2], 5 - haveNum[2]), 4).ToString() + "%";
            else
                probTwoTxtBox.Text = "100%";
            if (selectNum[3] > haveNum[3])
                probThreeTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, selectNum[3] - haveNum[3], 5 - haveNum[3]), 4).ToString() + "%";
            else
                probThreeTxtBox.Text = "100%";
            if (selectNum[4] > haveNum[4])
                probFourTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, selectNum[4] - haveNum[4], 5 - haveNum[4]), 4).ToString() + "%";
            else
                probFourTxtBox.Text = "100%";
            if (selectNum[5] > haveNum[5])
                probFiveTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, selectNum[5] - haveNum[5], 5 - haveNum[5]), 4).ToString() + "%";
            else
                probFiveTxtBox.Text = "100%";
            if (selectNum[6] > haveNum[6])
                probSixTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, selectNum[6] - haveNum[6], 5 - haveNum[6]), 4).ToString() + "%";
            else
                probSixTxtBox.Text = "100%";
            probCTxtBox.Text = "100%";

            //The liklihood that all six numbers will NOT be rolled to get three/four is
            //The likelihood that one of them won't be rolled to get three/four multipled by itself 6 times (since six numbers)
            // 1- that answer is then the likelihood one of them WILL be rolled to get three/four - multiply this by 100 since the 
            //ultimate function does not and round to four decimal places
            prob3KTxtBox.Text = Math.Round(100 * (1.0 - Math.Pow(UltimateProbAtMost(3, currRoll, 2, 5), 6)), 4).ToString() + "%";
            prob4KTxtBox.Text = Math.Round(100 * (1.0 - Math.Pow(UltimateProbAtMost(3, currRoll, 3, 5), 6)), 4).ToString() + "%";

            //Same sort of reasoning as above
            probYTxtBox.Text = Math.Round(100 * (1.0 - Math.Pow(UltimateProbAtMost(3, currRoll, 4, 5), 6)), 4).ToString() + "%";


            //Locked on three rolls - need to be modified for less
            // Unsure if these are right!            
            probFHTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, 5, 5) * 25, 4).ToString() + "%";  
            probSSTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, 4, 5), 4).ToString() + "%";
            probLSTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, 5, 5), 4).ToString() + "%";
            
        }

        // I think getting small straight is just chance of getting 3 of a number * 3
        // I think large straight is just getting 4 of a number * 2
        // I think full house is just getting 5 * 25
    }
}
