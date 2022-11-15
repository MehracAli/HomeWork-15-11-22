#region
int naturalEded = 529;
//int mertebe = 10;
int cavab = default;

for (int i = 1; i <= naturalEded; i *= 10)
{
    cavab = i;
}
if (cavab == 0)
{
    int b = 3 * 10 + naturalEded;
    Console.WriteLine(b);

    return;
}
cavab *= 10;

int a = 3 * cavab + naturalEded;
Console.WriteLine(a);
#endregion

//static int natural(int naturalEded)
//{
//    int cavab = default;

//    for (int i = 1; i <= naturalEded; i *= 10)
//    {
//        cavab = i;
//    }
//    if (cavab == 0)
//    {
//        int b = 3 * 10 + naturalEded;
//        Console.WriteLine(b);

//        return b;
//    }
//    cavab *= 10;

//    int a = 3 * cavab + naturalEded;
//    Console.WriteLine(a);
//    return a;
//}

//int a = natural(45);