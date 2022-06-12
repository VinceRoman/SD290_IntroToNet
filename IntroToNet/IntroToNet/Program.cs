
int getNumberInput()//array length input
{
    Console.WriteLine("Please specify how many words you're inputting.");
    return Convert.ToInt32(Console.ReadLine());
}

string[] populateWordArray(int length)
{
    string[] wordsArray = new string[length];

    for (int i = 0; i < length; i++)//loop to take words to put into the array
    {
        wordsArray[i] = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Word inputted: " + wordsArray[i]);
    }

    return wordsArray;
}

char getCharacterInput()//inputting a character, storing it, and searching for it in the array.
{
    Console.WriteLine("Now, type in a letter to search for in the arrays.");
    return Convert.ToChar(Console.ReadLine());
}

int countCharacters(string[] words, char charToCount)//count how many times the searched letter appears in the whole array
{
    int counter = 0;

    for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
    {//the first layer will iterate through the array and add it into the char array
        char[] charArray = words[wordIndex].ToCharArray();

        for (int charIndex = 0; charIndex < charArray.Length; charIndex++)
        {//the second layer will iterate through each word's char
            if (charArray[charIndex] == charToCount)
            {
                counter++;
            }
            Console.WriteLine(charArray[charIndex]);
        }
    }

    return counter;
}

int getCharacterOccurencePercentage(string[] words, char charToCount)
{

    int lettersTotal = words.Length;
    int searchCharAmnt = countCharacters(words, charToCount);

    double percentage = (double)searchCharAmnt / lettersTotal;

    percentage *= 100;

    return Convert.ToInt32(percentage);
}

void printResults(char countedCharacter, int charFrequency, int charPercentage, int totalChars)
{
    Console.WriteLine($"The letter: {countedCharacter} appears {charFrequency} times in the array. This letter makes up more than {charPercentage}% of the total number of characters ({totalChars})");
}

int arrLength = getNumberInput();
string[] wordsArray = populateWordArray(arrLength);
char charToSearch = getCharacterInput();
int percentage = getCharacterOccurencePercentage(wordsArray, charToSearch);

printResults(charToSearch, countCharacters(wordsArray, charToSearch), percentage, wordsArray.Length);



/*
//inputting a character, storing it, and searching for it in the array.
Console.WriteLine("Now, type in a letter to search for in the arrays.");
char searchLetter = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Char inputted: " + searchLetter);
*/