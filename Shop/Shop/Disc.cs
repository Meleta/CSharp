namespace Shop
{
    public class Disc : Product
    {
        public string Kind { get; set; }

        public Content content { get; set; }

        public enum Content
        {
            Music,

            Video,

            PO
        }
    }
}
