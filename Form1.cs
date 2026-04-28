using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {

        //store the citizen profile after validation

        CitizenProfile profile;

        public Form1()

        {

            //sets up all the controls

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)

        {//citizenship options in a combo box in design


            comboBox1.Items.Add("South African");
            comboBox1.Items.Add("Perment Resident");
            comboBox1.Items.Add("Visitor");
            comboBox1.SelectedIndex = 0;

            lblResult.Text = "";
            txtOutput.Text = "";
            
        }
       //run code when button is clicked
        private void btnValidate_Click(object sender,EventArgs e)
        {

            if 
                (txtName.Text == "" || txtID.Text == "")
                
            {
                MessageBox.Show("Please enter your Name and ID number.");

                return;

                //will stop code if the methode from if input is missing

            }

            profile = new CitizenProfile(txtName.Text, txtID.Text, comboBox1.Text);

            lblResult.Text = profile.ValidateID();

        }

        private void btnGenerate_Click(object sender,EventArgs e)
        {
            if 
                (profile == null)     
            {

                MessageBox.Show("Please validate the ID first.");

                return;   

            }

            //display in box (textbox)the citizens summary

            txtOutput.Text =
                "==== DIGITAL CITIZEN SUMMARY ====\r\n" +
                "Name: " + profile.FullName + "\r\n" +
                "ID Number: " + profile.IDNumber + "\r\n" +
                "Age: " + profile.Age + "\r\n" +
                "Citizenship: " + profile.CitizenshipStatus + "\r\n" +
                "Validation: " + profile.ValidateID() + "\r\n" +
                "Timestamp: " + DateTime.Now;
        }


        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

       

        private void btnValidate_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
