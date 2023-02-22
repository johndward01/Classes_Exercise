using System;

namespace Classes_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            // DON'T FORGET TO CHECK THE ANSWERS IN THE OTHER FILES TOO!!!
            
            #region// TODO: Create a public Employee class

            // Inside of the Employee class:
            // TODO: Create a private field _password of type string

            // TODO: Create a public FirstName property of type string
            // TODO: Create a public MiddleInitial property of type char
            // TODO: Create a public LastName property of type string
            // TODO: Create a public EmailAddress property of type string
            // TODO: Create a public PhoneNumber property of type string
            // TODO: Create a public Title property of type string
            // TODO: Create a public DateOfBirth property of type DateTime

            // TODO: Create a parameterized constructor that sets all of the properties correctly
            // Thought experiment: (True or False) We can instantiate this class with a default constructor
            // TODO: false (bc we created a parameterized constructor we overrided the default. So, if we want to be able to use the default we must explicitly type it out)

            // TODO: Create a method that sets the employee's password
            // TODO: Create a method to display the employee's password
            // TODO: Create an EmployeeReport() method that takes in an employee and returns all of the props creatively displayed to the console

            #endregion

            #region// TODO: Create a public Product class 

            // TODO: Create a public Product class

            // TODO: Create a private field _productID of type long
            // TODO: Create a private field _productCount of type int

            // TODO: Create a public Name property of type string
            // TODO: Create a public Price property of type double
            // TODO: Create a public CategoryID property of type int
            // TODO: Create a public OnSale property of type bool
            // TODO: Create a public StockLevel property of type int

            // TODO: Create a default constructor that increments the _productCount every time a new product is created
            // TODO: Create a parameterized constructor that does the same thing and initializes all of the properties

            // TODO: Create a method that gets the _productID and displays it creatively
            // TODO: Create a method that sets the _productID
            // TODO: Create a method that shows the current product count


            #endregion



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
