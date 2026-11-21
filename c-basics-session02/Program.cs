using System.Numerics;
using System.Timers;

namespace c_basics_session02
{
    class Book
    {
        public string Title;
        public int Pages;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            /* 1- Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
             variable of type object.Print it */

            //object book = new Book();
            //Console.WriteLine(book);

            #endregion

            #region Question 2
            /*Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            itself), GetHashCode(), and GetType() on book*/

            //object book=new Book();
            //Console.WriteLine("the results : ");

            //Console.WriteLine($"toString() = {book.ToString()}");

            //Console.WriteLine($"Equals() = { book.Equals(book)}");

            //Console.WriteLine($"GetHashCode() = {book.GetHashCode()}");

            //Console.WriteLine($"GetType() = {book.GetType()}");
            #endregion

            #region Question 3
            /*3-Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
             int pages = "464";*/

            //int pages = 464;//int pages="464" is compile Error 
            #endregion

            #region Question 4
            /*4-Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            zero", and then prints "Done" in a finally block.*/

            //int x = 10, y = 0;
            //try
            //{
            //    Console.WriteLine(x / y);
            //}
            //catch (DivideByZeroException ex)
            //{

            //    Console.WriteLine("Cannot divide by zero");
            //} finally 
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region Question 5
            /* 5-  Declare an int pages = 300; then store it in a double variable without using a cast*/

            int pages = 300;
            double p = pages;

            #endregion

            #region Question 6
            /*Declare a double price = 49.99; then convert it into an int using a cast*/
           
            double price = 49.99;
            int pr= (int)price;
            
             
            #endregion

        }
    }
}

