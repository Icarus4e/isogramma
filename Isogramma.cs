using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
            {
                if (char.ToLower(word[i]) == char.ToLower(word[j]))
                {
                    return false;
                }
            }
        }

        return true;
    }
}