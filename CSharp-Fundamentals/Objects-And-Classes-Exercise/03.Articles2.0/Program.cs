namespace _03.Articles2._0
{
    internal class Program
    {
        static void Main()
        {
            int articlesCount = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < articlesCount; i++)
            {
                string[] currArticle = Console.ReadLine().Split(", ");
                string title = currArticle[0];
                string content = currArticle[1];
                string author = currArticle[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            Console.WriteLine(string.Join("\n", articles));
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}