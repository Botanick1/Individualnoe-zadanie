using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Учет_книг
{
    internal class Book
    {  
              // поля

        public string title; // название
        public string autor; // автор
        public string opisanie; // описание
        public int kodizd; // код издания
        public int vidacha; // на руках или нет

        // конструктор
        public Book(string title, string autor, string opisanie, int kodizd)
        {
            this.title = title;
            this.autor = autor;
            this.opisanie = opisanie;
            this.kodizd = kodizd;
            this.vidacha = 1;
           
        }
        //методы
        

        public void DeleteBook()
        {
            // удаляет книгу из списка и из файла
        }

        public void RedactBook()
        {
            // удаляет книгу из файла и заменяет ее другой
        }
        public int VidachaBook()
        {
            return this.vidacha; // если книга есть то 1, если выдали то 0
            this.vidacha = 0;
        }
        public int PriemBook()
        {
            return this.vidacha;
            this.vidacha = 1; // поменяли обратно
        }






    }
}
