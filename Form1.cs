using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TunKeyLogger
{
    public partial class Form1 : Form
    {
        string names;
        int interactTimes;
        int inputNumber;

        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NamesWithComma()
        {
            names = nameTXT.Text;
            interactTimes = int.Parse(outputLimitTXT.Text);
            inputNumber = int.Parse(numberTXT.Text);

            string[] namesArr = names.Split(',');

            for (int i = 0;
                i < namesArr.Length;
                i++, interactTimes = int.Parse(outputLimitTXT.Text), inputNumber = int.Parse(numberTXT.Text))
            {
                if (onStartBTN.Checked)
                {
                    while (interactTimes != 0)
                    {
                        //Upper Case
                        textBox1.AppendText(inputNumber++ + namesArr[i].ToUpper() + Environment.NewLine);
                        interactTimes--;
                    }
                    textBox1.AppendText(inputNumber + namesArr[i].ToUpper() + Environment.NewLine);

                    interactTimes = int.Parse(outputLimitTXT.Text);
                    inputNumber = int.Parse(numberTXT.Text);
                    while (interactTimes != 0)
                    {
                        //Lower Case
                        textBox1.AppendText(inputNumber++ + namesArr[i].ToLower() + Environment.NewLine);
                        interactTimes--;
                    }
                    textBox1.AppendText(inputNumber + namesArr[i].ToLower() + Environment.NewLine);

                    interactTimes = int.Parse(outputLimitTXT.Text);
                    inputNumber = int.Parse(numberTXT.Text);
                    while (interactTimes != 0)
                    {
                        //First letter upper Case
                        textBox1.AppendText(inputNumber++ + namesArr[i].First().ToString().ToUpper() +
                                     namesArr[i].Substring(1) + Environment.NewLine);
                        interactTimes--;
                    }
                    textBox1.AppendText(inputNumber + namesArr[i].First().ToString().ToUpper() + namesArr[i].Substring(1) + Environment.NewLine);
                }
                else if (inTheEndBTN.Checked)
                {
                    while (interactTimes != 0)
                    {
                        //Upper Case
                        textBox1.AppendText(namesArr[i].ToUpper() + inputNumber++ + Environment.NewLine);
                        interactTimes--;
                    }
                    textBox1.AppendText(namesArr[i].ToUpper() + inputNumber + Environment.NewLine);

                    interactTimes = int.Parse(outputLimitTXT.Text);
                    inputNumber = int.Parse(numberTXT.Text);
                    while (interactTimes != 0)
                    {
                        //Lower Case
                        textBox1.AppendText(namesArr[i].ToLower() + inputNumber++ + Environment.NewLine);
                        interactTimes--;
                    }
                    textBox1.AppendText(namesArr[i].ToLower() + inputNumber + Environment.NewLine);

                    interactTimes = int.Parse(outputLimitTXT.Text);
                    inputNumber = int.Parse(numberTXT.Text);
                    while (interactTimes != 0)
                    {
                        //First letter upper Case
                        textBox1.AppendText(namesArr[i].First().ToString().ToUpper() + namesArr[i].Substring(1) +
                                    inputNumber++ + Environment.NewLine);
                        interactTimes--;
                    }
                    textBox1.AppendText(namesArr[i].First().ToString().ToUpper() + namesArr[i].Substring(1) + inputNumber + Environment.NewLine);
                }

                else if(bothBTN.Checked)//Both Cases
                {
                    //Numbers First
                    while (interactTimes != 0)
                    {
                        //Upper Case
                        textBox1.AppendText(inputNumber++ + namesArr[i].ToUpper() + Environment.NewLine);
                        interactTimes--;
                    }
                    textBox1.AppendText(inputNumber + namesArr[i].ToUpper() + Environment.NewLine);

                    interactTimes = int.Parse(outputLimitTXT.Text);
                    inputNumber = int.Parse(numberTXT.Text);
                    while (interactTimes != 0)
                    {
                        //Lower Case
                        textBox1.AppendText(inputNumber++ + namesArr[i].ToLower() + Environment.NewLine);
                        interactTimes--;
                    }
                    textBox1.AppendText(inputNumber + namesArr[i].ToLower() + Environment.NewLine);

                    interactTimes = int.Parse(outputLimitTXT.Text);
                    inputNumber = int.Parse(numberTXT.Text);
                    while (interactTimes != 0)
                    {
                        //First letter upper Case
                        textBox1.AppendText(inputNumber++ + namesArr[i].First().ToString().ToUpper() +
                                    namesArr[i].Substring(1) + Environment.NewLine);
                        interactTimes--;
                    }
                    textBox1.AppendText(inputNumber + namesArr[i].First().ToString().ToUpper() + namesArr[i].Substring(1) + Environment.NewLine);

                    //Numbers Last
                    interactTimes = int.Parse(outputLimitTXT.Text);
                    inputNumber = int.Parse(numberTXT.Text);
                    while (interactTimes != 0)
                    {
                        //Upper Case
                        textBox1.AppendText(namesArr[i].ToUpper() + inputNumber++ + Environment.NewLine);
                        interactTimes--;
                    }
                    textBox1.AppendText(namesArr[i].ToUpper() + inputNumber + Environment.NewLine);

                    interactTimes = int.Parse(outputLimitTXT.Text);
                    inputNumber = int.Parse(numberTXT.Text);
                    while (interactTimes != 0)
                    {
                        //Lower Case
                        textBox1.AppendText(namesArr[i].ToLower() + inputNumber++ + Environment.NewLine);
                        interactTimes--;
                    }
                    textBox1.AppendText(namesArr[i].ToLower() + inputNumber + Environment.NewLine);

                    interactTimes = int.Parse(outputLimitTXT.Text);
                    inputNumber = int.Parse(numberTXT.Text);
                    while (interactTimes != 0)
                    {
                        //First letter upper Case
                        textBox1.AppendText(namesArr[i].First().ToString().ToUpper() + namesArr[i].Substring(1) +
                                    inputNumber++ + Environment.NewLine);
                        interactTimes--;
                    }
                    textBox1.AppendText(namesArr[i].First().ToString().ToUpper() + namesArr[i].Substring(1) + inputNumber + Environment.NewLine);
                }
            }
            MessageBox.Show("Finished!");
        }

        private void NamesWithOutComma()

        {
            names = nameTXT.Text;
            interactTimes = int.Parse(outputLimitTXT.Text);
            inputNumber = int.Parse(numberTXT.Text);

            if (onStartBTN.Checked)
            {
                while (interactTimes != 0)
                {
                    //Upper Case
                    textBox1.AppendText(inputNumber++ + names.ToUpper() + Environment.NewLine);
                    interactTimes--;
                }
                textBox1.AppendText(inputNumber + names.ToUpper() + Environment.NewLine);

                interactTimes = int.Parse(outputLimitTXT.Text);
                inputNumber = int.Parse(numberTXT.Text);
                while (interactTimes != 0)
                {
                    //Lower Case
                    textBox1.AppendText(inputNumber++ + names.ToLower() + Environment.NewLine);
                    interactTimes--;
                }
                textBox1.AppendText(inputNumber + names.ToLower() + Environment.NewLine);

                interactTimes = int.Parse(outputLimitTXT.Text);
                inputNumber = int.Parse(numberTXT.Text);
                while (interactTimes != 0)
                {
                    //First letter upper Case
                    textBox1.AppendText(inputNumber++ + names.First().ToString().ToUpper() +
                                 names.Substring(1) + Environment.NewLine);
                    interactTimes--;
                }
                textBox1.AppendText(inputNumber + names.First().ToString().ToUpper() + names.Substring(1) + Environment.NewLine);
            }
            else if (inTheEndBTN.Checked)
            {
                while (interactTimes != 0)
                {
                    //Upper Case
                    textBox1.AppendText(names.ToUpper() + inputNumber++ + Environment.NewLine);
                    interactTimes--;
                }
                textBox1.AppendText(names.ToUpper() + inputNumber + Environment.NewLine);

                interactTimes = int.Parse(outputLimitTXT.Text);
                inputNumber = int.Parse(numberTXT.Text);
                while (interactTimes != 0)
                {
                    //Lower Case
                    textBox1.AppendText(names.ToLower() + inputNumber++ + Environment.NewLine);
                    interactTimes--;
                }
                textBox1.AppendText(names.ToLower() + inputNumber + Environment.NewLine);

                interactTimes = int.Parse(outputLimitTXT.Text);
                inputNumber = int.Parse(numberTXT.Text);
                while (interactTimes != 0)
                {
                    //First letter upper Case
                    textBox1.AppendText(names.First().ToString().ToUpper() + names.Substring(1) +
                                 inputNumber++ + Environment.NewLine);
                    interactTimes--;
                }
                textBox1.AppendText(names.First().ToString().ToUpper() + names.Substring(1) + inputNumber + Environment.NewLine);
            }
            else if(bothBTN.Checked) //Both Cases
            {
                //Numbers First
                while (interactTimes != 0)
                {
                    //Upper Case
                    textBox1.AppendText(inputNumber++ + names.ToUpper() + Environment.NewLine);
                    interactTimes--;
                }
                textBox1.AppendText(inputNumber + names.ToUpper() + Environment.NewLine);

                interactTimes = int.Parse(outputLimitTXT.Text);
                inputNumber = int.Parse(numberTXT.Text);
                while (interactTimes != 0)
                {
                    //Lower Case
                    textBox1.AppendText(inputNumber++ + names.ToLower() + Environment.NewLine);
                    interactTimes--;
                }
                textBox1.AppendText(inputNumber + names.ToLower() + Environment.NewLine);

                interactTimes = int.Parse(outputLimitTXT.Text);
                inputNumber = int.Parse(numberTXT.Text);
                while (interactTimes != 0)
                {
                    //First letter upper Case
                    textBox1.AppendText(inputNumber++ + names.First().ToString().ToUpper() +
                                 names.Substring(1) + Environment.NewLine);
                    interactTimes--;
                }
                textBox1.AppendText(inputNumber + names.First().ToString().ToUpper() + names.Substring(1) + Environment.NewLine);

                //Numbers Last
                interactTimes = int.Parse(outputLimitTXT.Text);
                inputNumber = int.Parse(numberTXT.Text);
                while (interactTimes != 0)
                {
                    //Upper Case
                    textBox1.AppendText(names.ToUpper() + inputNumber++ + Environment.NewLine);
                    interactTimes--;
                }
                textBox1.AppendText(names.ToUpper() + inputNumber + Environment.NewLine);

                interactTimes = int.Parse(outputLimitTXT.Text);
                inputNumber = int.Parse(numberTXT.Text);
                while (interactTimes != 0)
                {
                    //Lower Case
                    textBox1.AppendText(names.ToLower() + inputNumber++ + Environment.NewLine);
                    interactTimes--;
                }
                textBox1.AppendText(names.ToLower() + inputNumber + Environment.NewLine);

                interactTimes = int.Parse(outputLimitTXT.Text);
                inputNumber = int.Parse(numberTXT.Text);
                while (interactTimes != 0)
                {
                    //First letter upper Case
                    textBox1.AppendText(names.First().ToString().ToUpper() + names.Substring(1) +
                                 inputNumber++ + Environment.NewLine);
                    interactTimes--;
                }
                textBox1.AppendText(names.First().ToString().ToUpper() + names.Substring(1) + inputNumber + Environment.NewLine);
            }
            MessageBox.Show("Finished!");
        }


        //Go! button pressed
        private void button1_Click(object sender, EventArgs e)
        {
            names = nameTXT.Text;

            if (names.Contains(',')) //Multiple Names
            {
                NamesWithComma();
            }

            else //Just One Name!
            {
                NamesWithOutComma();
            }
        }

        //Save File As
        private void saveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName + ".txt", textBox1.Text);
            }
        }

        //Load File from dir
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileLBL.Text = openFileDialog1.FileName;
                textBox1.Text = File.ReadAllText(fileLBL.Text);
            }
        }

        //Clear grid text
        private void clearTxtBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(@"Welcome !!!
1.Write one or mulitple strings,for divide add ' , '. (no space between names!).
2.Enter a number to start interaction with.
3.Choose how to order the number(first / at the end / both).
4.Write a number of interaction times.
5.Choose which directory to save the text file.
6.Finish.

   * Press go, and check the file :)
   * Have fun!

                         All rights reserved to Yadin yafe.
                         Copyright ©");
        }
    }
}
