namespace OHCE;

public static class Ohce
{
    public static string Palindrome(string mot)
    {
        var miroir = new string(mot.Reverse().ToArray());
        if(miroir.Equals(mot))
            return "Bonjour" + miroir + "Bien dit" + "Au revoir";
        return "Bonjour" + miroir + "Au revoir";
    }
}