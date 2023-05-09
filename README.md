# isogramma
Questo progetto serve a determinare se una parola o una frase inserita dall'utente è un isogramma. Per come lo intendiamo in questo esercizio, un isogramma è una parola o una frase che non ha lettere ripetute. Sono ammessi spazi e segni di punteggiatura ripetuti.

Gli isogrammi possono essere utili come chiavi di cifratura dato che la corrispondenza fra lettere è univoca. Isogrammi di 10 lettere, per esempio PATHFINDER, DUMBWAITER o BLACKHORSE, possono essere utilizzate da venditori di beni il cui prezzo può essere negoziato, come macchine usate, gioielli e antichità. Ad esempio, le cifre decimali possono essere mappate secondo uno schema di corrispondenza con le lettere dell'isogramma.
# esempi di isogramma
- lumberjacks
- background
- downstream
- six-year-old
# Soluzione
Il codice definisce una classe statica chiamata "Isogramma", che ha un solo metodo pubblico statico chiamato "Verifica". Questo metodo prende in input una stringa chiamata "word" e restituisce un valore booleano.

```C#
     public static bool Verifica(string word)
```

Dopo aver dichiarato il metodo, viene utilizzato un loop for per iterare su tutti i caratteri della stringa.

```C#
     for (int i = 0; i < word.Length; i++)
```

All'interno di questo loop viene utilizzato un altro loop for per confrontare il carattere corrente con tutti i caratteri successivi nella stringa.

```C#
     for (int j = i + 1; j < word.Length; j++)
```

All'interno del loop annidato viene utilizzata una struttura condizionale "if" per confrontare i caratteri correnti e verificare se sono uguali.

```C#
     if (char.ToLower(word[i]) == char.ToLower(word[j]))
{
    return false;
}
```

In questo caso, i caratteri sono convertiti in lettere minuscole utilizzando il metodo ToLower() della classe Char, in modo da rendere il confronto case-insensitive. Se due caratteri sono uguali, il metodo restituisce false, indicando che la stringa non è un isogramma.

Se la doppia iterazione dei loop for non ha restituito false, allora il metodo restituisce true, indicando che la stringa passata come parametro è un isogramma.

```C#
     return true;
```

In sintesi, il metodo Verifica controlla se una stringa è un isogramma confrontando ogni carattere con tutti i caratteri successivi nella stringa e restituendo false se viene trovata una ripetizione. Il confronto viene eseguito senza considerare la differenza tra lettere maiuscole e minuscole.

# codice completo

```C#
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
```







