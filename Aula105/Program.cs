using System.Globalization;
using Aula105.Entities;
using Aula105.Entities.Enums;

Console.WriteLine("Enter client data:");

Console.Write("Name: ");
string nameClient = Console.ReadLine();

Console.Write("Email: ");
string emailClient = Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthClient = DateTime.Parse(Console.ReadLine());

Client client = new Client(nameClient, emailClient, birthClient);

Console.WriteLine("Enter order data: ");

Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Order order = new Order(DateTime.Now, status, client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter {i} item data:");

    Console.Write("Product name: ");
    string productName = Console.ReadLine();

    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Quantity: ");
    int productqnt = int.Parse(Console.ReadLine());

    Console.WriteLine();

    Product product = new Product(productName, productPrice);
    OrderItem orderItem = new OrderItem(productqnt, productPrice, product);
    

    order.addItem(orderItem);
}

Console.WriteLine("Order Summary");
Console.WriteLine($"Order moment: {order.Moment}");
Console.WriteLine($"Order status: {order.Status}");
Console.WriteLine($"Client: {order.client}");
Console.WriteLine("Order items: ");

foreach (OrderItem item in order.items)
{
    Console.Write($"{item.products.Name}, ${item.products.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, Subtotal: ${item.subTotal().ToString("F2", CultureInfo.InvariantCulture)}");
    Console.WriteLine();
}
Console.WriteLine($"Total price: $ {order.Total().ToString("F2", CultureInfo.InvariantCulture)}");