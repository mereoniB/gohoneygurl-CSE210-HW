using System;

public class Address {
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string streetAddress, string city, string stateProvince, string country) {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public bool IsInUSA() {
        return country.Equals("USA");
    }

    public string GetAddressString() {
        return $"{streetAddress}\n{city}, {stateProvince} {country}";
    }
}

public class Customer {
    private string name;
    private Address address;

    public Customer(string name, Address address) {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA() {
        return address.IsInUSA();
    }

    public string GetName() {
        return name;
    }

    public Address GetAddress() {
        return address;
    }
}

public class Product {
    private string name;
    private int productId;
    private decimal price;
    private int quantity;

    public Product(string name, int productId, decimal price, int quantity) {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal GetPrice() {
        return price * quantity;
    }

    public int GetQuantity() {
        return quantity;
    }

    public string GetName() {
        return name;
    }

    public int GetProductId() {
        return productId;
    }
}

public class Order {
    private Customer customer;
    private Product[] products;
    private decimal shippingCost;

    public Order(Customer customer, Product[] products) {
        this.customer = customer;
        this.products = products;
        this.shippingCost = customer.IsInUSA() ? 5 : 35;
    }

    public decimal GetTotalCost() {
        decimal total = 0;
        foreach (Product product in products) {
            total += product.GetPrice();
        }
        return total + shippingCost;
    }

    public string GetPackingLabel() {
        string packingLabel = "";
        foreach (Product product in products) {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel() {
        string shippingLabel = $"{customer.GetName()}\n{customer.GetAddress().GetAddressString()}";
        return shippingLabel;
    }
}

public class Program {
    public static void Main() {
        Address johnAddress = new Address("123 Main St", "New York", "NY", "USA");
        Customer john = new Customer("John", johnAddress);

        Address janeAddress = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer jane = new Customer("Jane", janeAddress);

        Product[] johnProducts = {
            new Product("Shirt", 1, 20.00m, 2),
            new Product("Jeans", 2, 35.00m, 1),
            new Product("Socks", 3, 5.00m, 5)
        };
        Order johnOrder = new Order(john, johnProducts);

        Product[] janeProducts = {
            new Product("Dress", 4, 50.00m, 1),
            new Product("Shoes", 5, 75.00m, 1),
            new Product("Necklace", 6, 30.00m, 1)
        };
        
        Order janeOrder = new Order(jane, janeProducts);

        Console.WriteLine($"John's Order Packing Label:\n{johnOrder.GetPackingLabel()}");
        Console.WriteLine($"John's Order Shipping Label:\n{johnOrder.GetShippingLabel()}");
        Console.WriteLine($"John's Order Total Cost: ${johnOrder.GetTotalCost():0.00}");

        Console.WriteLine($"Jane's Order Packing Label:\n{janeOrder.GetPackingLabel()}");
        Console.WriteLine($"Jane's Order Shipping Label:\n{janeOrder.GetShippingLabel()}");
        Console.WriteLine($"Jane's Order Total Cost: ${janeOrder.GetTotalCost():0.00}");
}}

