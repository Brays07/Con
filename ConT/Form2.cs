﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConT
{
    public partial class Form2 : Form
    {
        public Form1 Mainform;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
       
        }

        private void btnView_Click(object sender, EventArgs e)
        {
             int counter = 0;
             string line;
             StreamReader file = new StreamReader(@"C:\Users\user\Documents\Contact\KonohaVisitors.txt");
             while((line = file.ReadLine()) != null)
             {
                 Data.Items.Add(line);
                 counter++;
             }
        }
            private void btnFilter_Click(object sender, EventArgs e)
        {

        }
      

        private void btnViewFilterData_Click(object sender, EventArgs e)
        {
      
        }
    }
}