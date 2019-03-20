using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // gives us access to IO namespace

namespace Chap5cProject
{
    public partial class frmRandom : Form
    {
        public frmRandom()
        {
            InitializeComponent();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swrOuput;
                int intNumRNs, intCounter;
                double dblNumber;
                Random randNumber = new Random();
                if (int.TryParse (txtNumberOfRandNums.Text, out intNumRNs))
                {
                    if (intNumRNs >= 1 && intNumRNs <= 9999)
                    {
                        // input is valid, so continue...
                        dlgSaveFile.Title = "Enter file name and location to be created...";
                        dlgSaveFile.InitialDirectory = Application.StartupPath;
                        dlgSaveFile.DefaultExt = "txt";
                        if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                        {
                            swrOuput = File.CreateText(dlgSaveFile.FileName);
                            for (intCounter = 1; intCounter <= intNumRNs; intCounter++)
                            {
                                dblNumber = randNumber.NextDouble();
                                swrOuput.WriteLine(dblNumber);
                            }
                            swrOuput.Close();
                        }
                        else
                        {
                            MessageBox.Show("Creation of output file was cancelled.");
                        }      
                    }
                    else
                    {
                        MessageBox.Show("Number of random numbers must be between 1 and 9999.");
                    }
                }
                else
                {
                    MessageBox.Show("Number of random numbers must be an integer.");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error while creating output file."
                    + "\n" + ex.Message);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader srdInput;
                double dblNumber, dblTotal = 0;
                int intRN_Count = 0;
                dlgOpenFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                dlgOpenFile.InitialDirectory = Application.StartupPath;
                dlgOpenFile.Title = "Select a file of random numbers...";
                if (dlgOpenFile.ShowDialog() == DialogResult.OK)
                {
                    // Instantiate the streamreader object
                    srdInput = File.OpenText(dlgOpenFile.FileName);
                    lstRandomNums.Items.Clear();
                    while (!srdInput.EndOfStream)
                    {
                        dblNumber = double.Parse(srdInput.ReadLine());
                        lstRandomNums.Items.Add(dblNumber);
                        dblTotal += dblNumber;
                        intRN_Count++;
                    }
                    srdInput.Close();
                    lblNumRNs.Text = intRN_Count.ToString();
                    if (intRN_Count > 0)
                    {
                        lblAverage.Text = (dblTotal / intRN_Count).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Opening of input file was cancelled.");
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while trying to read input file." + "\n" + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
