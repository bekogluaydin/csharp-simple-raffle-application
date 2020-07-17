using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giveaway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void rtxtCandidate_TextChanged(object sender, EventArgs e)
        {
            lblGiveawayNumber.Text = rtxtCandidate.Lines.Count().ToString();

            if (rtxtCandidate.Lines.Count()>0)
            {
                nQuantity.Maximum = rtxtCandidate.Lines.Count();
            }
            else
            {
                nQuantity.Minimum = 0;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtCandidate.Clear();
            dtgList.Rows.Clear();
            _giveawayCount = 1;
            nQuantity.Value = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtgList.ColumnCount = 2;

            dtgList.Columns[0].Name = "Sequence No:";
            dtgList.Columns[1].Name = "Name & Surname:";
        }

        int _giveawayCount = 1;
        private void btnGiveawayStart_Click(object sender, EventArgs e)
        {
            if (dtgList.Rows.Count > 1)
            {             
                dtgList.Rows.Clear();
                _giveawayCount = 1;
                
                if (dtgList.Rows.Count >= 0)
                {
                    MessageBox.Show("New Giveaway");
                    int giveawayNumber = Convert.ToInt32(nQuantity.Text);
                    List<string> listCandidate = new List<string>(rtxtCandidate.Text.Split('\n')); //It pieces the data line by line and adds it to the list.

                    if (rtxtCandidate.Text == "")
                    {
                        MessageBox.Show("You must enter the candidates");
                    }
                    else
                    {
                        Random generateNumber = new Random();

                        for (int i = 0; i < giveawayNumber; i++)
                        {
                            int winnerCandidate = generateNumber.Next(0, listCandidate.Count);
                            dtgList.Rows.Add(_giveawayCount++, listCandidate[winnerCandidate]);
                            listCandidate.Remove(listCandidate[winnerCandidate]);
                        }
                    }
                }
            }

            else
            {
                int giveawayNumber = Convert.ToInt32(nQuantity.Text);
                List<string> listCandidate = new List<string>(rtxtCandidate.Text.Split('\n')); //It pieces the data line by line and adds it to the list.

                if (rtxtCandidate.Text == "")
                {
                    MessageBox.Show("You must enter the candidates");
                }
                else
                {
                    Random generateNumber = new Random();

                    for (int i = 0; i < giveawayNumber; i++)
                    {
                        int winnerCandidate = generateNumber.Next(0, listCandidate.Count);
                        dtgList.Rows.Add(_giveawayCount++, listCandidate[winnerCandidate]);
                        listCandidate.Remove(listCandidate[winnerCandidate]);
                    }
                }
            }
        }

        private void nQuantity_ValueChanged(object sender, EventArgs e)
        {
            nQuantity.Maximum = rtxtCandidate.Lines.Count();
        }
    }
}