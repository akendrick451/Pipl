using Pipl.APIs.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiplTake2
{
    public partial class Form1 : Form
    {

        SearchAPIResponse response;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {

            GetData();


        }


        private async Task GetData()
        {

            String STR_BUSINESS_DEMO_KEY = "39bpviejuuj74msm2090cfx6";

            SearchConfiguration searchConfiguration = new SearchConfiguration(apiKey: STR_BUSINESS_DEMO_KEY));

            

            SearchAPIRequest request = new SearchAPIRequest(            firstName: txtFirstname.Text,
            lastName: txtSurname.Text, state: txtState.Text, country: txtCountry.Text, requestConfiguration: searchConfiguration);


            MessageBox.Show("This process may take a number of seconds while we search for " + txtSurname.Text);

             response = await request.SendAsync();

            

            //Debug.WriteLine(response.Address);
            //Debug.WriteLine(response.DOB);
            //Debug.WriteLine(response.Email);

            Debug.WriteLine(response.PossiblePersons[0].Jobs[0]);

            txtResultsCount.Text = response.PersonsCount.ToString();
            txtResultsLeft2.Text = response.DemoUsageCurrent.ToString() + " / " + response.DemoUsageAlloted.ToString();


            cbJobResults.DisplayMember = "Text";
            cbJobResults.ValueMember = "Value";
            List<Object> items = new List<Object>();
            for ( int i = 0; i< response.PossiblePersons.Count; i++)
            {
                try
                {
                    items.Add(new { Text = response.PossiblePersons[i].Jobs[0], Value = i });
                } catch (Exception e)
                {
                    items.Add(new { Text = "no job" + i.ToString(), Value = i });
                }

            }
            cbJobResults.DataSource = items;


            fillInData(0);

            // Console.Out.WriteLine(response.Sources[0].OriginUrl);




        }

        public void fillInData(int intPersonSelected)
        {

            // clear last person
            txtJobResult.Text = "";
            txtEmailResult.Text = "";
            pBoxPhoto1.ImageLocation = "";
            txtImage1.Text = "";
            txtPhoneResult.Text = "";

            if (response.PossiblePersons[intPersonSelected].Jobs.Count > 0)
            {
                txtJobResult.Text = response.PossiblePersons[intPersonSelected].Jobs[0].ToString();
            }
            try
            {
                txtEmailResult.Text = response.PossiblePersons[intPersonSelected].Emails[0].ToString();
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
            if (response.PossiblePersons[intPersonSelected].Images.Count > 0) { 
                pBoxPhoto1.ImageLocation = response.PossiblePersons[intPersonSelected].Images[0].Url;
                txtImage1.Text = response.PossiblePersons[intPersonSelected].Images[0].Url;
            }



            if (response.PossiblePersons[intPersonSelected].Phones.Count > 0) {
                txtPhoneResult.Text = response.PossiblePersons[intPersonSelected].Phones[0].ToString();
            }
            



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbJobResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillInData(cbJobResults.SelectedIndex);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
