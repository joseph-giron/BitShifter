using System;
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
                    case "RC4": 

                        byte[] buffer7 = File.ReadAllBytes(tmpfile);
                        byte[] strbytes = Encoding.ASCII.GetBytes(tbShiftBy.Text);
                        byte[] rc4result=Apply_RC4(buffer7, strbytes);

                        tbTextOut.Text = Encoding.ASCII.GetString(rc4result);
                        File.WriteAllBytes(outfile, rc4result);
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

        private static bool archivecheck(byte[] datacheck)
        {
            
            Console.WriteLine("Testing file...");
            Console.Read();
            byte[] zipheader = { 0x04, 0x03, 0x4b, 0x50 };
            byte[] sevenzip = { 0x37, 0x7A, 0xBC, 0xAF, 0x27, 0x1C };
            byte[] gzip1 = { 0x1F, 0x8B, 0x08, 0x08 };
            byte[] gzip2 = { 0x1F, 0x8B, 0x08, 0x00 };
            byte[] squashfs = { 0x73, 0x71, 0x73, 0x8 };
            byte[] UBI = { 0x55, 0x42, 0x49, 0x23 };
            byte[] cramfs = { 0x28, 0xCD, 0x3D, 0x45 };
            byte[] readem = datacheck;
            for (int key = 0; key < 65535; key++)
            {
                zipheader[0] = (byte)(readem[0] ^ key);
                zipheader[1] = (byte)(readem[1] ^ key);
                zipheader[2] = (byte)(readem[2] ^ key);
                zipheader[3] = (byte)(readem[3] ^ key);

                if (zipheader == readem)
                {
                    Console.WriteLine("Zip header found with key {0}", key);
                    break;
                }
            }
            return false;
        }

        /// <summary>
        ///     Give data and an encryption key, apply RC4 cryptography.  RC4 is symmetric,
        ///     which means this single method will work for encrypting and decrypting.
        /// </summary>
        /// <remarks>
        ///     https://en.wikipedia.org/wiki/RC4
        /// </remarks>
        /// <param name="data">
        ///     Byte array representing the data to be encrypted/decrypted
        /// </param>
        /// <param name="key">
        ///     Byte array representing the key to use
        /// </param>
        /// <returns>
        ///     Byte array representing the encrypted/decrypted data.
        /// </returns>

        public static byte[] Apply_RC4(byte[] data, byte[] key)
        {
            //  Key Scheduling Algorithm Phase:
            //  KSA Phase Step 1: First, the entries of S are set equal to the values of 0 to 255 
            //                    in ascending order.
            int[] S = new int[256];
            for (int _ = 0; _ < 256; _++)
            {
                S[_] = _;
            }

            //  KSA Phase Step 2a: Next, a temporary vector T is created.
            int[] T = new int[256];

            //  KSA Phase Step 2b: If the length of the key k is 256 bytes, then k is assigned to T.  
            if (key.Length == 256)
            {
                Buffer.BlockCopy(key, 0, T, 0, key.Length);
            }
            else
            {
                //  Otherwise, for a key with a given length, copy the elements of
                //  the key into vector T, repeating for as many times as neccessary to
                //  fill T
                for (int _ = 0; _ < 256; _++)
                {
                    T[_] = key[_ % key.Length];
                }
            }

            //  KSA Phase Step 3: We use T to produce the initial permutation of S ...
            int i = 0;
            int j = 0;
            for (i = 0; i < 256; i++)
            {
                //  increment j by the sum of S[i] and T[i], however keeping it within the 
                //  range of 0 to 255 using mod (%) division.
                j = (j + S[i] + T[i]) % 256;

                //  Swap the values of S[i] and S[j]
                int temp = S[i];
                S[i] = S[j];
                S[j] = temp;
            }


            //  Pseudo random generation algorithm (Stream Generation):
            //  Once the vector S is initialized from above in the Key Scheduling Algorithm Phase,
            //  the input key is no longer used.  In this phase, for the length of the data, we ...
            i = j = 0;
            byte[] result = new byte[data.Length];
            for (int iteration = 0; iteration < data.Length; iteration++)
            {
                //  PRGA Phase Step 1. Continously increment i from 0 to 255, starting it back 
                //                     at 0 once we go beyond 255 (this is done with mod (%) division
                i = (i + 1) % 256;

                //  PRGA Phase Step 2. Lookup the i'th element of S and add it to j, keeping the
                //                     result within the range of 0 to 255 using mod (%) division
                j = (j + S[i]) % 256;

                //  PRGA Phase Step 3. Swap the values of S[i] and S[j]
                int temp = S[i];
                S[i] = S[j];
                S[j] = temp;

                //  PRGA Phase Step 4. Use the result of the sum of S[i] and S[j], mod (%) by 256, 
                //                     to get the index of S that handls the value of the stream value K.
                int K = S[(S[i] + S[j]) % 256];

                //  PRGA Phase Step 5. Use bitwise exclusive OR (^) with the next byte in the data to
                //                     produce  the next byte of the resulting ciphertext (when 
                //                     encrypting) or plaintext (when decrypting)
                result[iteration] = Convert.ToByte(data[iteration] ^ K);
            }

            //  return the result
            return result;
        }

    }
}
