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

            object book=new Book();
            Console.WriteLine("the results : ");

            Console.WriteLine($"toString() = {book.ToString()}");

            Console.WriteLine($"Equals() = { book.Equals(book)}");

            Console.WriteLine($"GetHashCode() = {book.GetHashCode()}");

            Console.WriteLine($"GetType() = {book.GetType()}");
            #endregion


        }
    }
}

