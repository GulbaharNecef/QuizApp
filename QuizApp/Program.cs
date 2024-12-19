namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List of questions and answers
            List<Question> questions = new List<Question>
            {
                new Question("What is the capital of France?", new List<string> { "1. Paris", "2. London", "3. Berlin", "4. Madrid" }, 1),
                new Question("Which planet is known as the Red Planet?", new List<string> { "1. Earth", "2. Mars", "3. Jupiter", "4. Venus" }, 2),
                new Question("What is the largest ocean on Earth?", new List<string> { "1. Atlantic", "2. Indian", "3. Pacific", "4. Arctic" }, 3),
                new Question("What is 2 + 2?", new List<string> { "1. 3", "2. 4", "3. 5", "4. 6" }, 2),
                new Question("Who wrote 'Romeo and Juliet'?", new List<string> { "1. Charles Dickens", "2. J.K. Rowling", "3. William Shakespeare", "4. Mark Twain" }, 3)
            };

            Console.WriteLine("Welcome to the Quiz App!");
            Console.WriteLine("Answer the questions by entering the number of your choice.\n");

            int score = 0;

            // Loop through each question
            foreach (var question in questions)
            {
                Console.WriteLine(question.Text);
                foreach (var option in question.Options)
                {
                    Console.WriteLine(option);
                }

                Console.Write("Your answer: ");
                if (int.TryParse(Console.ReadLine(), out int answer) && answer == question.CorrectOption)
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer is {question.CorrectOption}.\n");
                }
            }

            // Final score
            Console.WriteLine($"Quiz Over! Your final score is: {score}/{questions.Count}");
            Console.WriteLine("Thank you for playing!");

            Console.ReadKey();
        }
    }
}
