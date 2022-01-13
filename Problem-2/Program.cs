// See https://aka.ms/new-console-template for more information
int[] arrayOfTheNumbers= new int[20];
for (int i = 0; i < arrayOfTheNumbers.Length; i++)
{
    if(int.TryParse(Console.ReadLine(),out int value))
    {
        arrayOfTheNumbers[i]=value;
    }else
    {
        Console.WriteLine("Lütfen Null ve string değiken yerine int değişken giriniz.");
        int.TryParse(Console.ReadLine(), out int input);
        arrayOfTheNumbers[i]= input;
    }
}

static int[] EnBuyuk(int[] arr)
{ 
    int[] theSupporter=new int[3];
    for (int i = 0; i < 3; i++)
    {
        theSupporter[i]= arr[i+17];
    }
    return theSupporter;
}
static int[] EnKucuk(int[]arr)
{
    int[] theSupporter=new int[3];
    for (int i = 0; i < 3; i++)
    {
        theSupporter[i]= arr[i];
    }
    return theSupporter;
}
static int OrtalamaAl(int[]arr)
{
    int average=0;
    foreach (var item in arr)
    {
        average+=item;
    }
    return average/arr.Length;
}
Console.WriteLine("En Büyük Üçlü:");
Array.Sort(arrayOfTheNumbers);
foreach (var item in EnBuyuk(arrayOfTheNumbers))
{
    Console.WriteLine(item);
}
Console.WriteLine("En Küçük Üçlü:");
Array.Sort(arrayOfTheNumbers);
foreach (var item in EnKucuk(arrayOfTheNumbers))
{
    Console.WriteLine(item);
}
Console.WriteLine("En Büyük Üçlünün Ortalması:");
Console.WriteLine(OrtalamaAl(EnBuyuk(arrayOfTheNumbers)));
Console.WriteLine("En Küçük Üçlünün Ortalması:");
Console.WriteLine(OrtalamaAl(EnKucuk(arrayOfTheNumbers)));
Console.WriteLine("Ortalamaların Toplamı:");
int ortalamaToplamı= OrtalamaAl(EnBuyuk(arrayOfTheNumbers))+OrtalamaAl(EnKucuk(arrayOfTheNumbers));
Console.WriteLine(ortalamaToplamı);


