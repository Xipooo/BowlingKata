using BowlingKata.Features.CalculateBowlingGame;
using BowlingKata.Services.NotationConverter;
using System;

namespace BowlingKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your bowling scores.");
            var scoresEntered = Console.ReadLine();
            IBowlingGame game = new BowlingGame();

            foreach (var roll in new NotationConverterService().ConvertNotation(scoresEntered))
            {
                game.AddRoll(roll);
            }
            Console.WriteLine("You scored a " + game.GetTotalScore().ToString());
            Console.ReadLine();
        }
    }
}
