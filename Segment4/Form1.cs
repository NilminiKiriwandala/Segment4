using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView.Items.Add("Apple");
            listView.Items.Add("Banana");
            listView.Items.Add("Orange");
            listView.Items.Add("asparagus");
            listView.Items.Add("beetroot");
            listView.Items.Add("Black-eye been");
            listView.Items.Add("Cherry");
            listView.Items.Add("clementine");
          
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (txtChar.Text != string.Empty)
            {
                char val = txtChar.Text.ToString()[0];
                List<string> originalList = new List<string>();

                foreach (ListViewItem item in listView.Items)
                {
                    originalList.Add(item.SubItems[0].Text.ToString());
                }
                List<string> sortedList = Sort(originalList, val);

                string listItems = string.Empty;
                foreach (string item in sortedList)
                {
                    listItems = listItems + "\n" + item;
                }
                lblDisplay.Text = listItems;
            }
        }
        public List<string> Sort(List<string> theList, char theChar)
        {
            List<string> resultList = new List<string>();

            foreach (string item in theList)
            {
                if (item[0] == (theChar.ToString().ToUpper())[0] || item[0] == (theChar.ToString().ToLower())[0])
                {

                    resultList.Add(item);

                }
            }
            return resultList;
        }
    }
}
