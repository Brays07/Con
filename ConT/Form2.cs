using System;
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
       List<DateOnly> VisitDate = new List<DateOnly>();
       List<ListViewItem> items = new List<ListViewItem>();
       List<string> data = new List<string>();
        List<ListBox> listBoxes = new List<ListBox>();

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
            while ((line = file.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
                counter++;
            }

        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
           
        }

        private void btnViewFilterData_Click(object sender, EventArgs e)
        {
            
        }

       

        private void FormInfo_Show(object sender, EventArgs e)
        {
          
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void SelectedD_IndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int index = (int)item.Tag;
                listBox1.Text = data[index];
            }
        }
    }
}
