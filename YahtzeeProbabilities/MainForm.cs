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

        public int hi = 0;
        public MainForm()
        {
            InitializeComponent();
        }    

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int p = 0;
            int.TryParse(OnesTextBox.Text, out p);

            //OnesAnswer.Text = (MultipleRolls(p,6,5,100) * 100).ToString() + " || " + (OneRoll(p, 6) * 100).ToString();
            //OnesAnswer.Text = NumCombin(4,7).ToString();
            
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


        //3 out of 5 is (
        //2 out of 3 is 3
        //2 out of 3 is 3

        //How many ways can: selectDice be in numDice

        //(Do recursion for the rolls)

        //selectDice sides on dice: 6 good
        //numDice number of dice: 5 good
        //c number of rolls: 1
        //d number to get: 1 good
        //e number of d to get: good

        //Probability of getting e of that number in selectDice single roll with 1 roll
        private float OneRoll(int e, int a = 6, int b=5, int c=1, int d=1)
        {
            float prob = 1.0f;

            if (e > b)
                throw new Exception("You can't get more of selectDice number than dice you are rolling!");

            for (int i = 0; i < e; i++)
            {
                prob *=  1.0f / a;
            }
            for (int i = e; i < b; i++)
            {
                prob *= (a-1.0f) / a;
            }

            return prob;
        }

        
        //Probability of getting e of that number in selectDice single roll with c rolls
        private float MultipleRolls(int e, int a = 6, int b = 5, int c = 1, int d = 1)
        {
            float prob = 1.0f;

            if (e > b)
                throw new Exception("You can't get more of selectDice number than dice you are rolling!");

            for (int i = 0; i < c; i++)
            {
                prob *= (1.0f - OneRoll(e,a,b,c,d));
            }

            return (1.0f - prob);
        }


        //Number of combinations that "selectDice" dice can be selected with selectDice particular number out of "numDice" dice
        // (selectDice out of numDice)
        // i.e. how many ways can there be two dice with selectDice number 1 when you have three dice
        private int NumCombin(int selectDice, int numDice)
        {
            if ((numDice < selectDice) || (numDice < 0) || (selectDice < 0))
                throw new Exception("Exception in function NumCombin");

            int topsum = 1;
            int bottomsum = 1;
            for (int i = (numDice - selectDice); i > 0; i--)
            {
                //Debug.Write(topsum + "\n");
                //Debug.Write(bottomsum + "\n");
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
            // denominator)
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
            hi = 0;
            int a = 0;
            int b = 0;
            int.TryParse(textBox1.Text, out a);
            int.TryParse(textBox2.Text, out b);
            templbl.Text = 
                //NumCombin(a, b).ToString() + 
                "\n" + (AtLeastOutOf(a, b)*100).ToString() + 
                "\n" +  (AtMostOutOf(a, b)*100).ToString() +
                "\n" + (RandFunc()*100).ToString();
            Debug.Write(hi + "\n");
            hi = 0;
        }

        private double RandFunc()
        {
            double multProb = 1.0;
            double ultimateSumProb = 0.0;
            int numRolls = 1;
            int.TryParse(textBoxRolls.Text, out numRolls);
            int currRoll = 1;
            int selectDice = 0;
            int numDice = 6;
            int times = 0;

            double sum = 0;
            for (int i = selectDice; i <= numDice; i++)
            {
                multProb = 1.0;
                ultimateSumProb = 0.0;
                Recurse(ref times, multProb, ref ultimateSumProb, numRolls, currRoll, i, numDice);
                //ultimateSumProb = ultimateSumProb / (Math.Pow(6, numDice) * times);
                sum += ultimateSumProb;
            }            

            return sum;
        }

        private void Recurse(ref int times, double multProb, ref double ultimateSumProb, int numRolls, int currRoll, int selectDice, int numDice)
        {
            Debug.Write(multProb + "\n");
            if (currRoll == numRolls)
            {
                hi++;
                //times++;
                ultimateSumProb = ultimateSumProb + (multProb * OutOf(selectDice, numDice));
                return;
            }

            for (int i = selectDice; i >= 0; i--)
            {
                //times++;
                Recurse(ref times, multProb * OutOf(i, numDice), ref ultimateSumProb, numRolls, currRoll + 1, selectDice-i, numDice);
            }
            return;
        }

        
    }
}
