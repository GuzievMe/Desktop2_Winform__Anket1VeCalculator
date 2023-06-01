using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.VisualStyles.VisualStyleElement.Button.RadioButton;

namespace WinFormsHomeApp_2
{
    public partial class ANKET1 : Form
    {
        public ANKET1()
        {
            InitializeComponent();
        }
      List<CrAnket> Creater = new() 
      {
      new(){Name = "Maham"}, new() {Surname = "Guziye"}
      };

        private void ANKET1_Load(object sender, EventArgs e)
        {
            //CrAnket anketNew = new();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrAnket anketNew = new();
            anketNew.Surname  = textBox2.Text;
            anketNew.Name = textBox3.Text;
            anketNew.AtaAdi = textBox4.Text;
            anketNew.Strana  = textBox5.Text;
            anketNew.City = textBox6.Text;
            anketNew.Phone  = textBox7.Text;
            anketNew.Birth  = dateTimePicker1 .ToString();
            if(radioButton1.Checked ) { anketNew.Cinsi = radioButton1.Text; } else anketNew.Cinsi = radioButton2.Text;
            //radioButton1.Checked ? anketNew.Cinsi = radioButton1.Text : anketNew.Cinsi = radioButton2.Text;


            Creater.Add(anketNew);
            JsonSerializerOptions op = new();   op.WriteIndented = true;  
            
            File.WriteAllText("AnkeTa.json", JsonSerializer.Serialize(Creater , op));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using FileStream fs = new("AnkeTa.json", FileMode.Open);
            var Ankets = JsonSerializer.Deserialize<List<CrAnket>>(fs);
            bool haveNt = true;
            foreach(var item in Ankets )
            {
                if (item.Name == textBox1.Text)
                {
                    haveNt = false;
                    textBox3.Text = item.Surname;
                    textBox2.Text = item.Name;
                    textBox4.Text = item.AtaAdi;
                    textBox5.Text = item.Strana;
                    textBox6.Text = item.City;
                    textBox7.Text = item.Phone;
                    
                    //foreach (Control   control in panel3.Controls)
                    //{
                    if (radioButton1.Text == item.Cinsi) { radioButton1.Checked = true; }
                    else radioButton2.Checked = true;


                    //panel3.GetChildAtPoint (,)  = (item.Cinsi);

                    dateTimePicker1.Text = item.Birth;
                    
                }
            }
            if (haveNt) { MessageBox.Show("Qeydiyyatdan kechmeyib", "Warning"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
            textBox2.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
