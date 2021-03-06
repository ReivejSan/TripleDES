using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace _3DES_Kriptografi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] encrypted;
        private void button1_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();
            tDes.Key = md5.ComputeHash(utf8.GetBytes(textBox1.Text));
            tDes.Mode = CipherMode.ECB;
            tDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = tDes.CreateEncryptor();
            encrypted = trans.TransformFinalBlock(utf8.GetBytes(textBox2.Text), 0, utf8.GetBytes(textBox2.Text).Length);
            textBox3.Text = BitConverter.ToString(encrypted);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();
            tDes.Key = md5.ComputeHash(utf8.GetBytes(textBox5.Text));
            tDes.Mode = CipherMode.ECB;
            tDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = tDes.CreateDecryptor();
            textBox4.Text = utf8.GetString(trans.TransformFinalBlock(encrypted, 0, encrypted.Length));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
