using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учет_книг
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();               // при входе перекидывает форму добавления книги
           
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            // использует метод DeleteBook()
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            // использует метод  RedactBook()
        }

        private void button_otd_Click(object sender, EventArgs e)
        {
            // использует метод VidachaBook()
        }

        private void button_priem_Click(object sender, EventArgs e)
        {
            // использует метод PriemBook()
        }
    }
}
