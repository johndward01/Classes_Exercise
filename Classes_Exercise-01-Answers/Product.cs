using System;

namespace Classes_Exercise_01_Answers
{
    // TODO: Create a public Product class
    public class Product
    {
        // TODO: Create a private field _productID of type long
        private long _productID;

        // TODO: Create a private field _productCount of type int
        private int _productCount;
        


        // TODO: Create a public Name property of type string
        public string Name { get; set; }

        // TODO: Create a public Price property of type double
        public double Price { get; set; }

        // TODO: Create a public CategoryID property of type int
        public int CategoryID { get; set; }

        // TODO: Create a public OnSale property of type bool
        public bool OnSale { get; set; }

        // TODO: Create a public StockLevel property of type int
        public int StockLevel { get; set; }



        // TODO: Create a default constructor that increments the _productCount every time a new product is created
        public Product()
        {
            _productCount++;
        }



        // TODO: Create a parameterized constructor that does the same thing and initializes all of the properties
        public Product(string name, double price, int categoryID, bool onSale, int stockLevel)
        {
            _productCount++;
            Name = name;
            Price = price;
            CategoryID = categoryID;
            OnSale = onSale;
            StockLevel = stockLevel;
        }



        // TODO: Create a method that gets the _productID and displays it creatively 
        public static void ShowProductID(Product p)
        {
            Console.WriteLine($"Product ID: {p._productID}");
        }



        // TODO: Create a method that sets the _productID
        public static void AssignProductID(Product p, int id)
        {
            p._productID = id;
        }



        // TODO: Create a method that shows the current product count
        public static void ShowProductCount(Product p)
        {
            Console.WriteLine($"Product Count: {p._productCount}");
        }

        


    }
}
