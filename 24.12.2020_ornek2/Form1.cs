using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24._12._2020_ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedItem == "Antalya")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Kepez");
                comboBox2.Items.Add("Gazipaşa");
                comboBox2.Items.Add("Alanya");
            }


            /*
         
           _                                                    
 | |      | |                                            
 | |_ ___ | | __ _  __ _   _ __   ___   __ _  __ _ _   _ 
 | __/ _ \| |/ _` |/ _` | | '_ \ / _ \ / _` |/ _` | | | |
 | || (_) | | (_| | (_| | | | | | (_) | (_| | (_| | |_| |
  \__\___/|_|\__, |\__,_| |_| |_|\___/ \__, |\__,_|\__, |
              __/ |                     __/ |       __/ |
             |___/                     |___/       |___/ 
        𝐭𝐨𝐥𝐠𝐚𝐧𝐨𝐠𝐚𝐲.𝐜𝐨𝐦 / 𝐓𝐨𝐥𝐠𝐚 N𝐨𝐠𝐚𝐲
         
             */

            else if (comboBox1.SelectedItem == "Isparta")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Senirkent");
                comboBox2.Items.Add("Uluborlu");
                comboBox2.Items.Add("Keçiborlu");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
