namespace CaesarsCipher;

internal static class Program
{
    public static void Main()
    {
        const string message = "how are you doing today";
        const int offset = 12;

        CaesarsCipher caesarsCipher = new();
        string cipheredMessage = caesarsCipher.Cipher(message, offset);

        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Offset: {offset}");
        Console.WriteLine($"Ciphered message: {cipheredMessage}");
    }
}