
using System;

class QuizGame
{
    static void Main()
    {
        // Define an array of questions and answers.
        string[] questions = {
            "What is the capital of France?",
            "Which planet is closest to the Sun?",
            "Who is the author of 'Romeo and Juliet'?"
        };

        string[] answers = {
            "Paris",
            "Mercury",
            "William Shakespeare"
        };

        // Initialize variables for score tracking.
        int score = 0;
        int totalQuestions = questions.Length;

        Console.WriteLine("Welcome to the Quiz Game!");
        Console.WriteLine("You will be presented with " + totalQuestions + " questions.");
        Console.WriteLine("Please type the correct answer and press Enter to continue.\n");

        // Loop through each question.
        for (int i = 0; i < totalQuestions; i++)
        {
            Console.WriteLine("Question " + (i + 1) + ": " + questions[i]);
            string userAnswer = Console.ReadLine();

            // Check the user's answer against the correct answer.
            if (userAnswer.Equals(answers[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect! The correct answer is: " + answers[i] + "\n");
            }
        }

        // Display the final score.
        Console.WriteLine("Quiz completed! Your score: " + score + " out of " + totalQuestions);
    }
}
