using Dice_Roll_Game_Fix.UserCommunication;

namespace Dice_Roll_Game_Fix.Game
{
    class GuessingGame
    {
        // we need to have a dice object that will be rolled from beginning of the game.
        private readonly Dice _dice;
        private const int attempts = 3;
        
        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }
    
        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice rolled. Guess what number it shows in {attempts} tries.");
    
            int triesLeft = attempts;
    
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a Number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
     
                Console.WriteLine("Wrong Number");
                triesLeft--;
            }
    
            return GameResult.Loss;
        }
    
    
        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory ? "You win" : "You lose.";
            Console.WriteLine(message);
        }
    
    }
}
