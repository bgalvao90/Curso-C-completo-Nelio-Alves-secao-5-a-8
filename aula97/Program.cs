using aula97.Entities;
using aula97.Entities.enums;

Order order = new Order() { Id = 109, Moment = DateTime.Now , Status = OrderStatus.PendingPayment };

Console.WriteLine(order);

string txt = OrderStatus.PendingPayment.ToString();

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(txt);
Console.WriteLine(os);