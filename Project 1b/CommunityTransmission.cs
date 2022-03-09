using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class CommunityTransmission : Form
    {
        public CommunityTransmission()
        {
            InitializeComponent();
        }

        private void CommunityTransmission_Load(object sender, EventArgs e)
        {
            //use a while loop to generate the months on the lstMonth
            int index = 1;
            while (index <= 12)
            {
                lstMonth.Items.Add(index);
                index++;
            }

            //use a do while loop to generates the days on the lstDay
            index = 1;
            do
            {
                lstDay.Items.Add(index);
                index++;
            } while (index <= 31);

            //use for loop to generate the years on the lstYear
            for (index = 2015; index <= 2025; index++)
            {
                lstYear.Items.Add(index);
            }

            return;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //check if txtCountry is empty
            if (txtCounty.Text.Trim() == String.Empty)
            {
                lblOutputResult.Text = "Country required";
                txtCounty.SelectAll();
                txtCounty.Focus();
            }
            else if(txtNewCasesX100.Text.Trim() == String.Empty)
            {
                lblOutputResult.Text = "New cases per 100 required";
                txtNewCasesX100.SelectAll();
                txtNewCasesX100.Focus();
            }
            else if (txtTotalVaccinated.Text.Trim() == String.Empty)
            {
                lblOutputResult.Text = "Positivity rate required";
                txtTotalVaccinated.SelectAll();
                txtTotalVaccinated.Focus();
            }
            else if(lstMonth.SelectedIndex == -1)
            {
                lblOutputResult.Text = "Please select a month";
            }
            else if (lstDay.SelectedIndex == -1)
            {
                lblOutputResult.Text = "Please select a day";
            }
            else if (lstYear.SelectedIndex == -1)
            {
                lblOutputResult.Text = "Please select a year";
            }
            else
            {
                try
                {
                    //store the selected lists 
                    int month = int.Parse(lstMonth.SelectedItem.ToString());
                    int day = int.Parse(lstDay.SelectedItem.ToString());
                    int year = int.Parse(lstYear.SelectedItem.ToString());

                    //create a new submissionDate object
                    DateTime newDate = new DateTime(year, month, day);

                    //instantiate new community object
                    Community newCommunity = new Community(txtCounty.Text, newDate, int.Parse(txtNewCasesX100.Text),
                        int.Parse(txtTotalVaccinated.Text));


                }
                catch (Exception ex)
                {
                    lblOutputResult.Text = ex.Message;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCounty.Clear();
            txtNewCasesX100.Clear();
            txtTotalVaccinated.Clear();
            
            lstMonth.ClearSelected();
            lstDay.ClearSelected();
            lstYear.ClearSelected();

            lblOutputResult.ResetText();

            txtCounty.Focus();
        }
    }
}
