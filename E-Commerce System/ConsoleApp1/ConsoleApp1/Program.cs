using ConsoleApp1;
using ConsoleApp1.models;
using Microsoft.EntityFrameworkCore;

class Program
{

    static ECommerceContext context = new ECommerceContext();

    // --- منطقة الدوال ---

    //1
    static void RegisterUser()
    {
        Console.Write("Enter Username: "); 
        string name = Console.ReadLine();

        Console.Write("Enter Email: "); 
        string email = Console.ReadLine();

        var u = new User
        {
            Username = name,
            Email = email,
            PasswordHash = "111",
            FullName = "ahlam",
            RegistrationDate = DateTime.Now,
            IsActive = true
        };
        context.Users.Add(u);
        context.SaveChanges(); // INSERT INTO Users
        Console.WriteLine($"User registered with ID: {u.UserId}");
    }

    //2
    static void AddProductToCategory()
    {
        Console.WriteLine("\n***************** Available Categories *************");
        context.Categorys.ToList().ForEach(c =>
        Console.WriteLine($"ID: {c.CategoryId} |" +
                          $" Name: {c.CategoryName}"));

        Console.Write("Enter Category ID: ");
        int catId = int.Parse(Console.ReadLine());

        Console.Write("Enter Product Name: "); 
        string? pName = Console.ReadLine();

        Console.Write("Enter Price: "); 
        decimal price = decimal.Parse(Console.ReadLine());

        context.Products.Add(new Product
        {
            ProductName = pName,
            Price = price,
            CategoryId = catId,
            CreatedAt = DateTime.Now,
            IsAvailable = true
        });

        context.SaveChanges();
        Console.WriteLine("Product added successfully!");
    }

    //3
    static void PlaceOrder()
    {
        Console.WriteLine("\n***************** Available Products *************");

        context.Products.Where(p => p.IsAvailable).ToList().ForEach(p =>
            Console.WriteLine($"ID:    {p.ProductId}   |" +
                              $" Name: {p.ProductName} | " +
                              $"Price: {p.Price}       | " +
                              $"Stock: {p.StockQuantity}"));


        Console.Write("\nEnter User ID: "); 
        int uId = int.Parse(Console.ReadLine());

        var order = new Order { UserId = uId,
                                OrderDate = DateTime.Now, 
                                Status = "pending",
                                TotalAmount = 0 };


        context.Orders.Add(order);
        context.SaveChanges();

        decimal runningTotal = 0;
        bool addingItem = true;

        while (addingItem)
        {
            Console.Write("\nEnter Product ID to add: ");
            int pId = int.Parse(Console.ReadLine());

            Console.Write("Enter Quantity: "); 
            int qty = int.Parse(Console.ReadLine());

            var prod = context.Products.Find(pId);

            context.OrderItems.Add(new OrderItem { OrderId = order.OrderId,
                                                   ProductId = pId,
                                                   Quantity = qty,
                                                   UnitPrice = prod.Price });

            runningTotal += (prod.Price * qty);
            prod.StockQuantity -= qty;

            Console.Write("Add another product? (y/n): ");
            addingItem = Console.ReadLine().ToLower() == "y";
        }

        order.TotalAmount = runningTotal;

        context.SaveChanges();

        Console.WriteLine($"Order placed successfully! Total: {runningTotal}");
    }

    //4
    static void WriteReview()
    {
        Console.WriteLine("\n***************** Available Users *************");

        context.Users.ToList().ForEach(u => 
        Console.WriteLine($"ID: {u.UserId} |" +
                          $" Name: {u.Username}"));


        Console.Write("\nEnter User ID: "); 
        int uId = int.Parse(Console.ReadLine());

        Console.Write("Enter Product ID: ");
        int pId = int.Parse(Console.ReadLine());

        Console.Write("Enter Rating (1-5): "); 
        int rating = int.Parse(Console.ReadLine());

        Console.Write("Enter Comment: "); 
        string comment = Console.ReadLine();


        context.Reviews.Add(new Review { UserId = uId,
                                      ProductId = pId,
                                         Rating = rating,
                                        Comment = comment, 
                                     ReviewDate = DateTime.Now });
        context.SaveChanges();
        Console.WriteLine("Review added successfully!");
    }

    //5
    static void UpdateProduct()
    {
        Console.WriteLine("\n**************************** Update Product **********************");

        context.Products.ToList().ForEach(p =>
        Console.WriteLine($"ID: {p.ProductId} | " +
                        $"Name: {p.ProductName} | " +
                       $"Price: {p.Price}"));

        Console.Write("\nEnter Product ID to update: "); 
        int pId = int.Parse(Console.ReadLine());

        var product = context.Products.FirstOrDefault(p => p.ProductId == pId);

        if (product != null)
        {
            Console.Write("Enter New Price: "); 
            product.Price = decimal.Parse(Console.ReadLine());

            Console.Write("Is Available (true/false): ");
            product.IsAvailable = bool.Parse(Console.ReadLine());

            context.SaveChanges(); 
            Console.WriteLine("Product updated successfully.");
        }
    }






    //6
    static void CancelOrder() { }


    //7
    static void DeleteReview() { }


    //8
    static void ViewAllProducts() { }


    //9
    static void FilterProducts() { }


    //10
    static void GetCategoryWithProducts() { }


    //11
    static void ViewOrderHistory() { }



    //12
    static void ProductSummary() { }





    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n ------------------------------- E_Commerce System Menu ----------------");
            Console.WriteLine("\n1. Register User | 2. Add Product | 3. Place Order");
            Console.WriteLine("4. Write Review  | 5. Update Product | 6. Cancel Order");
            Console.WriteLine("7. Delete Review | 8. View All Products | 9. Filter Products");
            Console.WriteLine("10. Category Products | 11. Order History | 12. Product Summary");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter choice:");

            string? choice = Console.ReadLine();
            if (choice == "0") break;
            switch (choice)
            {
                case "1": RegisterUser(); break;
                case "2": AddProductToCategory(); break;
                case "3": PlaceOrder(); break;
                case "4": WriteReview(); break;
                case "5": UpdateProduct(); break;
                case "6": CancelOrder(); break;
                case "7": DeleteReview(); break;
                case "8": ViewAllProducts(); break;
                case "9": FilterProducts(); break;
                case "10": GetCategoryWithProducts(); break;
                case "11": ViewOrderHistory(); break;
                case "12": ProductSummary(); break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }

    }

}














