namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to the number guessing game, where you will have a chance to win various prizes!");
            Console.WriteLine($"All you have to do is input a guess of what my favorite number is below, good luck!");
            Console.WriteLine($"What is the upper limit that you would like for the guessing game?");

            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine($"Input your guess, please:");
            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine($"Sorry, your guess is too high! Please try again.");
            }
            else if (guess < number)
            {
                Console.WriteLine($"Sorry, your guess is too low! Please try again.");
            }
            else
            {
                Console.WriteLine($"That is correct, you are the best!");
            }



        }
    }
}
