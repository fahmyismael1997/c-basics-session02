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

            object book = new Book();
            Console.WriteLine(book);

            #endregion



        }
    }
}

