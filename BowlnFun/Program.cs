using System;

namespace HollywoodStarLanes
{
    class Program
    {
        private static ScoreCalculator bowlingScoreCalculator { get; set; }
        static void Main(string[] args)
        {
            bowlingScoreCalculator = new ScoreCalculator();
            Console.WriteLine("Bowling Game!");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Add Frame score!");
                Console.WriteLine("Add first roll!");
                var firstRoll = getValueFromConsole(Console.ReadLine());
                Console.WriteLine("Add second roll!");
                var secondRoll = 0;
                if (firstRoll != 10)
                {
                    secondRoll = getValueFromConsole(Console.ReadLine());
                }
                bowlingScoreCalculator.BowlFrame(new Frame(firstRoll, secondRoll));
                Console.WriteLine($"Your score is {bowlingScoreCalculator.AggregatedScore}");
            }
            Console.WriteLine("Add Frame score!");
            Console.WriteLine("Add first roll!");
            var firstRollOfLast = getValueFromConsole(Console.ReadLine());
            Console.WriteLine("Add second roll!");
            var secondRolOfLast = getValueFromConsole(Console.ReadLine());
            Console.WriteLine("Add third roll if you hit a strike og spare!");
            var thirdRolOfLast = getValueFromConsole(Console.ReadLine());
            bowlingScoreCalculator.BowlFrame(new LastFrame(firstRollOfLast, secondRolOfLast, thirdRolOfLast));
            Console.WriteLine($"Your final score is {bowlingScoreCalculator.AggregatedScore}");
            Console.ReadKey();
        }

        private static int getValueFromConsole(string input)
        {
            if (!Int32.TryParse(input, out int number))
            {
                throw new System.ArgumentException($"Not valid number");
            }

            return number;
        }
    }
}
