﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class SlashForm : Form
    {
        public SlashForm()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }


        private void SlashForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        int startpoint = 0;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar1.Value = startpoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                MainBoard s = new MainBoard();
                s.Show();
                this.Hide();
            }
        }
    }
}
