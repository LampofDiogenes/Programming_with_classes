using System;

class Program
{
    static void Main(string[] args)
    {
        Address Location = new Address("1946 Charles Bent", "Blackfoot", "Utah", "USA");
        Customer Charles = new Customer("Charles", Location);

        Product Apple = new Product("Apple", "12357", 2, 1);
        Product Banana = new Product("Banana", "174839", 1, 1);
        Product Orange = new Product("Orange", "847362", 4, 1);
        Product Cucumber = new Product("Cucumber", "23596", 3, 1);


        List<Product> product_list = new List<Product>();
        product_list.Add(Apple);
        product_list.Add(Banana);
        product_list.Add(Orange);
        

        List<Product> product_list2 = new List<Product>();
        product_list2.Add(Orange);
        product_list2.Add(Orange);
        product_list2.Add(Orange);

        List<Order> orderList = new List<Order>();

        Order groceryDelivery = new Order(Charles, product_list);
        orderList.Add(groceryDelivery);

        Order shoppingTrip2 = new Order(Charles, product_list2);
        orderList.Add(shoppingTrip2);

        foreach (Order order in orderList)
        {
            Console.WriteLine();
            Console.WriteLine($"The shipping label is: {order.CreateShippingLabel()}");
            
            List<string> packingLabel = order.CreatePackingLabel();
            Console.WriteLine("The packing label is: ");
            foreach (string name in packingLabel)
            {
                Console.WriteLine(name);
            }
            
            Console.WriteLine($"The Cost before shipping is: {order.CalculateTotal()}");
            Console.WriteLine($"The Cost for shipping is: {order.ShippingCost()}");
            
            Console.WriteLine($"The total price of the package is: {order.TotalCost()}");

        }
    }
}