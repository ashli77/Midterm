using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double NewPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = NewPrice;
        Console.WriteLine("The Price of" + (ItemName) + (ItemId) + " is updated succesfully to" + (NewPrice));
    }

    // Restock the item
    public void RestockItem(int AdditionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock = +AdditionalQuantity;
        Console.WriteLine((AdditionalQuantity) + " " + (ItemName) + " " + "added to the stock");

    }

    // Sell an item
    public void SellItem(int QuantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.

        if (QuantitySold > QuantityInStock)
        {
            Console.WriteLine("Not enough stock");
        }
        else
        {
            Console.WriteLine((QuantitySold) + " " + " sold and " + " " + (QuantityInStock) + " " + (ItemName) + " is remaining in stock");
        }
    }
    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;


    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity.
        Console.WriteLine("Item Name:" + (ItemName));
        Console.WriteLine("Item ID:" + (ItemId));
        Console.WriteLine("Price: $" + (Price));
        Console.WriteLine("Quantity in Stock:" + (QuantityInStock));
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem laptop = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem smartphone = new InventoryItem("Smartphone", 102, 800.30, 15);

        bool exit = false;
        while (!exit)
        {
            //Choices that we can choose
            Console.WriteLine("||||||||||||||||||||||||");
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. View details of all items");
            Console.WriteLine("2. Sell items");
            Console.WriteLine("3. Restock items");
            Console.WriteLine("4. To check items in stock");
            Console.WriteLine("5. Update the price of an item");
            Console.WriteLine("6. Exit");
            Console.Write("\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("||||||||||||||||||||||||");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nDetails of all items:");
                    Console.WriteLine("||||||||||||||||||||||||");
                    laptop.PrintDetails();
                    Console.WriteLine();
                    smartphone.PrintDetails();
                    Console.WriteLine("||||||||||||||||||||||||");
                    break;
                case 2:
                    Console.WriteLine("\nSelling some items:");
                    Console.WriteLine("||||||||||||||||||||||||");
                    Console.Write("Number of laptops to sell: ");
                    int sellLaptopQuantity = Convert.ToInt32(Console.ReadLine());
                    laptop.SellItem(sellLaptopQuantity);
                    Console.Write("Number of smartphones to sell: ");
                    int sellSmartphoneQuantity = Convert.ToInt32(Console.ReadLine());
                    smartphone.SellItem(sellSmartphoneQuantity);
                    Console.WriteLine("||||||||||||||||||||||||");
                    break;
                case 3:
                    Console.WriteLine("\nRestocking an item:");
                    Console.WriteLine("||||||||||||||||||||||||");
                    Console.Write("Enter the restock quantity for Laptop: ");
                    int restockLaptopQuantity = Convert.ToInt32(Console.ReadLine());
                    laptop.RestockItem(restockLaptopQuantity);
                    Console.Write("Enter the restock quantity for Smartphone: ");
                    int restockSmartphoneQuantity = Convert.ToInt32(Console.ReadLine());
                    smartphone.RestockItem(restockSmartphoneQuantity);
                    Console.WriteLine("||||||||||||||||||||||||");
                    break;
                case 4:
                    Console.WriteLine("\nChecking if an item is in stock:");
                    Console.WriteLine("||||||||||||||||||||||||");
                    Console.WriteLine("Is Laptop in stock?" + (laptop.IsInStock()));
                    Console.WriteLine("Is Smartphone in stock?" + (smartphone.IsInStock()));
                    Console.WriteLine("||||||||||||||||||||||||");
                    break;
                case 5:
                    Console.WriteLine("\nUpdating item price:");
                    Console.WriteLine("||||||||||||||||||||||||");
                    Console.WriteLine("Enter the new price for Laptop: ");
                    double newLaptopPrice = Convert.ToDouble(Console.ReadLine());
                    laptop.UpdatePrice(newLaptopPrice);
                    Console.WriteLine("Enter the new price for Smartphone: ");
                    double newSmartphonePrice = Convert.ToDouble(Console.ReadLine());
                    smartphone.UpdatePrice(newSmartphonePrice);
                    Console.WriteLine("||||||||||||||||||||||||");
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;

            }

            // TODO: Implement logic to interact with these objects.
            // Example tasks:
            // 1. Print details of all items.
            // 2. Sell some items and then print the updated details.
            // 3. Restock an item and print the updated details.
            // 4. Check if an item is in stock and print a message accordingly.


        }
    }
}
