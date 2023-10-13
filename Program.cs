//Створіть додаток «Список книг до прочитання». Додаток має дозволяти додавати книги до списку,
//видаляти книги зі списку, перевіряти чи є книга у списку, і т.д.
//Використовуйте механізм властивостей, навантаження операторів, індексаторів. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Book book1 = new Book("Тіні забутих предків", "Михайло Коцюбинський");
            Book book2 = new Book("Енеїда", "Іван Котляревський");
            Book book3 = new Book("Кайдашева сім’я", "Іван Нечуй - Левицький");
            Book[] books1 = {book1, book2, book3 };
            ArrayBooks arrayBooks1 = new ArrayBooks("Класика", 3, books1);
            arrayBooks1.Quantity(arrayBooks1, books1);
            Console.WriteLine(); 

            Book book4 = new Book("Холодний Яр", "Юрій Горліс - Горський");
            Book book5 = new Book("Марія", "Улас Самчук");
            Book[] books2 = {book4, book5};
            ArrayBooks arrayBooks2 = new ArrayBooks("Історичні", 2, books2);
            arrayBooks2.Quantity(arrayBooks2, books2);

            arrayBooks1.Comparison(arrayBooks1, arrayBooks2);
            Console.WriteLine();

            Book book6 = new Book("ОУН і УПА", "Вахтанг Кіпіані");
            Book[] books3 = {book4, book5, book6};
            Console.WriteLine($"В список книг \"{arrayBooks2.NameArray}\" додано книгу \"{book6.Name}\" {book6.Author}\n") ;
            arrayBooks2 = arrayBooks2 + book6;
            arrayBooks2.Quantity(arrayBooks2, books3);

            arrayBooks1.Comparison(arrayBooks1, arrayBooks2);
            Console.WriteLine();

            Book[] books4 = { book1, book3};
            Console.WriteLine($"Із списоку книг \"{arrayBooks1.NameArray}\" видалено книгу \"{book2.Name}\" {book2.Author}\n");
            arrayBooks1 = arrayBooks1 - book2;
            arrayBooks1.Quantity(arrayBooks1, books4);

            arrayBooks1.Comparison(arrayBooks1, arrayBooks2);

            ArrayBooks arrayBooks = new ArrayBooks("Новий", 0, null);
            
            Console.WriteLine($"\nПорівняння списків книг Equals (\"{arrayBooks1.NameArray}\", \"{arrayBooks.NameArray}\"): {Equals(arrayBooks1, arrayBooks)}");
            arrayBooks = arrayBooks1;
            Console.WriteLine($"Порівняння списків книг Equals (\"{arrayBooks1.NameArray}\", \"{arrayBooks.NameArray}\"): {Equals(arrayBooks1, arrayBooks)}");

            Console.ReadLine();
        }
    }
}
