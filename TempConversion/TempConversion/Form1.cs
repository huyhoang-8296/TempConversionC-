using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_farenheight_Click(object sender, EventArgs e)
        {
            convertFromFarenheight();
        }

        private void convertFromFarenheight()
        {
            float f = 0;

            try
            {
                f = float.Parse(txt_farenheight.Text); // AUTOMATICALLY CONVERT FROM TEXT TO NUMBER => PARSE 
            }
            catch
            {
                MessageBox.Show("Try only numbers!!");
            }


            float c = 5f / 9 * (f - 32); // make it a literal value, not integer anymore

            float k = c - 273;

            txt_celsius.Text = c.ToString();
            txt_kelvin.Text = k.ToString();
        }

        private void btn_celsius_Click_1(object sender, EventArgs e)
        {
            float c = 0;

            try
            {
                c = float.Parse(txt_celsius.Text); // AUTOMATICALLY CONVERT FROM TEXT TO NUMBER => PARSE 
            }
            catch
            {
                MessageBox.Show("Try only numbers!!");
            }

            float f = c * 9f / 5 + 32; // make it a literal value, not integer anymore

            float k = c - 272.15f;

            txt_farenheight.Text = f.ToString();
            txt_kelvin.Text = k.ToString();

        }

        private void btn_kelvin_Click_1(object sender, EventArgs e)
        {
            float k = 0;

            try
            {
                k = float.Parse(txt_kelvin.Text); // AUTOMATICALLY CONVERT FROM TEXT TO NUMBER => PARSE 
            }
            catch
            {
                MessageBox.Show("Try only numbers!!");
            }

            float f = k * 1.8f - 459.67f; // make it a literal value, not integer anymore

            float c = k + 272.15f;

            txt_celsius.Text = c.ToString();
            txt_farenheight.Text = f.ToString();
        }

        private void onTextChange(object sender, EventArgs e)
        {
            convertFromFarenheight();
        }
    }
}
