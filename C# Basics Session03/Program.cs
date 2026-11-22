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
            int pages = 464;
            if (pages > 300)
                Console.WriteLine("long book");
            else
                Console.WriteLine("short book");
            #endregion



        }
    }
}
