namespace _9._Palindrome_Number;

class Program
{
    static void Main(string[] args)
    {
        Solution(-121);
    }

    static bool Solution(int x)
    {
        string inputArray = x.ToString();

        int len = inputArray.Length;

        for (int i = 0; i < len / 2; i++)
        {
            if(inputArray[i] != inputArray[^(i + 1)])
            {
                return false;
            }
        }

        return true;
    }
}
