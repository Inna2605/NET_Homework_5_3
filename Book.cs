//Створіть додаток «Список книг до прочитання». Додаток має дозволяти додавати книги до списку,
//видаляти книги зі списку, перевіряти чи є книга у списку, і т.д.
//Використовуйте механізм властивостей, навантаження операторів, індексаторів. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_5_3
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }
    }   
            
}
