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

//Author: Kyle Janka
//ID: 565104
//Date: 5/3/19
//Goal-Purpose of the Program: Allows user to input a file and see it's content displayed.

namespace FileReaderKyleJanka
{
    public partial class fileReader : Form
    {
        public fileReader()
        {
            InitializeComponent();
        }

        private void readFileBtn_Click(object sender, EventArgs e)
        {

            //Input
            string pathString = "";
            string fileString = "";

            pathString = enterFileTxt.Text;

            //Validation
            if ( pathString == "")
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }

            //Processing
            try
            {
                StreamReader myFile;

                myFile = File.OpenText(pathString);

                while (!myFile.EndOfStream)
                {
                    //Output
                    fileString = myFile.ReadLine();

                    displayList.Items.Add(fileString);
                }
                myFile.Close();
            }
            //Validation
            catch(Exception myException)
            {
                MessageBox.Show(myException.Message);
                return;
            }

        }
    }
}
