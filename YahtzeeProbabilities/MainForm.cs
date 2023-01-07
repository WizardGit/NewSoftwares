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
            

            int.TryParse(getSixComboBox.Text, out int getSixes);
            int.TryParse(getFiveComboBox.Text, out int getFives);
            int.TryParse(getFourComboBox.Text, out int getFours);
            int.TryParse(getThreeComboBox.Text, out int getThrees);
            int.TryParse(getTwoComboBox.Text, out int getTwos);
            int.TryParse(getOneComboBox.Text, out int getOnes);

            int.TryParse(currRollComboBox.Text, out int currRoll);

            int.TryParse(currRollComboBox.Text, out int tempvar);


            int numOnes = 0;
            int numTwos = 0;
            int numThrees = 0;
            int numFours = 0;
            int numFives = 0;
            int numSixes = 0;
            if (tempvar > 1)
            {
                int.TryParse(numOneTxtBox.Text, out numOnes);
                int.TryParse(numTwoTxtBox.Text, out numTwos);
                int.TryParse(numThreeTxtBox.Text, out numThrees);
                int.TryParse(numFourTxtBox.Text, out numFours);
                int.TryParse(numFiveTxtBox.Text, out numFives);
                int.TryParse(numSixTxtBox.Text, out numSixes);
            }

            if (getOnes > numOnes)
                probOneTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, getOnes - numOnes, 5 - numOnes), 4).ToString() + "%";
            else
                probOneTxtBox.Text = "100%";
            if (getTwos > numTwos)
                probTwoTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, getTwos - numTwos, 5 - numTwos), 4).ToString() + "%";
            else
                probTwoTxtBox.Text = "100%";
            if (getThrees > numThrees)
                probThreeTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, getThrees - numThrees, 5 - numThrees), 4).ToString() + "%";
            else
                probThreeTxtBox.Text = "100%";
            if (getFours > numFours)
                probFourTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, getFours - numFours, 5 - numFours), 4).ToString() + "%";
            else
                probFourTxtBox.Text = "100%";
            if (getFives > numFives)
                probFiveTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, getFives - numFives, 5 - numFives), 4).ToString() + "%";
            else
                probFiveTxtBox.Text = "100%";
            if (getSixes > numSixes)
                probSixTxtBox.Text = Math.Round(UltimateProbAtLeast(3, currRoll, getSixes - numSixes, 5 - numSixes), 4).ToString() + "%";
            else
                probSixTxtBox.Text = "100%";
        }
    }
}
