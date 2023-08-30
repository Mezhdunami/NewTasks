namespace task7
{
    public class Program
    {
        //Task1
        static void Main(string[] args)
        {

            Manager Manager = new Manager
            {
                Name = "",
                Age = 0
            };

            Director Director = new Director
            {
                Name = "",
                Age = 0
            };

            Manager.SetName("Anton");
            Manager.SetAge(23);

            Director.SetName("Mark");

            Director.SetPosition("SEO");
                

        }
        //Task1





        ////Task2
        //static void Main(string[] args)
        //{
        //    Car car = new Car
        //    {
        //        Name = "Porche"
        //    };
        //    Car car2 = new Car
        //    {
        //        Name = "Audi"
        //    };
        //    Tractor tractor = new Tractor
        //    {
        //        Name = "Kubota"
        //    };

        //    car.Isfast();
        //    car2.IsSlow();
        //    tractor.IsSlow();

        //}




    }
 
}