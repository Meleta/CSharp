using System.Collections.Generic;

namespace Shop
{
    public class Category : Root
    {
        public List<Category> Child { get; set; }

        public Category()
        {
            Child = new List<Category>();
        }

        public void AddChild(Category child)
        {
            Child.Add(child);
        }
    }
}
