using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractTracingApp
{
    public partial class Form1 : Form
    {
        String createDate = DateTime.Now.ToLongDateString();
        String createTime = DateTime.Now.ToLongTimeString();
        int highest = 0;
        Boolean complete = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Sbmt_Click(object sender, EventArgs e)
        {
            blankTextBox();
            if (complete)
            {
                Btn_Sbmt.Enabled = false;
                fileRenaming();

                highest++;

                mainDirectory(highest);
                generateContractTracingForm(highest);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter mainFile;
            mainFile = File.AppendText("MainDirectory.txt");
            for (int i = 0; i <= 20; i++)
            {
                if (i == 20)
                {
                    mainFile.WriteLine("=");
                }
                mainFile.Write("=");
            }
            for (int i = 0; i <= 2; i++)
            {
                if (i == 2)
                {
                    mainFile.Write("Start of Program");
                    for (int j = 0; j < 1; j++)
                    {
                        mainFile.Write("=");
                        if (j == 1)
                        {
                            mainFile.WriteLine("=");
                        }
                    }
                }
                mainFile.Write("=");
            }
            mainFile.Close();
        }

        private void generateContractTracingForm(int patientNum)
        {
            StreamWriter outputFile;

            outputFile = File.CreateText("ContactNo_" + patientNum + ".txt");
            outputFile.WriteLine("First Name: " + TxtBx_FirstName.Text);
            outputFile.WriteLine("Last Name: " + TxtBx_LastName.Text);
            outputFile.WriteLine("M.I.: " + TxtBx_MiddleInitial.Text);
            outputFile.WriteLine("Age: " + TxtBx_Age.Text);
            outputFile.WriteLine("Sex: " + TxtBx_Sex.Text);
            outputFile.WriteLine("PWD: " + TxtBx_PWD.Text);
            outputFile.WriteLine("Address: " + TxtBx_Address.Text);
            outputFile.WriteLine("Contact Number: " + TxtBx_ContactNumber.Text);
            outputFile.Close();
        }

        private void fileRenaming()
        {
            String[] file = Directory.GetFiles(".", "ContactNo_*");
            for (int i = 0; i < file.Length; i++)
            {
                string filename = file[i];
                filename = filename.Replace(".\\ContactNo_", "");
                filename = filename.Replace(".txt", "");
                int count = int.Parse(filename);

                if (count > highest)
                {
                    highest = count;
                }
            }
        }

        private void mainDirectory(int patientNum)
        {
            StreamWriter mainFile;

            mainFile = File.AppendText("MainDirectory.txt");
            for (int i = 0; i < 20; i++)
            {
                mainFile.Write("=");
            }
            mainFile.WriteLine();
            mainFile.WriteLine("ContactNo:" + patientNum);
            mainFile.WriteLine();

            if (TxtBx_MiddleInitial.Text != "")
            {
                mainFile.WriteLine("Name:(Last Name, First Name, Middle Initial) " + TxtBx_LastName.Text + ", " + TxtBx_FirstName.Text + ", " + TxtBx_MiddleInitial.Text);
            }
            else
            {
                mainFile.WriteLine("Name:(Last Name, First Name) " + TxtBx_LastName.Text + ", " + TxtBx_FirstName.Text);
            }

            mainFile.WriteLine(createDate + "|" + createTime);
            mainFile.WriteLine();
            mainFile.Close();
        }

        private void blankTextBox()
        {
            if (TxtBx_FirstName.Text == "")
            {
                TxtBx_FirstName.BackColor = Color.LightPink;
                complete = false;
            }
            else
            {
                TxtBx_FirstName.BackColor = Color.White;
                complete = true;
            }

            if (TxtBx_LastName.Text == "")
            {
                TxtBx_LastName.BackColor = Color.LightPink;
                complete = false;
            }
            else
            {
                TxtBx_LastName.BackColor = Color.White;
                complete = true;
            }

            if (TxtBx_Age.Text == "")
            {
                TxtBx_Age.BackColor = Color.LightPink;
                complete = false;
            }
            else
            {
                TxtBx_Age.BackColor = Color.White;
                complete = true;
            }

            if (TxtBx_Sex.Text == "")
            {
                TxtBx_Sex.BackColor = Color.LightPink;
                complete = false;
            }
            else
            {
                TxtBx_Sex.BackColor = Color.White;
                complete = true;
            }

            if (TxtBx_PWD.Text == "")
            {
                TxtBx_PWD.BackColor = Color.LightPink;
                complete = false;
            }
            else
            {
                TxtBx_PWD.BackColor = Color.White;
                complete = true;
            }

            if (TxtBx_Address.Text == "")
            {
                TxtBx_Address.BackColor = Color.LightPink;
                complete = false;
            }
            else
            {
                TxtBx_Address.BackColor = Color.White;
                complete = true;
            }

            if (TxtBx_ContactNumber.Text == "")
            {
                TxtBx_ContactNumber.BackColor = Color.LightPink; 
                complete = false;
            }
            else
            {
                TxtBx_ContactNumber.BackColor = Color.White;
                complete = true;
            }

            if (complete)
            {
                if (TxtBx_MiddleInitial.Text == "")
                {
                    TxtBx_MiddleInitial.BackColor = Color.LightPink;
                    Btn_Sbmt.Enabled = false;

                    var messageBoxResult = MessageBox.Show("You did not input your middle initial. Are you sure?", "Missing Middle Initial", MessageBoxButtons.YesNo);

                    if (messageBoxResult == DialogResult.Yes)
                    {
                        fileRenaming();

                        highest++;

                        mainDirectory(highest);
                        generateContractTracingForm(highest);
                    }
                }
                else
                {
                    TxtBx_MiddleInitial.BackColor = Color.White;
                    complete = true;
                }
            }
            else
            {
                TxtBx_MiddleInitial.BackColor = Color.LightPink;
            }
        }
    }
}

