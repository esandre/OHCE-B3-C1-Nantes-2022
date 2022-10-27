namespace OHCE;

public static class Ohce
{
    public static string Palindrome(string mot) 
        => new (mot.Reverse().ToArray());
}