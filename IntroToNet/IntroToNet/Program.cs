//array length input
Console.WriteLine("Please specify how many words you're inputting.");
int arrLength = Convert.ToInt32(Console.ReadLine());
//loop to take words to put into the array
Console.WriteLine("Please input words to put into the array.");

string[] wordsArray = new string[arrLength];

for (int i = 0; i < arrLength; i++)
{
    wordsArray[i] = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Word inputted: " + wordsArray[i]);
}

//count the letters in the array entirely
int letters = 0;

for (int i = 0; i < wordsArray.Length; i++)
{
    letters += wordsArray[i].Length;
    Console.WriteLine(letters);
}

//inputting a character, storing it, and searching for it in the array.
Console.WriteLine("Now, type in a letter to search for in the arrays.");

int counter = 0;
char searchLetter = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Char inputted: " + searchLetter);

for (int wordIndex = 0; wordIndex < wordsArray.Length; wordIndex++)
{//the first layer will iterate through the array and add it into the char array
    char[] charArray = wordsArray[wordIndex].ToCharArray();

    for (int charIndex = 0; charIndex < charArray.Length; charIndex++)
    {//the second layer will iterate through each word's char
        if(charArray[charIndex] == searchLetter)
        {
            counter++;
        }
        Console.WriteLine(charArray[charIndex]);
    }
}

double percentage = (double)counter/letters;

percentage *= 100;

Console.WriteLine($"The letter: {searchLetter} appears {counter} times in the array. This letter makes up more than {percentage}% of the total number of characters");