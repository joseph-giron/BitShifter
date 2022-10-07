﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace XOR_By
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnXorBy_Click(object sender, EventArgs e)
        {
            cvt.RunWorkerAsync();
        }

        private void cvt_DoWork(object sender, DoWorkEventArgs e)
        {
            if (tbShiftBy.Text == "")
            {
                MessageBox.Show("Missing value to XOR by, please enter something!");
                return;
            }
          /*  if (tbTextIn.Text == "")
            {
                MessageBox.Show("Missing text data to XOR by, please enter something!");
                return;
            }*/
            if (cbShifter.Text == "")
            {
                MessageBox.Show("How am I supposed to transform the data? Pick something!");
                return;
            }
            if(tbInFile.Text == "")
            {
                MessageBox.Show("Missing Input File");
                return;
            }
            if (tbOutFileName.Text == "")
            {
                MessageBox.Show("Missing Input File");
                return;
            }
            try
            {
                if(cbExperimental.Checked)
                {
                    int min = Convert.ToInt32(tbLowerRange.Text);
                    int max = Convert.ToInt32(tbUpperRange.Text);
                    pbSearchIteration.Minimum = min;
                    pbSearchIteration.Maximum = max;
                    
                    for(;min>max;min++)
                    {
                        ExperimentalFunc(min, max,tbSearchString.Text);
                        pbSearchIteration.PerformStep();
                    }

                }
                int shiftbyval = Convert.ToInt32(tbShiftBy.Text);
                //string filename = tbInFile.Text;
                string tmpfile = tbInFile.Text;
                string outfile = tbOutFileName.Text;
                //File.WriteAllText(tmpfile, tbTextIn.Text);
                switch (cbShifter.Text)
                {
                    case "XOR":
                        byte[] buffer1 = File.ReadAllBytes(tmpfile);
                        byte[] resultBuffer = new byte[buffer1.Length];
                        for (int i = 0; i < buffer1.Length; i++)
                        {
                            resultBuffer[i] = (byte)(buffer1[i] ^ shiftbyval);
                        }
                        File.WriteAllBytes(outfile, resultBuffer);
                        tbTextOut.Text = File.ReadAllText(outfile);
                        lblLength.Text = "Length: " + buffer1.Length.ToString() + " Bytes";;
                        break;
                    case "OR":
                        byte[] buffer2 = File.ReadAllBytes(tmpfile);
                        byte[] resultBuffer2 = new byte[buffer2.Length];
                        for (int i = 0; i < buffer2.Length; i++)
                        {
                            resultBuffer2[i] = (byte)(buffer2[i] | shiftbyval);
                        }
                        File.WriteAllBytes(outfile, resultBuffer2);
                        tbTextOut.Text = File.ReadAllText(outfile);
                        lblLength.Text = "Length: " + buffer2.Length.ToString() + " Bytes";;
                        break;
                    case "AND":
                        byte[] buffer3 = File.ReadAllBytes(tmpfile);
                        byte[] resultBuffer3 = new byte[buffer3.Length];
                        for (int i = 0; i < buffer3.Length; i++)
                        {
                            resultBuffer3[i] = (byte)(buffer3[i] & shiftbyval);
                        }
                        File.WriteAllBytes(outfile, resultBuffer3);
                        tbTextOut.Text = File.ReadAllText(outfile);
                        lblLength.Text = "Length: " + buffer3.Length.ToString() + " Bytes";;
                        break;
                    case "Bitwise Compliment":
                        byte[] buffer4 = File.ReadAllBytes(tmpfile);
                        byte[] resultBuffer4 = new byte[buffer4.Length];
                        for (int i = 0; i < buffer4.Length; i++)
                        {
                            resultBuffer4[i] = (byte)~Convert.ToInt32(buffer4[i]);
                        }
                        File.WriteAllBytes(outfile, resultBuffer4);
                        tbTextOut.Text = File.ReadAllText(outfile);
                        lblLength.Text = "Length: " + buffer4.Length.ToString() + " Bytes";;
                        break;

                    case "Left Shift":
                        byte[] buffer5 = File.ReadAllBytes(tmpfile);
                        byte[] resultBuffer5 = new byte[buffer5.Length];
                        for (int i = 0; i < buffer5.Length; i++)
                        {
                            resultBuffer5[i] = (byte)(buffer5[i] << shiftbyval);
                        }
                        File.WriteAllBytes(outfile, resultBuffer5);
                        tbTextOut.Text = File.ReadAllText(outfile);
                        lblLength.Text = "Length: " + buffer5.Length.ToString() + " Bytes";;
                        break;
                    case "Right Shift":
                        byte[] buffer6 = File.ReadAllBytes(tmpfile);
                        byte[] resultBuffer6 = new byte[buffer6.Length];
                        for (int i = 0; i < buffer6.Length; i++)
                        {
                            resultBuffer6[i] = (byte)(buffer6[i] >> shiftbyval);
                        }
                        File.WriteAllBytes(outfile, resultBuffer6);
                        tbTextOut.Text = File.ReadAllText(outfile);
                        lblLength.Text = "Length: " + buffer6.Length.ToString() + " Bytes";;
                        break;
                    case "RC4": // not working :(
                        //File.WriteAllBytes(outfile, resultBuffer7);
                        tbTextOut.Text = RC4(tmpfile, tbShiftBy.Text);
                        lblLength.Text = "This one is broke :(";
                        break;
                }
          
            }
            catch (Exception)
            {
                MessageBox.Show("just use ints plz");
                return;
    }
           
  }
        private bool ExperimentalFunc(int min, int max, string searchstr)
        {
            string searchfor = ""; // output from shift
            for (; min > max; min++)
            {

                // meat here

                if (searchfor == searchstr)
                { return true;  }
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        public static string RC4(string input, string key)
        {
            StringBuilder result = new StringBuilder();
            int x, y, j = 0;
            int[] cube = new int[256];

            for (int i = 0; i < 256; i++)
            {
                cube[i] = i;
            }

            for (int i = 0; i < 256; i++)
            {
                j = (key[i % key.Length] + cube[i] + j) % 256;
                x = cube[i];
                cube[i] = cube[j];
                cube[j] = x;
            }

            for (int i = 0; i < input.Length; i++)
            {
                y = i % 256;
                j = (cube[y] + j) % 256;
                x = cube[y];
                cube[y] = cube[j];
                cube[j] = x;

                result.Append((char)(input[i] ^ cube[(cube[y] + cube[j]) % 256]));
            }
            return result.ToString();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                tbInFile.Text = filename;

            }

        }

        private void btnOutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filename = sfd.FileName;
                tbOutFileName.Text = filename;
            }

        }

        private void cbExperimental_CheckedChanged(object sender, EventArgs e)
        {
            if(cbExperimental.Checked)
            {
                tbSearchString.Enabled = true;
                tbLowerRange.Enabled = true;
                tbUpperRange.Enabled = true;
                
            }
            else
            {
                tbSearchString.Enabled = false;
                tbLowerRange.Enabled = false;
                tbUpperRange.Enabled = false;
               
            }
            

        }
    }
}
