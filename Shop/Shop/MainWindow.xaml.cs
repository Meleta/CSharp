using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;

namespace Shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Root> Catalog { get; set; }

        public MainWindow()
        {
            Catalog = new ObservableCollection<Root>();
            InitializeComponent();
            ProductsList.Run();

            var level1Books = new Category { Id = 0, CategoryName = "Book" };

            var level2Es = new Category { Id = 2, CategoryName = "Esoteric" };
            level2Es.AddChild(new Category { Id = 7, CategoryName = "Bible" });
            level2Es.AddChild(new Category { Id = 8, CategoryName = "How deep the rabbit hole goes" });
            level1Books.AddChild(level2Es);

            var level2Cook = new Category { Id = 3, CategoryName = "Cookery" };
            level2Cook.AddChild(new Category { Id = 9, CategoryName = "Meat for Food" });
            level1Books.AddChild(level2Cook);

            var level2Pr = new Category { Id = 4, CategoryName = "Programming" };
            level2Pr.AddChild(new Category { Id = 10, CategoryName = "Hello, World!" });
            level1Books.AddChild(level2Pr);

            var level1Discs = new Category { Id = 1, CategoryName = "Disc" };

            var level2Dvd = new Category { Id = 5, CategoryName = "DVD" };
            level2Dvd.AddChild(new Category { Id = 11, CategoryName = "Aloha" });
            level1Discs.AddChild(level2Dvd);

            var level2Cd = new Category { Id = 6, CategoryName = "CD" };
            level2Cd.AddChild(new Category { Id = 12, CategoryName = "LaLaLa" });
            level1Discs.AddChild(level2Cd);

            Catalog.Add(level1Books);
            Catalog.Add(level1Discs);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
                var viewItem = (Category)Tree.SelectedItem;

                var productToShow = ProductsList.Listproducts.Find(x => x.Name == viewItem.CategoryName);

                if (productToShow != null)
                {
                    ListView.Items.Clear();
                    ListView.Items.Add("Name: " + productToShow.Name);
                    ListView.Items.Add("Price: " + productToShow.Price);
                    ListView.Items.Add("Barcode: " + productToShow.Barcode);

                    var esProductToShow = productToShow as Esoteric;
                    var cookProductToShow = productToShow as Cookery;
                    var prProductToShow = productToShow as Programming;
                    var discProductToShow = productToShow as Disc;
 
                    if (esProductToShow != null)
                    {
                        ListView.Items.Add("Pages: " + esProductToShow.PagesAmount);
                        ListView.Items.Add("Age: " + esProductToShow.Age + "+");
                    }

                    if (cookProductToShow != null)
                    {
                        ListView.Items.Add("Pages: " + cookProductToShow.PagesAmount);
                        ListView.Items.Add("Main ingredient: " + cookProductToShow.Ingredient);
                    }

                    if (prProductToShow != null)
                    {
                        ListView.Items.Add("Pages: " + prProductToShow.PagesAmount);
                        ListView.Items.Add("Programming language: " + prProductToShow.Language);
                    }

                    if (discProductToShow != null)
                    {
                        ListView.Items.Add("Content: " + discProductToShow.content);
                    }
                }
                else
                {
                    ListView.Items.Clear();
                    ListView.Items.Add("Folder Name: " + viewItem.CategoryName);
                }
        }

    }
}
