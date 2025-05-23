namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Depresso";
            int age = 21;
            char gender = 'f';
            bool isSad = true;
            double gPA = 3.7;
            decimal money = 4.99m;


            Console.WriteLine($"Name: {name}, Age: {age}, " +
                              $"Gender: {gender}, IsSad: {isSad}, Money: {money}");
        }
    }
}
