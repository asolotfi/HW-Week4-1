using HW_Week4;

using System;
using System.Text;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;
Console.OutputEncoding = Encoding.UTF8;
Library library = new Library();

while (true)
{
    Console.Clear();
    string resultTitle = " کتاب جدید1 نمایش کتاب 2 نمایش کتاب یک نویسنده 3 خروج 4. ";
    Console.SetCursorPosition(45, Console.CursorTop);
    Console.WriteLine(new string(resultTitle.Reverse().ToArray()));
    string inputUser = Console.ReadLine() ?? "";

    if (inputUser == "4")
        break;
    else if (inputUser == "1")
    {
        string title = "موضوع کتاب  را وارد کنید: ";
        Console.SetCursorPosition(45, Console.CursorTop);
        Console.WriteLine(new string(title.Reverse().ToArray()));
        string titleUser = Console.ReadLine() ?? "";


        string author = "نام نویسنده را وارد کنید: ";
        Console.SetCursorPosition(45, Console.CursorTop);
        Console.WriteLine(new string(author.Reverse().ToArray()));
        string authorUser = Console.ReadLine() ?? "";


        string pages = "تعداد صفحات را وارد کنید: ";
        Console.SetCursorPosition(45, Console.CursorTop);
        Console.WriteLine(new string(pages.Reverse().ToArray()));
        int pagesUser = Convert.ToInt32(Console.ReadLine() ?? "");

        string price = "قیمت کتاب  را وارد کنید: ";
        Console.SetCursorPosition(45, Console.CursorTop);
        Console.WriteLine(new string(price.Reverse().ToArray()));
        int priceUser = Convert.ToInt32(Console.ReadLine() ?? "");

        Book book = new Book(titleUser, authorUser, pagesUser, priceUser);
        library.Add(book);

    }
    else if (inputUser == "2")
    {
        //library.showBook();
        library.ShowAll();
        string exitTitle = "  خروج 4. ";
        Console.SetCursorPosition(45, Console.CursorTop);
        Console.WriteLine(new string(exitTitle.Reverse().ToArray()));
        string exitUser = Console.ReadLine() ?? "";
        if (exitUser == "4")
            continue;

    }
    else if (inputUser == "3")
    {
        string author = "نام نویسنده را وارد کنید: ";
        Console.SetCursorPosition(45, Console.CursorTop);
        Console.WriteLine(new string(author.Reverse().ToArray()));
        string authorUser = Console.ReadLine() ?? "";
        library.FindBooksByAuthor(authorUser);
        string exitTitle = "  خروج 4. ";
        Console.SetCursorPosition(45, Console.CursorTop);
        Console.WriteLine(new string(exitTitle.Reverse().ToArray()));
        string exitUser = Console.ReadLine() ?? "";
        if (exitUser == "4")
            continue;
    }
}



