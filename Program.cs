using System.Linq.Expressions;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Question 1
//a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
//b- Exiba os nomes da segunda e da penúltima fruta no console
//c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
//d- Ordene a coleção de frutas na ordem ascendente
//e- Exiba no console a coleção de nomes de frutas na ordem inversa
string[] basketFruits = ["Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra","Abacate", "Mamão", "Pêssego", "Amora"];

static void ShowArrayElementsString(string[] arrayElements){
    foreach(string element in arrayElements)
    {
        Console.Write($"{element} |");
    }
}
//A
for (int fruit = 0; fruit < basketFruits.Length; fruit++)
{
    Console.WriteLine($"Position:{fruit} | Fruit: {basketFruits[fruit]}");
}

//B
Console.WriteLine($"\n\n{basketFruits[1]} | {basketFruits[8]}");

//C
basketFruits[2] = "Kiwi";
basketFruits[9] = "Caqui";
Console.WriteLine(basketFruits[2], basketFruits[9]);

//D
Array.Sort(basketFruits);
Console.WriteLine("\n\nSorted fruit basket");
ShowArrayElementsString(basketFruits);

//E
string[] reversedBasketFruits = basketFruits;
Array.Reverse(reversedBasketFruits);
Console.WriteLine("\n\nReversed fruit basket");
ShowArrayElementsString(reversedBasketFruits);