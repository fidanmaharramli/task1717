#region task1
int[] numbers = { 5, 4, 6 };
for (int i = 0; i < numbers.Length; i++)
{
    int factorial = 1;
    for (int j = 1; j <= numbers[i]; j++)
    {
        factorial = factorial * j;
    }
    numbers[i] = factorial;
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
#endregion

#region task2
int[] numbers = { 7, 12, 5, 8 };
int enKicik = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < enKicik)
    {
        enKicik = numbers[i];
   }
}
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] != enKicik)
    {
        Console.Write(numbers[i] + " ");
    }
}
#endregion

#region task4
int n = 1;
int m = 100;
for (int i = n; i <= m; i++)
{
    int eded = i;
    int ters = 0;

    while (eded > 0)
    {
        ters = ters * 10 + eded % 10;
        eded = eded / 10;
    }
    if (i == ters)
    {
        Console.WriteLine(i);
    }
}
#endregion

#region task3
string soz = "kertenkele";
for (int i = 0; i < soz.Length; i++)
{
    int cem = 0;

    for (int j = 0; j < soz.Length; j++)
    {
        if (soz[i] == soz[j])
        {
            cem++;
        }
    }
    if (cem == 1)
    {
        Console.WriteLine(soz[i]);
        break;
    }
 }
#endregion

#region task6
string soz = "mam";
char enCox = ' ';
int maxCount = 0;
for (int i = 0; i < soz.Length; i++)
{
    int count = 0;
    for (int j = 0; j < soz.Length; j++)
    {
        if (soz[i] == soz[j])
        {
            count++;
        }
    }
    if (count > maxCount)
    {
        maxCount = count;
        enCox = soz[i];
    }
}
Console.WriteLine(enCox);
#endregion

#region task7
string soz = "salam mellim";
string yenisoz = "";
for (int i = 0; i < soz.Length; i++)
{
    if (soz[i] != ' ')
    {
        yenisoz = yenisoz + soz[i];
    }
}
Console.WriteLine(yenisoz);
#endregion

#region task8
string[] sozler = { "salam", "fidan", "sagol" };
char herf = 'a';
int cem = 0;
for (int i = 0; i < sozler.Length; i++)
{
    for (int j = 0; j < sozler[i].Length; j++)
    {
        if (sozler[i][j] == herf)
        {
            cem++;
        }
    }
}
Console.WriteLine(cem);
#endregion


#region task10
int a = 10;
int b = 5;
char simvol = '+';
if (simvol == '+')
{
    Console.WriteLine(a + b);
}
else if (simvol == '-')
{
    Console.WriteLine(a - b);
}
else if (simvol == '*')
{
    Console.WriteLine(a * b);
}
else if (simvol == '/')
{
    Console.WriteLine(a / b);
}
else
{
    Console.WriteLine("Yanlis simvol");
}
#endregion

#region task11
string soz = "salam";
bool tapildi = false;
for (int i = 0; i < soz.Length; i++)
{
    if (soz[i] == 'a' || soz[i] == 'a')
    {
       tapildi = true;
    }
}
if (tapildi)
{
    Console.WriteLine("a herfi var");
}
else
{
   Console.WriteLine("a herfi yoxdur");
}
#endregion

#region task12
string soz = "mama";
int cem = 0;
for (int i = 0; i < soz.Length; i++)
{
   if (soz[i] == 'a')
   {
       cem++;
   }
}
Console.WriteLine(cem);
#endregion

#region task13
int eded = 8;
if (eded > 0 && eded % 2 == 0)
{
   Console.WriteLine(eded * eded);
}
else
{
  Console.WriteLine("Eded musbet ve cut deyil");
}
#endregion

#region task14
string tehsil = "programming";
if (tehsil == "programming")
{
    Console.WriteLine("400 saat");
}
else if (tehsil == "design")
{
    Console.WriteLine("250 saat");
}
else if (tehsil == "system")
{
   Console.WriteLine("200 saat");
}
else
{
    Console.WriteLine("tehsil novu yanlisdir");
}
#endregion
