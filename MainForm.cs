//Programmer: Eva Zolotarev
//Project: Lab_5
//Date: 4/20/2020
//Description: Visual C# - Lab V practice exercise
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

namespace Lab_5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Execute immediately when form loads upon program startup
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateBoxes();

                flavorBox.SelectedItem = "Vanilla";
        }


        //Custom Method
        private void PopulateBoxes()
        {
            try
            {
                StreamReader inputFile;

                inputFile = File.OpenText("Flavors.txt");
                while (!inputFile.EndOfStream)
                {
                    flavorBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();

                inputFile = File.OpenText("Toppings.txt");
                while (!inputFile.EndOfStream)
                {
                    toppingsListBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

       

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Write order information to output file
                StreamWriter outputFile;
                outputFile = File.AppendText("Orders.txt");

                //Write current date to file
                outputFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));

                //Determine cone type and write to file
                if (sugarConeButton.Checked)
                {
                    outputFile.WriteLine("Sugar Cone");
                }
                else
                {
                    outputFile.WriteLine("Waffle Cone");
                }

                //Write selected ice cream flavor to file
                outputFile.WriteLine(flavorBox.SelectedItem.ToString());

                //Loop through all items in list box and write selected items to output file
                for (int count = 0; count < toppingsListBox.Items.Count; count++)
                {
                    //use GetSelected method to determine if a list box item is selected or not
                    if (toppingsListBox.GetSelected(count))
                    {
                        outputFile.WriteLine(toppingsListBox.Items[count]);
                    }
                }

                outputFile.WriteLine();
                outputFile.Close();
            }
            catch (Exception ex)
            {
                //Display message if error occurs when attempting to write file
                MessageBox.Show(ex.Message);
            }

            //Reset form to its original appearance
            sugarConeButton.Checked = true;
            flavorBox.SelectedItem = "Vanilla";
            toppingsListBox.ClearSelected();
            sugarConeButton.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create an instance of the new AboutForm form class
            AboutForm myAboutForm = new AboutForm();

            //Display AboutForm instance as a modal form
            myAboutForm.ShowDialog();
        }
    }
}
