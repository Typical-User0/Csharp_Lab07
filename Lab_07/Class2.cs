namespace Lab_07
{
    public class CommentAttribute : Attribute
    {
        public string Comment { get; }

        public CommentAttribute(string comment)
        {
            Comment = comment;
        }
    }
}