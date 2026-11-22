using System.Text;

namespace C__Basics_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion
            #region question 2
            //string st1 = "Clean Code";
            //string st2 = "Clean Code";
            //Console.WriteLine(object.ReferenceEquals(st1,st2));
            #endregion
            #region question 3
            //StringBuilder st = new StringBuilder();
            //st.Append("Book List");
            //st.Append("_Updated");
            //Console.WriteLine(st);
            #endregion
            #region question 4
            //st.Replace("Book List", "Library");
            //Console.WriteLine(st);
            #endregion
            #region question 5
            //string title = "Clean Code";
            //int pages = 464;
            //string sentence = "Book:" + title + ",Pages:" + pages;
            //Console.WriteLine(sentence);
            #endregion
            #region question 6
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine($"Book:{title},pages:{pages}");
            #endregion
            #region question 7
            //string message = string.Format("Book:{0},pages:{1}",title,pages);
            //Console.WriteLine(message);
            #endregion
            #region question 8
            //int pages = 464;
            //if (pages > 300)
            //    Console.WriteLine("long book");
            //else
            //    Console.WriteLine("short book");
            #endregion
            #region question 9
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //    Console.WriteLine("You can borrow this book");
            #endregion
            #region question 10
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion
            #region question 11
            //int pages = 464;
            //string sizeLabel = pages > 300 ? "long book" : "short book";
            //Console.WriteLine(sizeLabel);
            #endregion
            #region question 12
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++) {
            //    Console.WriteLine($"{i + 1} .{books[i]}");
            //}
            #endregion
            #region question 13
            //int i = 0;
            //while ( i <books.Length)
            //{
            //    Console.WriteLine(books[i]);
            //    i++;
            //}
            #endregion
            #region question 14
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //} while (i<=2);
            #endregion
            #region question 15
            //foreach (string book in books) {
            //    Console.WriteLine(book);
            //}
            #endregion
            #region question 16
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "Refactoring")
            //        break;
            //    Console.WriteLine(books[i]);
            //}
            #endregion
            #region question 17
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "The Pragmatic Programmer")
            //        continue;
            //    Console.WriteLine(books[i]);
            //}
            #endregion
            #region question 18
            PrintFirstBook(books);
            #endregion
        }
        public static void PrintFirstBook(string[]book)
        {
            
            if (book.Length==0)
                return ;
            else
                Console.WriteLine(book[0]);
        }
    }
}
