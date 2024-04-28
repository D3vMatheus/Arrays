
//Question 1
//a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
//b- Exiba os nomes da segunda e da penúltima fruta no console
//c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
//d- Ordene a coleção de frutas na ordem ascendente
//e- Exiba no console a coleção de nomes de frutas na ordem inversa
using System.Linq.Expressions;
using System.Text.Json.Serialization;

string[] basketFruits = ["Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra","Abacate", "Mamão", "Pêssego", "Amora"];

static void ShowArrayElementsString(string[] arrayElements){
    foreach(string element in arrayElements)
    {
        Console.Write($"{element} |");
    }
}
static void ShowArrayElemenstInt(int[] arrayElements)
{
    foreach (int element in arrayElements)
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

//Question 2
//a-) Solicite via teclado o número de valores do array (deve ser um número inteiro)
//b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
//c-) Solicite ao usuário um valor de um número inteiro a procurar no array
//d-) Exiba se o número informado existe no array de inteiros ou não
//e-) Repita até que o texto ‘fim’ seja inserido via teclado

Console.WriteLine("\n\n\nDigite o tamanho do array");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] intArray = new int[arrayLength];
int userInput = 0;
Random randNum = new Random();

for (int i = 0; i < arrayLength; i++)
{
    intArray[i] = randNum.Next(1, 20);
}

while (true)
{

    Console.WriteLine("Try guess an integer number inside an array : (1-20)");
    userInput = Convert.ToInt32(Console.ReadLine());

    if (intArray.Contains(userInput))
    {
        Console.WriteLine($"\n{userInput} was in array \n End");
        break;
    }
    else
        Console.WriteLine("\nTry again\n");
};
ShowArrayElemenstInt(intArray);

/*3 - Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10
alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a
seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).
*/
Console.WriteLine("\n\n\n");
double[,] grades = new double[2,5];
double sumGrades = 0;

for (int i = 0; i< grades.GetLength(0); i++)
{
    for(int j = 0; j < grades.GetLength(1); j++)
    {
        Console.WriteLine($"Insert student [{i},{j}] grade: ");
        grades[i,j] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine();
}

for (int i = 0; i < grades.GetLength(0); i++)
{
    for (int j = 0; j < grades.GetLength(1); j++)
    {
        sumGrades += grades[i, j];
        Console.Write($"Grades[{i},{j}]: {grades[i, j]} ");
    }
    Console.WriteLine($"Media group {i+1}: {sumGrades/grades.GetLength(1)}");
    sumGrades = 0;
}
