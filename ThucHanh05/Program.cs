namespace ThucHanh05
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    
    
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }

            public Customer(int id, string name, string phone, string address)
            {
                Id = id;
                Name = name;
                Phone = phone;
                Address = address;
            }
        }

    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<Service> Services { get; set; }

        public Invoice(int id, int customerId)
        {
            Id = id;
            CustomerId = customerId;
            Services = new List<Service>();
        }

        public void AddService(Service service)
        {
            Services.Add(service);
        }

        public decimal TotalAmount()
        {
            decimal total = 0;
            foreach (var service in Services)
            {
                total += service.Price;
            }
            return total;
        }
    }
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Service(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }

}