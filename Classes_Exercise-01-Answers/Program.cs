using System;

namespace Classes_Exercise_01_Answers
{
    // TODO: Create a public Employee class
    // TODO: Create a public Product class 

    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create a new employee and give all of its properties values
            var employee1 = new Employee("John", 'C', "Doe", "abc123!!@gmail.com", "(999) 999-9999", "Repair Technician", DateTime.Today);


            // TODO: Call all of the methods you created inside of that class
            Employee.SetPassword(employee1, "password");
            Employee.EmployeeReport(employee1);
            Employee.ShowPassword(employee1);

            // TODO: Create a new product and give all of its properties values
            var product1 = new Product()
            {
                Name = "GeForce RTX 3090",
                Price = 1499.00,
                CategoryID = 1,
                OnSale = true,
                StockLevel = 100
            };


            // TODO: Call all of the methods you created inside of that class
            Product.ShowProductCount(product1);
            Product.AssignProductID(product1, 11);
            Product.ShowProductID(product1);
        }
    }
}
