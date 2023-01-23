using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Учет_книг
{
    public partial class Form1 : Form

    {
        List <Chitatel> ListChit = new List<Chitatel> ();
        public Form1()
        {
            InitializeComponent();
        }
        Chitatel chit;
       
        private void button_registr_Click(object sender, EventArgs e)
        {
            

            if (textBox_lastname.Text != ""         // если все поля не пустые то создается пользователь
                && textBox_firstname.Text != ""
                && textBox_middlename.Text != ""
                && textBox_numberfhone.Text != "")
            {
                 chit = new Chitatel(textBox_lastname.Text,
                    textBox_firstname.Text,
                    textBox_middlename.Text,
                    Convert.ToUInt64(textBox_numberfhone.Text),
                    dateTime_datebirth);
                ListChit.Add(chit);

                MessageBox.Show(chit.GetParol().ToString()); // показываем пароль для входа

                string json = JsonConvert.SerializeObject(chit);
                File.WriteAllText("Читатели.json", json);// запись
                

               

                //string path = @"C:\Users\Михаил\source\repos\Учет книг\bin\Debug\Читатели.txt";



                //StreamWriter sw;
                //FileInfo fi = new FileInfo(path);
                //sw = fi.AppendText();
                //foreach (Chitatel lists in ListChit)
                //{
                //    sw.WriteLine(lists.lastname);
                //    sw.WriteLine(lists.firstname);
                //    sw.WriteLine(lists.middlename);    //запись в текстовый файл
                //    sw.WriteLine(lists.numberfhone);
                //    sw.WriteLine(lists.datebirth);
                //    sw.WriteLine(Chitatel.parol);
                //}
                //sw.Flush();



            }

            else
            {
                MessageBox.Show("Не все поля были заполнены");
            }
           

        }

        private void textBox_numberfhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number)) // ставим условие только на цифры на номер телефона
            {
                e.Handled = true;
            }
        }
         
        private void button_vhod_Click(object sender, EventArgs e)
        {
             if (textBox_vhod.Text == "admin999")
            {
                Form3 frm3 = new Form3();
                frm3.Show();               // при входе перекидывает форму библиотекаря
                this.Hide();
            }
            string json = JsonConvert.SerializeObject(chit);
            json = File.ReadAllText("Читатели.json");   // чтение
            chit = JsonConvert.DeserializeObject<Chitatel>(json);

            if(textBox_vhod.Text == Convert.ToString(json[5]))
            {
                Form2 frm2 = new Form2();
                      frm2.Show();               // при входе перекидывает форму библиотекаря
                      this.Hide();
            }

            //foreach (string line in File.ReadLines("Читатели.txt"))
            //{
            //    if (Convert.ToString(line.Contains(Chitatel.parol))  == textBox_vhod.Text) // ищет строку где указан пароль
            //    {
            //        Form2 frm2 = new Form2();
            //        frm2.Show();               // при входе перекидывает форму библиотекаря
            //        this.Hide();
            //    }
            //}
















        }
    }
}
