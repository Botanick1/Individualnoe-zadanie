using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Учет_книг
{
    internal class Chitatel
    {
        // поля

        public string lastname; //фамилия
        public string firstname;  //имя
        public string middlename;  //отчество
        public ulong numberfhone;  // номер телефона
        public DateTimePicker datebirth; // день рождения
        private static int nchb = 1000;    //номер билета начнется с отсчета 1000, для красоты
        public static string parol;   // пароль для входа и одновременно номер чит. билета
        

        //конструктор
        public Chitatel(string lastname, string firstname, string middlename, ulong numberfhone, DateTimePicker datebirth)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.middlename = middlename;
            this.numberfhone = numberfhone;
            this.datebirth = datebirth;
            nchb++;  // +1 к номеру билета 
            parol = this.lastname.ToString() + nchb.ToString(); //создает пароль из фамилии и номера читательского билета
            
        }

        // методы
        List<Biblioteca> Vzyal = new List<Biblioteca>();
        List<Biblioteca> Otdal = new List<Biblioteca>();
       
        public  string GetParol()
        {
            return parol;  // возвращает пароль 
        }
        public void VzyatBook()
        {
            //добавляет обьект book в Vzyal
            // возвращает список на listBox_mspkn
        }
        public void OtdatBook()
        {
            // добавляет книгу в Otdal
            // возвращает список на listBox_mspkn
        }

    }
}
