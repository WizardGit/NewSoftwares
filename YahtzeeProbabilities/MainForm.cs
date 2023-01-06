using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int p = 0;
            int.TryParse(OnesTextBox.Text, out p);

            //OnesAnswer.Text = (MultipleRolls(p,6,5,100) * 100).ToString() + " || " + (OneRoll(p, 6) * 100).ToString();
            //OnesAnswer.Text = NumCombin(4,7).ToString();
            
        }


        //a sides on dice: 6 good
        //b number of dice: 5 good
        //c number of rolls: 1
        //d number to get: 1 good
        //e number of d to get: good

        //Probability of getting e of that number in a single roll with 1 roll
        private float OneRoll(int e, int a = 6, int b=5, int c=1, int d=1)
        {
            float prob = 1.0f;

            if (e > b)
                throw new Exception("You can't get more of a number than dice you are rolling!");

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

        
        //Probability of getting e of that number in a single roll with c rolls
        private float MultipleRolls(int e, int a = 6, int b = 5, int c = 1, int d = 1)
        {
            float prob = 1.0f;

            if (e > b)
                throw new Exception("You can't get more of a number than dice you are rolling!");

            for (int i = 0; i < c; i++)
            {
                prob *= (1.0f - OneRoll(e,a,b,c,d));
            }

            return (1.0f - prob);
        }


        //Number of combinations that "a" dice can be selected with a particular number out of "b" dice
        // (a out of b)
        // i.e. how many ways can there be two dice with a number 1 when you have three dice
        private int NumCombin(int a, int b)
        {
            if ((a > b) || (a < 0))
                throw new Exception("You must request > 0 or < a dice!");

            int topsum = 1;
            int bottomsum = 1;
            for (int i = (b - a); i > 0; i--)
            {
                topsum *= (b + 1 - i);
                bottomsum *= i;
            }
            return topsum / bottomsum;
        }

        // Probability of getting "b" of (a number on a six-sided dice) with "a" dice in 1 roll
        private double Func2(int a, int b)
        {
            if ((a > b) || (a < 0))
                throw new Exception("You must request > 0 or < a dice!");

            double prob = 1.0;

            for (int i = 0; i < a; i++)
            {
                prob *= 1.0 / 6.0;
            }
            for (int i = b; a < i; i--)
            {
                prob *= 5.0 / 6.0;
            }

            return prob * NumCombin(a,b);
        }

        // Probability of getting at least "b" of (a number on a six-sided dice) with "a" dice in 1 roll
        private double AtLeastFunc2(int a, int b)
        {
            double prob = 0.0;

            for (int i = a; i <= b; i++)
            {
                prob += Func2(i, b);
            }

            return prob;
        }

        // Probability of getting at mostt "b" of (a number on a six-sided dice) with "a" dice in 1 roll
        private double AtMostFunc2(int a, int b)
        {
            double prob = 0.0;

            for (int i = a; i >= 0; i--)
            {
                prob += Func2(i, b);
            }

            return prob;
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

        //How many ways can: a be in b

        //(Do recursion for the rolls)


        private void calbut2_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int.TryParse(textBox1.Text, out a);
            int.TryParse(textBox2.Text, out b);
            templbl.Text = NumCombin(a, b).ToString() + 
                "\n" + (AtLeastFunc2(a, b)*100).ToString() + 
                "\n" + (AtMostFunc2(a,b)*100).ToString() +
                "\n" + (RandFunc()*100).ToString();
        }

        private double RandFunc()
        {
            double multProb = 1.0;
            double ultimateSumProb = 0.0;
            int numRolls = 1;
            int currRollNum = 1;
            int numDiceToGet = 0;
            int numDiceWeHave = 5;

            double sum = 0;
            for (int i = numDiceToGet; i <= numDiceWeHave; i++)
            {
                multProb = 1.0;
                ultimateSumProb = 0.0;
                Recurse(multProb, ref ultimateSumProb, numRolls, currRollNum, i, numDiceWeHave);
                sum += ultimateSumProb;
            }
            

            return sum;
        }

        private void Recurse(double multProb, ref double ultimateSumProb, int numRolls, int currRollNum, int numDiceToGet, int numDiceWeHave)
        {
            if (currRollNum == numRolls)
            {
                double f = Func2(numDiceToGet, numDiceWeHave);
                multProb = multProb * f;
                ultimateSumProb = ultimateSumProb + multProb;
                return;
            }

            for (int i = numDiceToGet; i >= 0; i--)
            {
                //Calculate the probability of this happening
                double f = Func2(i, numDiceWeHave);
                Recurse(multProb * f, ref ultimateSumProb, numRolls, currRollNum + 1, numDiceToGet-i, numDiceWeHave);
            }
            return;
        }
    }
}
