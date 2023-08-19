using System;
using System.Collections.Concurrent;

class Product{
    public string Name {get;set;}
    public double Price {get;set;}

    public Product(string name, double price){
        Name = name;
        Price = price;
    }
}

class ShoppingCart{
    List<Product> items;

    public ShoppingCart(){
        items = new List<Product>();
    }

    public void AddItem(Product product){
        items.Add(product);
    }

    public void ViewCart(){
        Console.WriteLine("Shopping Cart Contents:");
        foreach (Product item in items){
            Console.WriteLine(item.Name + " - $"+ item.Price);
        }
    }

    public double CalculateTotal(){
        double total = 0;
        foreach (Product item in items){
                total += item.Price;
        }
        return total;
    }

    static void Main(string[] args){
        Product item1 = new Product("Item 1",20.00);
        Product item2 = new Product("Item 2",30.00);

        ShoppingCart cart = new ShoppingCart();
        cart.AddItem(item1);
        cart.AddItem(item2);

        cart.ViewCart();
        Console.WriteLine("Total $" + cart.CalculateTotal());
    }
}