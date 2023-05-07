do
{
    Console.WriteLine("type your word");
    string str = Console.ReadLine();
    char[] strArray = str.ToCharArray();
    Array.Reverse(strArray);
    string reversed = new string(strArray);
    if (str == reversed)
    {
        Console.WriteLine("palindrome");
    }
    else
    {
        Console.WriteLine("not a palindrome");
    }
}while(true);
