/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Zadanie 3

Console.WriteLine("Wprowadź liczbę 1 do tablicy");
int liczba = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Wprowadź liczbę 2 do tablicy");
int liczba2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 3 do tablicy");
int liczba3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 4 do tablicy");
int liczba4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 5 do tablicy");
int liczba5 = Convert.ToInt32(Console.ReadLine());


int[] tablica = {liczba , liczba2, liczba3, liczba4, liczba5};
Console.WriteLine("Liczby od pierwszego do ostatniego indeksu to: ");
for (int i = 0;  i < tablica.Length; i++)
{
    Console.WriteLine(tablica[i]);
}

int[] tablica2 = {liczba , liczba2, liczba3, liczba4, liczba5};
Console.WriteLine("Liczby od ostatniego do pierwszego indeksu to: ");
for (int i = 4; i >= 0; i--)
{
    Console.WriteLine(tablica2[i]);
}

int[] tablica3 = {liczba , liczba2, liczba3, liczba4, liczba5};
Console.WriteLine("Liczby o indeksach nieparzystych: ");
for (int i = 1; i < tablica.Length; i+= 2)
{
    Console.WriteLine(tablica3[i]);
}

int[] tablica4 = {liczba , liczba2, liczba3, liczba4, liczba5};
Console.WriteLine("Liczby o indeksach parzystych: ");
for (int i = 0; i < tablica.Length; i+= 2)
{
    Console.WriteLine(value: tablica4[i]);
}
*/

// Zadanie 4

/*
int[] nowaTablica = new int[10];
Console.WriteLine("Wprowadź 10 liczb do tablicy:");

for (int i = 0; i < nowaTablica.Length; i++)
{
    nowaTablica[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Wprowadzone liczby to: ");
for (int i = 0; i < nowaTablica.Length; i++)
{
    Console.WriteLine(nowaTablica[i]);
}

Console.WriteLine("Suma elementów to: ");
int wynik = 0;
for (int i = 0; i < nowaTablica.Length; i++)
{
    wynik += nowaTablica[i];
}
Console.WriteLine(wynik);

Console.WriteLine("Iloczyn elementów to: ");
int wynik2 = 1;
for (int i = 0; i < nowaTablica.Length; i++)
{
    wynik2 *= nowaTablica[i];
}
Console.WriteLine(wynik2);

Console.WriteLine("Średnia elementów to: ");
double wynik3 = 0.00;
for (int i = 0; i < nowaTablica.Length; i++)
{
    wynik3 += nowaTablica[i];
}
Console.WriteLine(wynik3 / nowaTablica.Length);

int min = nowaTablica[0];
int max = nowaTablica[0];
for (int i = 0; i  < nowaTablica.Length; i++)
{
    if (min > nowaTablica[i])
    {
        min = nowaTablica[i]; 
    }
    if (max < nowaTablica[i])
    {
       max = nowaTablica[i];
    }
}
Console.WriteLine("Najmniejszy element to: " + min);
Console.WriteLine("Największy element to: " + max);
*/

// Zadanie 5

/*for (int i = 20; i >= 0; i--)
{
    if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
    {
        continue;  
    }
    Console.WriteLine(i);
}

*/

// Zadanie 6



while (true)
{
    Console.WriteLine("Wprowadź Liczbę: ");
    int liczba = Convert.ToInt32(Console.ReadLine());
    if (liczba > 0)
    {
        continue;
    }
    else
    {
        break;
    }

}