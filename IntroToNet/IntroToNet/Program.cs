Console.WriteLine(isPalindrome("racecarracecar"));

bool isPalindrome(string inputWord)
{
    string loweredInput = inputWord.ToLower();//easier comparison if everything is lowercase.
    char[] charArray = loweredInput.ToCharArray();
    int reverseIndex = charArray.Length - 1;
    bool isValid = true;

    for(int i = 0; i < charArray.Length; i++)//barrier to prevent things like spaces or symbols
    {
        if(Char.IsLetterOrDigit(charArray[i]) == false)
        {
            Console.WriteLine("You mustn't add spaces or symbols.");
            isValid = false;
        }
    }

    for (int index = 0; index < charArray.Length; index++)
    {
        if (charArray[index] != charArray[reverseIndex])//if one letter is off it will invalidate the whole thing.
        {
            isValid = false;
        }
        reverseIndex--;
    }

    if (isValid)
    {
        
        return true;
    }
    else
    {
        return false;
    }
}

duplicateCharacters("Programmatic Python");

char[] duplicateCharacters (string testString)
{
    char[] charArray = testString.ToCharArray();
    char[] outArray  = new char[charArray.Length];

    //selects a char then compares it to the entire sentence, if there's more than one duplicate, it adds to the new array.
    for (int i = 0; i < charArray.Length; i++)
    {
        char searchItem = charArray[i];
        for(int j = 0; j < charArray.Length; j++)
        {
            if(searchItem == charArray[j] && j != i)//prevent it from being on the same index
            {
                Console.WriteLine(searchItem +" :is equal to: "+ charArray[j]);
                outArray[i] = searchItem;
            }
        }
    }

    foreach(char element in outArray)
    {
        Console.WriteLine(element);
    }

    return outArray;
}