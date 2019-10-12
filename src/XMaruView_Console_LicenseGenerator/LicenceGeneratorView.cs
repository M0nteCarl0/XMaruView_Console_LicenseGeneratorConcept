using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
/*
 *  (C)2019
 *
 * Author: M0nteCarl0
 *
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */



namespace XMaruView_Console_LicenseGenerator
{

    public enum LicenseOptions{
    AutoStitching = 0,
    SYFM = 1,
    ChiroTool = 2,
    GridOn = 3,
    HL7 = 4,
    OverlayMarker = 5,
    CloneImage = 6,
    PrintComposer = 7,
    RealtimeImageProcessing = 8,
    DerivedImage = 9,
}




    public partial class LicenceGeneratorView : Form
    {

        LicenseOptions _LicenceOpts;
        private String _RequestCode;
        private String _ActivationCode;
        private String[] _LicenceOptions;
        public LicenceGeneratorView()
        {
            InitializeComponent();
            _LicenceOpts = LicenseOptions.DerivedImage;
            RequestCode_textBox.Text = CreateRequestCode();
            _LicenceOptions = new String[10];
            CheckLicenceOptions();

        }

       
        void CheckLicenceOptions()
        {
             for (int i = 0; i < 9; i++)
            {
                _LicenceOptions[i] = "0";

            }

            foreach (int indexChecked in LicenceOptionscheckedListBox.CheckedIndices)
            {
                _LicenceOptions[indexChecked] = "1";
            }

        }

        private string CreateActivationCode(string RequestCode)
        {

            CheckLicenceOptions();
            string[] OriginalRequestCode = DecryptRequestCode(RequestCode).Split(new char[]{'_'});
            string ActivationCode = GenActivationString(OriginalRequestCode[0], OriginalRequestCode[1], _LicenceOptions);
            ActivationCode = EncryptActivationCode(ActivationCode);
            return ActivationCode;

        }

        string GenActivationString(string HDDid, string TimeTiks, string[] OptionLicenceKeys)
        {
            string ActiveString = null;
            string OptionsArray = null;
            OptionsArray = string.Join(";",OptionLicenceKeys);
            ActiveString = string.Format("{0}_{1}_{2}", HDDid, TimeTiks, OptionsArray);
            return ActiveString;

        }

        private string CreateRequestCode()
        {
            string str1 = null;
            string str2 = GetHDDId("C");
            long num1 = GetTick(new DateTime(2001, 1, 1));
            str1 = string.Format("{0}_{1}", str2, num1.ToString());
            _RequestCode = EncryptString(str1, "clearON");
            return _RequestCode;
        }

        private string DecryptRequestCode(string RequestCode)
        {
            return DecryptString(RequestCode, "clearON");
        }

        private string DecryptActivationCode(string ActivationCode)
        {
            return DecryptString(ActivationCode, "PieProject");
        }


        private string EncryptActivationCode(string ActivationCode)
        {
            return EncryptString(ActivationCode, "PieProject");
        }

        public static string DecryptString(string InputText, string Password)
        {
            System.Security.Cryptography.RijndaelManaged rijndaelmanaged1 = new System.Security.Cryptography.RijndaelManaged();
            byte[] array1 = Convert.FromBase64String(InputText);
            byte[] array2 = System.Text.Encoding.ASCII.GetBytes(Password.Length.ToString());
            System.Security.Cryptography.PasswordDeriveBytes passwordderivebytes1 = new System.Security.Cryptography.PasswordDeriveBytes(Password, array2);
            System.Security.Cryptography.ICryptoTransform icryptotransform1 = rijndaelmanaged1.CreateDecryptor(passwordderivebytes1.GetBytes(32), passwordderivebytes1.GetBytes(16));
            System.IO.MemoryStream memorystream1 = new System.IO.MemoryStream(array1);
            System.Security.Cryptography.CryptoStream cryptostream1 = new System.Security.Cryptography.CryptoStream(memorystream1, icryptotransform1, System.Security.Cryptography.CryptoStreamMode.Read);
            byte[] array3 = new byte[array1.Length - 1];
            int num1 = cryptostream1.Read(array3, 0, array3.Length);
            memorystream1.Close();
            cryptostream1.Close();
            return System.Text.Encoding.Unicode.GetString(array3, 0, num1);
        }



        public static string EncryptString(string InputText, string Password)
        {

            System.Security.Cryptography.RijndaelManaged rijndaelmanaged1 = new System.Security.Cryptography.RijndaelManaged();
            byte[] array1 = System.Text.Encoding.Unicode.GetBytes(InputText);
            byte[] array2 = System.Text.Encoding.ASCII.GetBytes(Password.Length.ToString());
            System.Security.Cryptography.PasswordDeriveBytes passwordderivebytes1 = new System.Security.Cryptography.PasswordDeriveBytes(Password, array2);
            System.Security.Cryptography.ICryptoTransform icryptotransform1 = rijndaelmanaged1.CreateEncryptor(passwordderivebytes1.GetBytes(32), passwordderivebytes1.GetBytes(16));
            System.IO.MemoryStream memorystream1 = new System.IO.MemoryStream();
            System.Security.Cryptography.CryptoStream cryptostream1 = new System.Security.Cryptography.CryptoStream(memorystream1, icryptotransform1, System.Security.Cryptography.CryptoStreamMode.Write);
            cryptostream1.Write(array1, 0, array1.Length);
            cryptostream1.FlushFinalBlock();
            byte[] array3 = memorystream1.ToArray();
            memorystream1.Close();
            cryptostream1.Close();
            return Convert.ToBase64String(array3);

        }


        public static Int64 GetTick(DateTime dtStart)
        {
            return (DateTime.Now.Ticks - dtStart.Ticks);
        }

        public static string GetHDDId(string drive)
        {
            System.Management.ManagementObject managementobject1 = new System.Management.ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
            managementobject1.Get();
                    
            return managementobject1["VolumeSerialNumber"].ToString();
        }

        private void GenerateRequestCode_button_Click(object sender, EventArgs e)
        {
           RequestCode_textBox.Text =  CreateRequestCode();
        }

        private void GenerateActivationCode_button_Click(object sender, EventArgs e)
        {
            if (RequestCode_textBox.Text != string.Empty)
            {
                ActivationCode_textBox.Text = CreateActivationCode(RequestCode_textBox.Text);
            }
            else
            {
                MessageBox.Show("Empty Request Code ! Please enter Request Code and try again generate activation code !", "Empty Request Code !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyActivationCode_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ActivationCode_textBox.Text);
        }

       
    }

  

}
