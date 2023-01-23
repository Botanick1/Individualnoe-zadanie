using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Учет_книг
{
    internal class Biblioteca
    {
        // поля

        public string title; //  название книги
        public string autor; // автор книги

        // конструктор
        public Biblioteca(string title, string autor)
        {
            this.title = title;
            this.autor = autor;
        }


        //методы
        public void GetList()
        {
            // возвращает список книг на listBox_spkn
        }
        public void Poisk()
        {
            // ищет книгу 
        }

    }

}
