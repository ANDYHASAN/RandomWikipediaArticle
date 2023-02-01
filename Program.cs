using System;
using System.Net;

namespace RandomWikipediaArticle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получить случайную страницу из Википедии.
            string url = "https://ru.wikipedia.org/wiki/Special:Random";

            // Перейти на случайную страницу.
            using (WebClient client = new WebClient())
            {
                string html = client.DownloadString(url);

                // Найти название статьи.
                int startIndex = html.IndexOf("<title>") + "<title>".Length;

                int endIndex = html.IndexOf(" - Википедия</title>");

                string title = html.Substring(startIndex, endIndex - startIndex);

                Console.WriteLine("Случайноя страница: " + title);

                Console.ReadKey();

            }
        }
    }
}