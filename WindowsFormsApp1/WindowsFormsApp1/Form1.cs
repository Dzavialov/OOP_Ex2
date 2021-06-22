using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            string[] Names = new string[10] { "Олександр", "Андрій", "Анастасія", 
                "Ірина", "Наташа", "Павло", "Роман", "Світлана", "Сергій", "Тетяна" };

            Person[] p = new Person[6];
            p[0] = new Realist(Names[r.Next(0, 9)], r.Next(20, 40));
            p[1] = new Realist(Names[r.Next(0, 9)], r.Next(20, 40));
            p[2] = new Neformal(Names[r.Next(0, 9)], r.Next(20, 40));
            p[3] = new Neformal(Names[r.Next(0, 9)], r.Next(20, 40));
            p[4] = new Formalist(Names[r.Next(0, 9)], r.Next(20, 40));
            p[5] = new Formalist(Names[r.Next(0, 9)], r.Next(20, 40));

            for(int i = 0; i < 6; i++)
            {
                richTextBox1.Text += p[i].Information() + "\n";
            }
            richTextBox1.Text += "\n";

            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    if(i != j)
                    {
                        richTextBox1.Text += p[i].Hello(p[j]) +"\n";
                    }
                }
                richTextBox1.Text += "\n";
            }
            
        }
    }
}
