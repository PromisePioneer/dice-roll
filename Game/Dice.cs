namespace Dice_Roll_Game_Fix.Game;

public class Dice
{
    // random class is the dependency of the dice class and the dependencies should rather be given to.
    // this is a dependency of the dice class (because dice needs random to work).
    // we dont want it to assign another value. so we make read only
    private readonly Random _random;
    // represent sides of the dice. 
    private const int SidesCount = 6;
        
    public Dice(Random random)
    {
        _random = random;
    }
    
    public int Roll() => _random.Next(1, SidesCount + 1);
    
    public void Describe() => Console.WriteLine($"This is Dice with {SidesCount} sides");
}