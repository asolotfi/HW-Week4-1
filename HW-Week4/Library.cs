

namespace HW_Week4
{
    public class Library
    {
        //این idبه عنوان شمارنده عمل میکنه    
        private static int lastId = 0;//این متغیر متعلق به خود کلاس است، نه هر شیء از کلاس
        private Book[] books = new Book[2];
        private int count = 0;

        public void Add(Book book)
        {
            if (count == books.Length)//با این روش میتوان تعداد اعضا آرایه را نا محدود کرد
            {
                Array.Resize(ref books, books.Length * 2);   // ظرفیت دو برابر می‌شه
            }

            book.Id = ++lastId;
            books[count] = book;
            count++;
        }

        public void FindBooksByAuthor(string author)
        {
            foreach (Book book in books)
            {
                if(book.Author==author)
                {
                    Console.WriteLine($"{book.Title}");
                }
                //elseضروری نیست؛ چون اگر شرط برقرار نباشد، foreach خودش می‌رود سراغ کتاب بعدی
                //{
                //    continue;
                //}
            }
        }
        //public void showBook()
        //{
        //    foreach (Book book in books)
        //    {
        //        if (book == null)
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{book.Id} - {book.Title} - {book.Author} - {book.Pages} - {book.Price}");
        //        }
        //    }
        //}
        public void ShowAll()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{books[i].Id} - {books[i].Title} - {books[i].Author} - {books[i].Pages} - {books[i].Price}");
            }
        }
    }
}
