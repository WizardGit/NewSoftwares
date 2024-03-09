﻿using System;
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
            Probability prob = new Probability();
            //Console.WriteLine(prob.Combination(5,3));
            //Debug.Write("\n");
            //Console.WriteLine(prob.OneRoll(6, 5, 5, 6));
            //Yahtzee(3);
            Simple();
            //prob.OneRoll(6, 0, 0);
            //prob.OneRoll(6, 5, 5);
            //prob.OneRoll(6, 5, 4);
            //prob.OneRoll(6, 1, 1);
            //prob.OneRoll(6, 5, 2);
            //prob.OneRoll(6, 5, 2);
            //prob.OneRoll(6, 3, 3);
            //prob.OneRoll(6, 5, 1);
            //prob.OneRoll(6, 4, 4);

        }  

        private void calbut2_Click(object sender, EventArgs e)
        {
            //int a = 0;
            //int b = 0;
            //int.TryParse(textBox1.Text, out a);
            //int.TryParse(textBox2.Text, out b);
            //int.TryParse(textBoxRolls.Text, out int currRoll);
            //templbl.Text = Combination(a,b).ToString() + "%";
        }

        private void calcProbsBtn_Click(object sender, EventArgs e)
        {
            Probability prob = new Probability();


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
            probYTxtBox.Text = Math.Round(prob.PercentOfAKind(currRoll, 5, 6), 2).ToString() + "%";
            //perform calculations 
        }  

        public void Simple()
        {
            Probability prob = new Probability();
            double result = 0.0;
            //Console.WriteLine(Chicken(3, 5));
            //Console.WriteLine(Chicken(3, 4));
            //Console.WriteLine(Chicken(3, 3));
            //Console.WriteLine(Chicken(3, 2));
            //Console.WriteLine(Chicken(3, 1));
            //Console.WriteLine(Chicken(3, 0));
            //Console.WriteLine(Yahtzee(2));
            //Console.WriteLine(Yahtzee(3));
            //Console.WriteLine(Chicken(3, 5, 6));
            //Console.WriteLine(prob.OneRoll(6, 5, 5) * 600);
            //Console.WriteLine(prob.OneRoll(6, 5, 4) * 600);
            //Console.WriteLine(prob.OneRoll(6, 5, 3) * 600);
            //Console.WriteLine(prob.OneRoll(6, 5, 2) * 600); //reported wrong
            //Console.WriteLine(prob.OneRoll(6, 5, 1) * 600);
            //Console.WriteLine(Chicken(2, 5,6));
            //Console.WriteLine(Chicken(1, 4, 6));
            //Console.WriteLine(Chicken(2, 4, 6));
            //Console.WriteLine(Chicken(2, 3, 6));
            //Console.WriteLine(Chicken(3, 4, 6));
            //Console.WriteLine(Chicken(3, 3, 6));
            //Console.WriteLine(Chicken(3, 5,6));
            //Console.WriteLine(Chicken(2, 5, 1));
            //Console.WriteLine(Chicken(3, 5, 1));

            Console.WriteLine(prob.PercentOfAKind(3,5,6));
            Console.WriteLine(prob.PercentOfAKind(3, 4, 6));
            Console.WriteLine(prob.PercentOfAKind(3, 3, 6));
            Console.WriteLine(prob.PercentOfAKind(3, 2, 6));
            Console.WriteLine(prob.PercentOfAKind(3, 1, 6));
            Console.WriteLine(prob.PercentOfAKind(3, 0, 6));
        }
    }
}
