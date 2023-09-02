namespace _9._Palindrome_Number;

class Program
{
    static void Main(string[] args)
    {
        Solution(121);
    }

    static bool Solution(int x)
    {
        int r = 0, c = x;
        while (c > 0)
        {
            r = r * 10 + c % 10;
            c /= 10;
        }
        return r == x;
    }
}
