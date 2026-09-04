

List<string> products= new List<string>();

    Console.WriteLine("PRODUCT INVENTORY SYSTEM - LEVEL4:");
    Console.WriteLine();
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2: View Products");
    Console.WriteLine("3: Search Product");
    Console.WriteLine("4: Delete Product");
    Console.WriteLine("5: Statistics");
    Console.WriteLine("6: Exit");
    Console.WriteLine();
while (true)
{

    Console.Write("Select option: ");
    string choice = Console.ReadLine();


    if (choice == "1")
    {
        Console.Write("\n Enter product:");
        string input = Console.ReadLine();

        if (products.Contains(input))
        {
            Console.WriteLine("WARNING: Product already exists.");
        }
        else
        {
            products.Add(input);
            Console.WriteLine("Product added successfully.");
        }

    }
    else if (choice == "2")

    {
        Console.WriteLine("\n Products:");
        foreach (string product in products)
        {
            Console.WriteLine("-" + product);
        }
    }
    else if (choice == "3")
    {
        Console.WriteLine("\n Search product:");
        string search = Console.ReadLine();

        Console.WriteLine("\n Results:");

        foreach (string product in products)
        {
            if (product.Contains(search))
            {
                Console.WriteLine("-" + product);
            }

        }

    }
    else if (choice == "4")
    {
        Console.WriteLine("\n Delete product:");

        string delete = Console.ReadLine();
        if (products.Remove(delete))
        {
            Console.WriteLine("Product deleted successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

    }
    else if (choice == "5")
    {
        if (products.Count == 0)
        {
            Console.WriteLine("\n No products available.");
        }
        else
        {
            int highest = int.MinValue;
            int lowest = int.MaxValue;
            int total = 0;

            foreach (string product in products)
            {
                string[] parts = product.Split('-');
                int number = Convert.ToInt32(parts[1]);

                total += number;

                if (number > highest)
                {
                    highest = number;
                }
                if (number < lowest)
                {
                    lowest = number;
                }

            }
            int average = total / products.Count;

            Console.WriteLine("\n Statistics:");
            Console.WriteLine("- Total products: " + products.Count);
            Console.WriteLine("- Highest Number:" + highest);
            Console.WriteLine("- Lowest Number:" + lowest);
            Console.WriteLine("- Average Number:" + average);
        }
    }
    else if (choice == "6")

    {
        Console.WriteLine("\nSaving products...");
        Console.WriteLine("Applicatin closed:");
        break;

    }
    else
    {
        Console.WriteLine("\n Invalid option.");

    }

}



             



       


