namespace _02.Articles
{
    internal class Program
    {
        static void Main()
        {
            List<string> articleArgs = Console.ReadLine().Split(", ").ToList();
            string title = articleArgs[0];
            string content = articleArgs[1];
            string author = articleArgs[2];
            int commandCount = int.Parse(Console.ReadLine());

            Article article = new Article(title, content, author);

            for (int i = 0; i < commandCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ");
                string command = tokens[0];

                switch (command)
                {
                    case "Edit":
                        string newContent = tokens[1];
                        article.Edit(newContent);
                        break;
                    case "ChangeAuthor":
                        string newAuthor = tokens[1];
                        article.ChangeAuthor(newAuthor);
                        break;
                    case "Rename":
                        string newTitle = tokens[1];
                        article.Rename(newTitle);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
