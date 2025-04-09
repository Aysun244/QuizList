using static Quiz.Model.Exception;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Quiz> quizzes = new List<Quiz>();
            int nextQuizId = 1;  // Quiz ID avtomatik artacaq

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menyu:");
                Console.WriteLine("1. Create new quiz");
                Console.WriteLine("2. Solve a quiz");
                Console.WriteLine("3. Show quizzes");
                Console.WriteLine("0. Quit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Quiz adı daxil edin:");
                        string quizName = Console.ReadLine();

                        List<Question> newQuestions = [];
                        Console.WriteLine("Nece sual olacaq");
                        int count = int.Parse(Console.ReadLine());

                       

                        break;

                }
            }
}
