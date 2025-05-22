//Verilmiş Arrayın elementlərinin cəmini ekrana çap edin
Console.Write("Element sayını daxil edin: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Element{i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int cem = 0;
for (int i = 0; i < array.Length; i++)
{
    cem += array[i];
}
Console.WriteLine(cem);


//Verilmiş int Arrayın ən böyük dəyərə sahib elementini tapın
Console.Write("Element sayını daxil et: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Element daxil edin");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(array);
Console.WriteLine(array[(array.Length) - 1]);


//Verilmiş Arrayın ilk və son elementlərinin cəmini tapın
Console.WriteLine("Element sayini daxil et");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Element daxil edin");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(array[(array.Length) - 1] + array[0]);


//Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın
int n = Convert.ToInt32(Console.ReadLine());
while (n % 2 == 0 && n > 1)
{
    n /= 2;
}
if (n == 1)
{
    Console.WriteLine("HE");
}
else
{
    Console.WriteLine("DEYIL");
}


//Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (n != 0)
{
    n /= 10;
    count++;
}
Console.WriteLine(count);


//Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiryi indexi tapan alqoritm
//(meselen 50 axtaririq egər siyahıda 50 ədədi yoxdursa -1 print olsun, varsa var olduğu index)
int numWeNeed = 24;
Console.Write("Element sayini daxil et-");
int n = Convert.ToInt32(Console.ReadLine());
int k = n;
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Element daxil edin-");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int j = 0; j < n; j++)
{
    if (array[j] == numWeNeed)
    {
        Console.WriteLine(j);
        break;
    }
    if (k == 1)
    {
        Console.WriteLine("-1");
    }
    k--;
}


//Verilmiş ədədlər siyahısındaki rəqəmlərinin sayı 2-dən böyük olan ədədlərin cəmini tapan alqoritm
Console.Write("Element sayini daxil et-");
int cem = 0;
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Element daxil edin-");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int j = 0; j < n - 1; j++)
{
    if (array[j] > 9)
    {
        cem += array[j];
    }
}
Console.WriteLine(cem);


//Verilmiş tələbələr siyahısında GroupNo dəyəri PB302 olan tələbələrin point ortalamasını hesablayan alqoritm
//( tələbə obyektinin Point və GroupName xüsusiyyətləri var)
Console.Write("Telebelerin sayini daxil et-");
double cem = 0;
int say = 0;
int n = Convert.ToInt32(Console.ReadLine());
String[] array = new String[n];
int[] points = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"{i + 1}-Nomreli Telebeni Daxil Edin: ");
    array[i] = Console.ReadLine();
}
for (int j = 0; j < n; j++)
{
    Console.Write($"{array[j]}-Adli telebenin Pointi: ");
    points[j] = Convert.ToInt16(Console.ReadLine());
}
for (int f = 0; f < n; f++)
{
    cem += points[f];
}
Console.WriteLine($"Ortalama bal:{cem / n}");