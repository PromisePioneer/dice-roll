namespace Dice_Roll_Game_Fix.UserCommunication;

public static class ConsoleReader
{
    public static int ReadInteger(string messages)
    {
        int result;
        do
        {
            Console.WriteLine(messages);
        } while (!int.TryParse(Console.ReadLine(), out result));
    
        return result;
    }
}