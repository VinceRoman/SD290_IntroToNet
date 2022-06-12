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
        if (charArray[index] != charArray[reverseIndex])
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