using System.Collections;
using System.Collections.Generic;
using System;
/* Problem:

            Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
  * Negatif ve numeric olmayan girişleri engelleyin.
  * Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
  * Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/

ArrayList numbersInArrayList= new ArrayList(20); // 20 tane değere sonradan ekleme çıkarma yapılmayacağı için 20lik bir boyut verdim.

while(numbersInArrayList.Count<20)
{
    if(int.TryParse(Console.ReadLine(), out int input) && input>=0 )
    {
        numbersInArrayList.Add(input);
    }
    
}
ArrayList primeNumbers= new ArrayList();
ArrayList nonPrimeNumbers= new ArrayList();
foreach (int item in numbersInArrayList)
{
    int i, m =0, flag=0;
    m=item/2;
    if(item==0)
        {
        nonPrimeNumbers.Add(item);
            flag=1;
            
        }
        if(item==1)
        {
            nonPrimeNumbers.Add(item);
            flag=1;
            
        }
    for (i = 2; i <= m; i++)
    {
        
        if(item%i==0) //modunu teker teker arttırarak kendisinden veya sıfırdan başka çarpanı olup olmadığını arıyoruz. 
        {
            nonPrimeNumbers.Add(item);
            flag=1;
            break; //flag'i 1'e atarız ve döngüyü kırarız.
        }
    }

    
    if(flag==0) //flag 1 çıkarsa burası çalışmaz.
    {
        primeNumbers.Add(item);
    }  
}

static int AverageCalculator(ArrayList list)
{
int theSum=0;
    foreach (int item in list)
    {
        theSum+=item;
    }
    return theSum/list.Count;

}
static void SortAndWrite(ArrayList list)
{
    list.Sort();
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}
static void WriteTheLength(ArrayList list){

    Console.WriteLine(list.Count);
}

Console.WriteLine($"The average of prime numbers: {AverageCalculator(primeNumbers)} ");
Console.WriteLine($"The average of composite(nonprime) numbers: {AverageCalculator(nonPrimeNumbers)} ");
Console.WriteLine("Sorted prime numbers' list:");
SortAndWrite(primeNumbers);
Console.WriteLine("Sorted composite numbers' list:");
SortAndWrite(nonPrimeNumbers);
Console.WriteLine("The length of prime numbers' list:");
WriteTheLength(primeNumbers);
Console.WriteLine("The length of composite numbers' list:");
WriteTheLength(nonPrimeNumbers);







