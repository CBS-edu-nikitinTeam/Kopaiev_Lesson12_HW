namespace Task_003
{
    class Book
    {
        Author author;
        Title title;
        Content content;

        void CreateBookElement()
        {
            this.author = new Author();
            this.title = new Title();
            this.content = new Content();
        }

        public Book(string author, string title, string content)
        {
            CreateBookElement();
            this.author.AuthorProperty = author; // Слово Property можно не писать.
                                                 // И так понятно, что это свойство.
            this.title.TitleProperty = title;
            this.content.ContentProperty = content;
        }

        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }

    }
}
