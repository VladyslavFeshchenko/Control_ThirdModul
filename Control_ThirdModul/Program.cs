using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_ThirdModul
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            List<Book> books = new List<Book>()
            {
                new Book() {Name = "AAAA LINQ", Year = 1972 },
                new Book() {Name = "BBBB LINQ", Year = 1973 },
                new Book() {Name = "CCCC", Year = 2004 },
                new Book() {Name = "DDDD LINQ", Year = 2004},
                new Book() {Name = "EEEE", Year = 1991 }
            };

            List<Book> newBooks = new List<Book>();

            foreach (var item in books.Where(f => f.Year % 4 == 0))
            {
                if (item.Name.Contains("LINQ"))
                {
                    newBooks.Add(item);
                }
            }

            foreach (var item in newBooks)
            {
                Console.WriteLine(item.Name + " : " + item.Year);
            }

            Console.WriteLine();

            //2
            string str = "лaллнкч,поaэфтл,дсюотдь,ифтлт";

            int count = string.Join("", str.Split(',')).Distinct().Count();

            Console.WriteLine(count);
            Console.WriteLine();

            //3
            int[] arrInt = { 10, 25, 34, 28, 32, 16, 88, 96 };

            int[] arr1 = new int[arrInt.Length];
            arr1 = arrInt.OrderBy(f => f / 10).ThenByDescending(f => f % 10).ToArray();

            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //4
            string[] booksArr = { "Author1:BookName1", "Author1:BookName2", "Author2:BookName1", "Author1:BookName3", "Author2:BookName2" , "Author3:BookName1" };
            string[] booksAuthor = new string[booksArr.Length];

            for (int i = 0; i < booksArr.Length; i++)
            {
                booksAuthor[i] = string.Join(" ", booksArr[i].Remove(booksArr[i].IndexOf(':')));
            }

            string[] author = booksAuthor.Distinct().ToArray();

            for (int i = 0; i < author.Length; i++)
            {
                Console.WriteLine(author[i] + "  " + booksAuthor.Count(f=>f.Contains(author[i])));
            }
        }
    }
}
