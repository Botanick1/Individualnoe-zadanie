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
    public partial class Form4 : Form
    {
        List<Book> Books = new List<Book>();
        public Form4()
        {
            InitializeComponent();
        }
        Book book;
        private void button_add_Click(object sender, EventArgs e)
        {

            if (textBox_nazv != null &&
                textBox_autor != null &&
                textBox_kodizd != null &&
                textBox_opis != null)
            {
                book = new Book(textBox_nazv.Text, textBox_autor.Text,
                    textBox_opis.Text, Convert.ToInt32(textBox_kodizd.Text));

                Books.Add(book);  
                MessageBox.Show("Книга успешно добавлена");

                string json = JsonConvert.SerializeObject(book);
                File.WriteAllText("Книги.json", json);

                json = File.ReadAllText("Книги.json");
                book = JsonConvert.DeserializeObject<Book>(json);

                


            }
            
        } 




















                //    string path = @"C:\Users\Михаил\source\repos\Учет книг\bin\Debug\Книги.txt";
                //    StreamWriter sw;
                //    FileInfo fi = new FileInfo(path);
                //    sw = fi.AppendText();
                //    foreach (Book lists in Books)
                //    {
                //        sw.WriteLine(lists.title);
                //        sw.WriteLine(lists.autor);
                //        sw.WriteLine(lists.opisanie);    //запись в текстовый файл
                //        sw.WriteLine(lists.kodizd);

                //    }
                //    sw.Flush();

                //}
            
        }
}
