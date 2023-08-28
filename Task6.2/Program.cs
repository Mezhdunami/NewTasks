

using Task6._2;
internal class Program
{
    static void Main(string[] args)
    {
        Client client1 = new Client("Roger", "Prokowsky", 44, false);
        OfficeWorker officeWorker1 = new OfficeWorker
        {
            Name = "Office Worker - Nick",
            LastName = "Firelane",
            Age = 53
        };
        Manager manager1 = new Manager
        {
            Name = "Manager - Alex",
            LastName = "Maxwell",
            Age = 29
        };

        Console.Write(client1.Name);
        client1.TakeLoan();

       







    }
}