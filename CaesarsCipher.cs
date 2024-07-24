namespace CaesarsCipher;

public class CaesarsCipher
{
    private const char LetterA = 'a';
    private const char LetterZ = 'z';
    private const int AlphabetSize = 26;

    public string Cipher(string message, int offset)
    {
        offset %= AlphabetSize;
        char[] character = message.ToCharArray();
        OffsetBy(character, offset);
        return new string(character);
    }

    private void OffsetBy(char[] character, int offset)
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (character[i] != ' ')
                character[i] = OffsetChar(character[i], offset, LetterA, LetterZ);
        }
    }

    private char OffsetChar(char character, int offset, char letterA, char letterZ)
    {
        int givenCharacter = character + offset;
        
        if (givenCharacter < letterA)
            return (char) (givenCharacter + AlphabetSize);

        if (givenCharacter > letterZ)
            return (char)(givenCharacter - AlphabetSize);

        return (char) givenCharacter;
    }
}