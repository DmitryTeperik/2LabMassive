﻿/*
    (16) 
    Нахождение последовательности подряд идущих элементов
    в целочисленном массиве с суммой наиболее близкой к F.
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CA1
{
    public partial class Form1 : Form
    {

        private int MIN = -10, MAX = 10, LEN_FOR_RANDOM = 10;

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// btnFind pressed. Main work is here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void btnFind_Click(object sender, EventArgs e)
        {
            List<int> list = Help.StringToIntList(tbArray.Text);

            if (list.Count == 0)
            {
                MessageBox.Show("List is empty");
                return;
            }

            if (int.TryParse(tbF.Text, out int F))
            {
                //main work is here
                tbResult.Text = string.Join(" ", Help.Find(list, F));
            }
            else
            {
                MessageBox.Show("F value is not allowed");
                return;
            }

        }


        /// <summary>
        /// Cleaning tb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbArray.Clear();
        }


        /// <summary>
        /// Filling tb with random numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRandom_Click(object sender, EventArgs e)
        {
            tbArray.Clear();
            Random rnd = new Random();
            for (int i = 0; i < LEN_FOR_RANDOM; i++) tbArray.AppendText(rnd.Next(MIN, MAX).ToString() + " ");
        }

        /// <summary>
        /// Enable only digits, minus and spaces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbArray_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(char.IsControl(c) || c == ' ' || char.IsDigit(c) || c == '-'))
                e.Handled = true;
        }



        /// <summary>
        /// Enable only digits and minus 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>       
        private void tbF_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(char.IsControl(c) || char.IsDigit(c) || tbF.Text == "" && e.KeyChar == '-'))
                e.Handled = true;

        }
        
    }
}
