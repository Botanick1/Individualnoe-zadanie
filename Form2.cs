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
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_nchb_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Chitatel.parol); // показываем пароль для входа
        }

        private void button_vzyal_Click(object sender, EventArgs e)
        {
            // использует метод VzyatBook()
        }

        private void button_otdal_Click(object sender, EventArgs e)
        {
            // использует метод OtdatBook()
        }

        private void button_poisk_Click(object sender, EventArgs e)
        {
            // использует метод Poisk()
        }
    }
}
