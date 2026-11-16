using System.Drawing;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace firstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book() { title = "programing", pages = 15 };
            // Task One
            Console.WriteLine("------------------First Task-----------------");
            object bookObj = book1;
            Console.WriteLine(bookObj);
            // Task Two
            Console.WriteLine("------------------Second Task-----------------");
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book1.Equals(book1));
            Console.WriteLine(book1.GetHashCode());
            Console.WriteLine(book1.GetType());
            // Task Three
            Console.WriteLine("------------------Third Task-----------------");
            int pages = 464; // not "464"
            Console.WriteLine("cannot put text into int variable");
            // Task Four
            Console.WriteLine("------------------Forth Task-----------------");

            try
            {
                int x = 10;
                int y = 0;

                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException ex) {
                Console.WriteLine($"msg : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            // Task Five
            Console.WriteLine("------------------Task Five-----------------");
            int NumOfPage = 300;
            double NumOfPages = Convert.ToDouble(NumOfPage);
            Console.WriteLine(NumOfPages.GetType());

            Console.WriteLine(NumOfPages);
            // Task six
            Console.WriteLine("------------------Task Six-----------------");
            double price = 49.99;
            int priceValue = (int)price ;
            Console.WriteLine(priceValue.GetType());

            Console.WriteLine(priceValue);
            // Task seven
            Console.WriteLine("------------------Task Seven-----------------");
            string PagesText = "464";
            int pagesNum = Convert.ToInt32(PagesText);
            Console.WriteLine(pagesNum.GetType());

            Console.WriteLine(pagesNum);
            // Task eight
            Console.WriteLine("------------------Task Eight-----------------");
            string yearText = "2023";
            int YearNum = int.Parse(yearText);

            Console.WriteLine(YearNum);


            string badText = "abc";
            bool badTextNum = int.TryParse(badText, out int res);

            if (badTextNum == false )
            {
                Console.WriteLine("Invalid number");
            }
            // Task nine
            Console.WriteLine("------------------Task Nine-----------------");
            int pages2 = 464;
            string pagesConverted = Convert.ToString(pages2);
            Console.WriteLine(pagesConverted);
            Console.WriteLine(pagesConverted.GetType());
            // Task Ten
            Console.WriteLine("------------------Task Ten-----------------");
            int copies = 100;
            object obj = copies;
            int newCopies = (int)obj;

            Console.WriteLine(obj);
            Console.WriteLine(newCopies);
            // Task 11
            Console.WriteLine("------------------Task 11-----------------");
            int? year = null;
            Console.WriteLine(year ?? 0);

            year = 2023;
            Console.WriteLine(year ?? 0);
            // Task 12
            Console.WriteLine("------------------Task 12-----------------");
            string? reviewer = null;
            if (reviewer == null)
            {
                Console.WriteLine("No reviewer");
            }
            // Task 13
            Console.WriteLine("------------------Task 13-----------------");
            Book? book2 = null;
            Console.WriteLine(book2?.title ?? "title ==> null");

            //Task 14
            Console.WriteLine(book2?.title ?? "Untitled");
            if (book2?.title == null) {
                book2 = new Book();
                book2?.title ??= "untitled";
            }
            Console.WriteLine(book2.title);
            //Task 15
            Console.WriteLine("------------------Task 15-----------------");
            //Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable string confirmedName using the ! operator.
            string? name = "Ahmed";
            string confirmedName = name!;

            Console.WriteLine(confirmedName);



        }
    }
}
