using Enumeracao.Entities;
using Enumeracao.Entities.Enums;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendigPayment
        };

            Console.WriteLine(order);

            string txt = OrderStatus.PendigPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);

            Console.WriteLine(txt);


        }
    }
}