namespace task7
{
    public class Manager : EmployeeAbstract
    {
        public override string Name { get; set; }
        public string Position { get; set; }

        public override void Speaks()
        {
            Console.WriteLine($"{Name} is talking");
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void ShowPersonDetails()
        {
            Console.WriteLine($"Person name is: {Name}\n{Name}'s age is : {Age}\n");
        }

    }
}
