//Створіть додаток «Список книг до прочитання». Додаток має дозволяти додавати книги до списку,
//видаляти книги зі списку, перевіряти чи є книга у списку, і т.д.
//Використовуйте механізм властивостей, навантаження операторів, індексаторів. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NET_Homework_5_3
{
    internal class ArrayBooks
    {
        public string NameArray;
        Book [] Arr;
        public int Count { get; set; }
        public ArrayBooks() { }
        public ArrayBooks(int n)
        {
            Arr = new Book[n];
        }
        public ArrayBooks(string s, int n, Book[] books)
        {
            NameArray = s;
            Count = n;
            Arr = new Book[Count];
            for(int i = 0; i < Count; i++)
            {
                Arr[i] = books[i];
            }
        }
        public Book this[int index] 
        {
            get
            {
                if(index<0||index>= Arr.Length) throw new IndexOutOfRangeException();
                return Arr[index];
            }
            set
            {
                if (index < 0 || index >= Arr.Length) throw new IndexOutOfRangeException();
                Arr[index] = value;
            }
        }
        public void Quantity(ArrayBooks Arr, Book[]books) 
        {
                Console.Write($"Список книг \"{Arr.NameArray}\": містить {Arr.Count} книг:\n");
            for(int i=0; i<Count; i++)
            {
                Console.WriteLine($"\"{books.ElementAtOrDefault(i).Name}\" {books.ElementAtOrDefault(i).Author}");
            }
        }
        
        public static ArrayBooks operator +(ArrayBooks Arr, Book book)
        {
            ArrayBooks Arr2 = new ArrayBooks(Arr.Count + 1);
            Arr2.Count = Arr.Count + 1;
            Arr2.NameArray = Arr.NameArray;
            for(int i=0; i < Arr.Count; i++)
            {
                Arr2[i] = Arr[i];
            }
            Arr2[Arr.Count] = book;
            return Arr2;
        }
        public static ArrayBooks operator -(ArrayBooks Arr , Book book)
        {
            int a = 0;
            ArrayBooks Arr2 = new ArrayBooks(Arr.Count - 1);
            Arr2.Count = Arr.Count - 1;
            Arr2.NameArray = Arr.NameArray;
            for (int i = 0; i < Arr2.Count; i++)
            {
                if (Arr[i] != book)
                {
                    Arr2[i] = Arr[a];
                    a++;
                }
                else
                {
                    a++;
                    Arr2[i] = Arr[a];
                }
            }
            return Arr2;
        }
        public static bool operator <(ArrayBooks Arr1, ArrayBooks Arr2)
        {
            return Arr1.Count < Arr2.Count;
        }
        public static bool operator >(ArrayBooks Arr1, ArrayBooks Arr2)
        {
            return Arr1.Count > Arr2.Count;
        }
        public static bool operator ==(ArrayBooks Arr1, ArrayBooks Arr2)
        {
            return Arr1.Count == Arr2.Count;
        }
        public static bool operator !=(ArrayBooks Arr1, ArrayBooks Arr2)
        {
            return Arr1.Count != Arr2.Count;
        }
        public void Comparison(ArrayBooks Arr1, ArrayBooks Arr2)
        {
            if (Arr1.Count != Arr2.Count)
            {
                Console.WriteLine("\nКількість книг в двох списках не рівна:");
                if (Arr1.Count < Arr2.Count)
                {
                    Console.WriteLine($"Кількість книг в списку \"{Arr2.NameArray}\"({Arr2.Count}) більша ніж в списку \"{Arr1.NameArray}\"({Arr1.Count})");
                }
                else if (Arr1.Count > Arr2.Count)
                {
                    Console.WriteLine($"Кількість книг в списку \"{Arr1.NameArray}\"({Arr1.Count}) більша ніж в списку \"{Arr2.NameArray}\"({Arr2.Count})");
                }
            }
            else if (Arr1.Count == Arr2.Count)
            {
                Console.WriteLine("\nКількість книг в двох списках рівна:");
                Console.WriteLine($"Кількість книг в списку \"{Arr1.NameArray}\"({Arr1.Count}) рівна кількості книг в списку \"{Arr2.NameArray}\"({Arr2.Count})");
            }
        }
        public static bool Equals(ArrayBooks Arr1, ArrayBooks Arr2)
        {
            return Arr1 != Arr2;
        }
    }
}
