using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        List<Salle> lesSalles;

        public Form1()
        {
            InitializeComponent();
            this.lesSalles = new List<Salle>();
            Salle s1 = new Salle(1, "les 8 salopards", 100, 7.50);
            Salle s2 = new Salle(2, "Interstellar", 75, 6);
            Salle s3 = new Salle(3, "Avatar", 150, 8.50);

            this.lesSalles.Add(1);
            this.lesSalles.Add(2);
            this.lesSalles.Add(3);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }


        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(lesSalles.ToString());
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
