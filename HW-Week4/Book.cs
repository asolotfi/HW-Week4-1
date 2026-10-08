

namespace HW_Week4
{
    public class Book
    {
        //این مورد id است.
        public int Id { get; internal set; }//باید فقط توی برنامه بتونبم مقدار دهی کنیم
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public double Price { get; private set; }//کپسوله سازی

        public Book(string title, string author, int pages, double price)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Price = price;
        }
        public void IncreasePrice()
        {
            Price += 100000;
        }

    }
}

