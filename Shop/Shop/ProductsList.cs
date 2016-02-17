using System.Collections.Generic;

namespace Shop
{
    public static class ProductsList
    {
        public static List<Product> Listproducts { get; set; }

        public static void Run()
        {
            var product1 = new Programming();
            product1.Language = "C#";
            product1.PagesAmount = 400;
            product1.Name = "Hello, World!";
            product1.Price = 1000;
            product1.Barcode = "asetserg";

            var product2 = new Cookery();
            product2.Ingredient = "meat";
            product2.PagesAmount = 100;
            product2.Name = "Meat for Food";
            product2.Price = 2000;
            product2.Barcode = "iolikghk";

            var product3 = new Esoteric();
            product3.Age = 6;
            product3.PagesAmount = 500;
            product3.Name = "How deep the rabbit hole goes";
            product3.Price = 3000;
            product3.Barcode = "rdhlozasq";

            var product6 = new Esoteric();
            product6.Age = 18;
            product6.PagesAmount = 1346;
            product6.Name = "Bible";
            product6.Price = 100;
            product6.Barcode = "sdlktvn";

            var product4 = new Disc();
            product4.Kind = "CD";
            product4.content = Disc.Content.Music;
            product4.Name = "LaLaLa";
            product4.Price = 500;
            product4.Barcode = "awergdtrh";

            var product5 = new Disc();
            product5.Kind = "DVD";
            product5.content = Disc.Content.Video;
            product5.Name = "Aloha";
            product5.Price = 500;
            product5.Barcode = "awergdtrh";

            var listproducts = new List<Product>();
            listproducts.Add(product1);
            listproducts.Add(product2);
            listproducts.Add(product3);
            listproducts.Add(product4);
            listproducts.Add(product5);
            listproducts.Add(product6);

            Listproducts = listproducts;
        }
    }
}
