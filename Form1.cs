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
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Sbmt_Click(object sender, EventArgs e)
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

            highest++;

            mainDirectory(highest);
            generateContractTracingForm(highest);             
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
            mainFile.WriteLine("Name:(Last Name, First Name, Middle Initial) " + TxtBx_LastName.Text + ", " + TxtBx_FirstName.Text + ", " + TxtBx_MiddleInitial.Text);
            mainFile.WriteLine(createDate + "|" + createTime);
            mainFile.WriteLine();
            mainFile.Close();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainDirectory(highest);
        }
        
    }
}

