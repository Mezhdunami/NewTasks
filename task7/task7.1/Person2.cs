namespace task7
{
    public class Person2 : PersonAbstract
    {
        public override string Name { get; set; }

        public override void SaysHi()
        {
            Console.WriteLine($"{Name} Says Hi!");
        }

        public  void SetName(string name)
        {
            Name = name;
        }

     
        
        public void ShowPersonDetails()
        {
            Console.WriteLine($"Person name is: {Name}\n{Name}'s age is : {Age}");
        }

    }
}
