namespace ListPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int>();
            List<string> names = new List<string>();
            while (ages.Count < 2)
            {
                Console.WriteLine("Please enter your name");
                string name = Console.ReadLine();
                bool isNull = string.IsNullOrEmpty(name);
                if (isNull)
                {
                    continue;
                }
                names.Add(name);
                Console.WriteLine("Please enter your age");
                bool isValid = int.TryParse(Console.ReadLine(), out int age);
                if (isValid)
                {
                    ages.Add(age);
                }
                else
                {
                    Console.WriteLine("That is not valid. Please enter name and age again.");
                    names.Remove(name);
                }
                
            }
            Console.WriteLine("You entered the following ages: ");
            int len = 0;
            while (len < ages.Count)
            {
                Console.WriteLine("Name: " + names[len]);
                Console.WriteLine("Age: " + ages[len]);
                len++;
            }
        }
    }
}
