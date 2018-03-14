using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fromApptoWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string street = txt_street.Text;
            string city = txt_city.Text;
            string state = txt_state.Text;
            string zip = txt_zip.Text;
            try
            {
                StringBuilder mapadress = new StringBuilder();
                mapadress.Append("https://maps.google.com/maps?q=");

                if (street != string.Empty)
                {
                    mapadress.Append(street + ",+");
                }
                if (city != string.Empty)
                {
                    mapadress.Append(city + ",+");
                }
                if (state != string.Empty)
                {
                    mapadress.Append(state + ",+");
                }
                if (zip != string.Empty)
                {
                    mapadress.Append(zip + ",+");
                }

                googleMapsBrowser.Navigate(mapadress.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
