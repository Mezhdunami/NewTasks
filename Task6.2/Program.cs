

using Task6._2;
internal class Program
{
    static void Main(string[] args)
    {
        Clients client1 = new Clients("Roger", "Prokowsky", 44, true);
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

        Console.WriteLine($"Is {client1.Name} a VIP? - {client1.VIP}");
        client1.TakeLoan();
        officeWorker1.EmployeeOfTheMonth();
        manager1.EmployeeOfTheMonth();
        officeWorker1.QuitJob();
        manager1.QuitJob();

        manager1.FiresPerson(officeWorker1);

        officeWorker1.Position();
        
       

        



    }
}