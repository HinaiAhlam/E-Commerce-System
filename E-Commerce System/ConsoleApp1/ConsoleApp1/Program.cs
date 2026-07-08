<<<<<<< HEAD
using ConsoleApp1;
=======
﻿using ConsoleApp1;
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
using ConsoleApp1.models;
using Microsoft.EntityFrameworkCore;

class Program
{

    static ECommerceContext context = new ECommerceContext();

    // --- منطقة الدوال ---

    //1
    static void RegisterUser()
    {
<<<<<<< HEAD
        Console.WriteLine("\n--- User Registration ---");

        //Create a new User object from user inputs
        Console.Write("Enter Username: ");
        string name = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        //Set registrationDate to DateTime.Now and isActive to true
=======
        Console.Write("Enter Username: "); 
        string name = Console.ReadLine();

        Console.Write("Enter Email: "); 
        string email = Console.ReadLine();

>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
        var u = new User
        {
            Username = name,
            Email = email,
            PasswordHash = "111",
            FullName = "ahlam",
            RegistrationDate = DateTime.Now,
            IsActive = true
        };
<<<<<<< HEAD

        //Call context.Users.Add() then context.SaveChanges()
        context.Users.Add(u);
        context.SaveChanges();

        //Display the assigned userId after saving
=======
        context.Users.Add(u);
        context.SaveChanges(); // INSERT INTO Users
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
        Console.WriteLine($"User registered with ID: {u.UserId}");
    }

    //2
    static void AddProductToCategory()
    {
<<<<<<< HEAD
        Console.WriteLine("\n--- Add New Product ---");


        //Display all categories with context.Categories.ToList()
=======
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
        Console.WriteLine("\n***************** Available Categories *************");
        context.Categorys.ToList().ForEach(c =>
        Console.WriteLine($"ID: {c.CategoryId} |" +
                          $" Name: {c.CategoryName}"));

<<<<<<< HEAD

        //Read category selection and all product details from the user
        Console.Write("Enter Category ID (from list above): ");
        int catId = int.Parse(Console.ReadLine());

        Console.Write("Enter Product Name: ");
        string? pName = Console.ReadLine();

        Console.Write("Enter Price: ");
        decimal price = decimal.Parse(Console.ReadLine());


        //Set createdAt to DateTime.Now and isAvailable to true
        var newProduct = new Product
=======
        Console.Write("Enter Category ID: ");
        int catId = int.Parse(Console.ReadLine());

        Console.Write("Enter Product Name: "); 
        string? pName = Console.ReadLine();

        Console.Write("Enter Price: "); 
        decimal price = decimal.Parse(Console.ReadLine());

        context.Products.Add(new Product
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
        {
            ProductName = pName,
            Price = price,
            CategoryId = catId,
            CreatedAt = DateTime.Now,
            IsAvailable = true
<<<<<<< HEAD
        };

        context.Products.Add(newProduct);
        //Call context.Products.Add() then context.SaveChanges()
=======
        });

>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
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


<<<<<<< HEAD
        Console.Write("\nEnter User ID: ");
        int uId = int.Parse(Console.ReadLine());

        //Create and save the Order record first to obtain the orderId
        var order = new Order
        {
            UserId = uId,
            OrderDate = DateTime.Now,
            Status = "pending",
            TotalAmount = 0
        };
=======
        Console.Write("\nEnter User ID: "); 
        int uId = int.Parse(Console.ReadLine());

        var order = new Order { UserId = uId,
                                OrderDate = DateTime.Now, 
                                Status = "pending",
                                TotalAmount = 0 };
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336


        context.Orders.Add(order);
        context.SaveChanges();

        decimal runningTotal = 0;
        bool addingItem = true;

<<<<<<< HEAD

        //Let the user add multiple products — for each one create an OrderItem record
=======
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
        while (addingItem)
        {
            Console.Write("\nEnter Product ID to add: ");
            int pId = int.Parse(Console.ReadLine());

<<<<<<< HEAD
            Console.Write("Enter Quantity: ");
=======
            Console.Write("Enter Quantity: "); 
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
            int qty = int.Parse(Console.ReadLine());

            var prod = context.Products.Find(pId);

<<<<<<< HEAD
            if (prod != null && prod.StockQuantity >= qty)
            {

                //Set OrderItem.unitPrice from the product's current price at the time of ordering
                var orderItem = new OrderItem
                {
                    OrderId = order.OrderId,
                    ProductId = pId,
                    Quantity = qty,
                    UnitPrice = prod.Price
                };

                context.OrderItems.Add(orderItem);

                //Accumulate totalAmount on the Order, then call SaveChanges() after all items are added
                runningTotal += (prod.Price * qty);
                prod.StockQuantity -= qty;

                Console.WriteLine($"Added {prod.ProductName} to order.");

            }

            else
            {
                Console.WriteLine("Error: Product not found or insufficient stock!");
            }
=======
            context.OrderItems.Add(new OrderItem { OrderId = order.OrderId,
                                                   ProductId = pId,
                                                   Quantity = qty,
                                                   UnitPrice = prod.Price });

            runningTotal += (prod.Price * qty);
            prod.StockQuantity -= qty;
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336

            Console.Write("Add another product? (y/n): ");
            addingItem = Console.ReadLine().ToLower() == "y";
        }
<<<<<<< HEAD
        //Decrement stockQuantity on each product and call SaveChanges()
=======

>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
        order.TotalAmount = runningTotal;

        context.SaveChanges();

        Console.WriteLine($"Order placed successfully! Total: {runningTotal}");
    }

    //4
    static void WriteReview()
    {
<<<<<<< HEAD
        Console.WriteLine("\n***************** Submit a Product Review *************");


        //Display available users and products for selection
        Console.WriteLine("\n*** Available Users ***");
        context.Users.ToList().ForEach(u => Console.WriteLine($"ID: {u.UserId} | Name: {u.Username}"));


        Console.WriteLine("\n*** Available Products ***");
        context.Products.ToList().ForEach(p => Console.WriteLine($"ID: {p.ProductId} | Name: {p.ProductName}"));


        Console.Write("\nEnter User ID: ");
=======
        Console.WriteLine("\n***************** Available Users *************");

        context.Users.ToList().ForEach(u => 
        Console.WriteLine($"ID: {u.UserId} |" +
                          $" Name: {u.Username}"));


        Console.Write("\nEnter User ID: "); 
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
        int uId = int.Parse(Console.ReadLine());

        Console.Write("Enter Product ID: ");
        int pId = int.Parse(Console.ReadLine());

<<<<<<< HEAD
        Console.Write("Enter Rating (1-5): ");
        int rating = int.Parse(Console.ReadLine());

        Console.Write("Enter Comment: ");
        string comment = Console.ReadLine();



        //Create a Review with userId, productId, rating, comment, and reviewDate = DateTime.Now
        var review = new Review
        {
            UserId = uId,
            ProductId = pId,
            Rating = rating,
            Comment = comment,
            ReviewDate = DateTime.Now
        };

        //Call context.Reviews.Add() then context.SaveChanges()
        context.Reviews.Add(review);
        context.SaveChanges();


=======
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
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
        Console.WriteLine("Review added successfully!");
    }

    //5
    static void UpdateProduct()
    {
        Console.WriteLine("\n**************************** Update Product **********************");

<<<<<<< HEAD
        //call product by id 
        Console.Write("\nEnter Product ID to update: ");
        int pId = int.Parse(Console.ReadLine());

        //Fetch the product using context.Products.FirstOrDefault()
=======
        context.Products.ToList().ForEach(p =>
        Console.WriteLine($"ID: {p.ProductId} | " +
                        $"Name: {p.ProductName} | " +
                       $"Price: {p.Price}"));

        Console.Write("\nEnter Product ID to update: "); 
        int pId = int.Parse(Console.ReadLine());

>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
        var product = context.Products.FirstOrDefault(p => p.ProductId == pId);

        if (product != null)
        {
<<<<<<< HEAD
            Console.Write("Enter New Price: ");
            product.Price = decimal.Parse(Console.ReadLine());

            //Update the price and isAvailable fields directly on the tracked entity
            Console.Write("Is Available (true/false): ");
            product.IsAvailable = bool.Parse(Console.ReadLine());

            //Call context.SaveChanges() — EF Core detects the change and sends an UPDATE
            context.SaveChanges();

            //Confirm the update to the manager
            Console.WriteLine("Product updated successfully.");
        }
        else
        {
            Console.WriteLine(" \n Error : not found !");
        }
=======
            Console.Write("Enter New Price: "); 
            product.Price = decimal.Parse(Console.ReadLine());

            Console.Write("Is Available (true/false): ");
            product.IsAvailable = bool.Parse(Console.ReadLine());

            context.SaveChanges(); 
            Console.WriteLine("Product updated successfully.");
        }
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
    }






    //6
<<<<<<< HEAD
    static void CancelOrder()
    {
        //call the order bu id 
        Console.WriteLine("Enter Order ID to cancel :");
        int oId = int.Parse(Console.ReadLine());

        // Fetch the order by ID using FirstOrDefault()
        var order = context.Orders.FirstOrDefault(o => o.OrderId == oId);

        if (order != null && order.Status == "pending ")
        {

            // Load all OrderItems for that order from context.OrderItem
            var items = context.OrderItems.Where(oi => oi.OrderId == oId).ToList();

            foreach (var item in items)
            {

                //For each OrderItem, find the related product and restore its stockQuantity
                var product = context.Products.Find(item.ProductId);

                if (product != null)
                {
                    product.StockQuantity += item.Quantity;

                }
            }

            //Set order.status = "Cancelled" and call SaveChanges()
            order.Status = "cancelled";
            context.SaveChanges();

            Console.WriteLine($"order {oId} has been cancelled and stock has been restored .");
        }
        else
        {
            Console.WriteLine("  order not found or cannot be cancelled (must be 'pending '.   ");
        }

    }


    //7
    static void DeleteReview()
    {
        Console.WriteLine("\n**************************** Delet inappropriate review **********************");

        //find review by id 

        Console.WriteLine(" Enter review id to delet :");
        int revId = int.Parse(Console.ReadLine());

        //Fetch the review using context.Reviews.FirstOrDefault()
        var review = context.Reviews.FirstOrDefault(o => o.ReviewId == revId);


        if (review != null)
        {
            //Call context.Reviews.Remove() on the fetched entity

            context.Reviews.Remove(review);

            //Call context.SaveChanges() to execute the DELETE
            context.SaveChanges();

            //Confirm deletion to the moderator
            Console.WriteLine("\nSuccess: Review with ID " + revId + " has been permanently deleted.");
        }
        else
        {
            Console.WriteLine("\nError: Review not found with the given ID. ");
        }


    }




    //8
    static void ViewAllProducts()
    {
        Console.WriteLine("\n**************************** product catalogu **********************");

        //Use context.Products.ToList() to retrieve all products
        var allproducts = context.Products.ToList();

        if (allproducts.Any())
        {

            //Display each product's details in a formatted list
            foreach (var p in allproducts)
            {
                Console.WriteLine($"ID: {{p.ProductId}} | " +
                    $"Name: {{p.ProductName}} |" +
                    $" Price: ${{p.Price}} | " +
                    $"Stock: {{p.StockQuantity}} | " +
                    $"Available: {{(p.IsAvailable ? \"Yes\" : \"No\")");
            }
        }

        else
        {
            Console.WriteLine("No products found in the database. ");
        }

    }




    //9
    static void FilterProducts()
    {
        Console.WriteLine("\n**************************** Filter Products **********************");


        //Ask the user for a category ID, minimum price, and maximum price
        Console.WriteLine(" Enter Category ID :");
        int catId = int.Parse(Console.ReadLine());


        Console.WriteLine(" Enter minimum price :");
        decimal Minprice = decimal.Parse(Console.ReadLine());

        Console.WriteLine(" Enter maximum price :");
        decimal Maxprice = decimal.Parse(Console.ReadLine());


        //Use context.Products.Where() with multiple conditions: categoryId, price >= min, price <= max
        var FilterProducts = context.Products
            .Where(p => p.CategoryId == catId && p.Price >= Minprice && p.Price <= Maxprice)
            //Chain .OrderBy(p => p.price) before .ToList()
            .OrderBy(p => p.Price)
            .ToList();

        //Display the filtered and sorted results
        Console.WriteLine("\n **** Found " + FilterProducts.Count + "products ****");

        if (FilterProducts.Any())
        {
            foreach (var p in FilterProducts)
            {
                Console.WriteLine("ID:" + p.ProductId + "Name:" + p.ProductName + "Price: $" + p.Price);
            }


        }
        else
        {
            Console.WriteLine("No products found matching your criteria.");
        }



    }


    //10
    static void GetCategoryWithProducts()
    {
        Console.WriteLine("\n**************************** view category with its products  **********************");


        Console.WriteLine("\n Avalible category  :");
        context.Categorys.ToList().ForEach(c => Console.WriteLine("ID :" + c.CategoryId + "Name :" + c.CategoryName));


        Console.WriteLine("\n Enter category ID to view details : ");
        int catID = int.Parse(Console.ReadLine());

        //Use context.Categories.Include(c => c.Products)
        var category = context.Categorys
            .Include(c => c.Products)
            //Chain .FirstOrDefault(c => c.categoryId == id) to get the specific category
            .FirstOrDefault(c => c.CategoryId == catID);


        if (category != null)
        {


            Console.WriteLine("\n__________ Category Details____________  ");


            //Display the category name and description, then list all its products
            Console.WriteLine("Name :" + category.CategoryName);

            Console.WriteLine(" Description :" + category.Description);

            if (category.Products != null && category.Products.Any())
            {

                foreach (var p in category.Products)
                {
                    Console.WriteLine(p.ProductName);
                }
            }
            else
            {
                Console.WriteLine(" No products found in this category .");
            }

        }

        else
        {
            Console.WriteLine(" Category not found ");
        }


    }






    //11
    static void ViewOrderHistory()
    {
        Console.WriteLine("\n**************************** view Order History   **********************");

        //Ask the user for their userId
        Console.WriteLine(" Enter user Id :");
        int userId = int.Parse(Console.ReadLine());
        //Use context.Users.Include(u => u.Orders).ThenInclude(o => o.OrderItems).ThenInclude(i => i.product)
        var user = context.Users
            .Include(u => u.Orders)
            .ThenInclude(o => o.OrderItems)
            .ThenInclude(i => i.Product)
            //Chain .FirstOrDefault(u => u.userId == id)
            .FirstOrDefault(u => u.UserId == userId);


        //Loop through user.Orders and inside each order loop through order.OrderItems
        if (user != null && user.Orders != null && user.Orders.Any())
        {
            Console.WriteLine("\nOrder History for user " + user.Username);
            foreach (var o in user.Orders)
            {
                Console.WriteLine("*******************************");
                Console.WriteLine("Order Date :" + o.OrderDate);
                Console.WriteLine(" status :" + o.Status);
                Console.WriteLine("Total Amount :" + o.TotalAmount);
                Console.WriteLine(" Items ");


                //Display item.product.productName and item.unitPrice from the navigation property — no extra queries
                foreach (var item in o.OrderItems)
                {
                    Console.WriteLine("- Product :" + item.Product.ProductName + " price :" + item.UnitPrice);
                }


            }

        }

        else
        {
            Console.WriteLine("No order history found for this user.");
        }
    }
=======
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
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336



    //12
    static void ProductSummary() { }

<<<<<<< HEAD
    
=======
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336




<<<<<<< HEAD



    //المين
=======
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
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













<<<<<<< HEAD
=======

>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
