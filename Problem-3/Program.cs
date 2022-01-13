// See https://aka.ms/new-console-template for more information
using System.Collections;
ArrayList UnlulerinDizisi= new ArrayList();

string cumle = Console.ReadLine();
string unluler= "aeioöuüAEİOÖUÜ";
int count=0;

for (int i = 0; i < cumle.Length; i++)
{
    if(unluler.Contains(cumle[i]))
    {
        count++;
        UnlulerinDizisi.Add(cumle[i]);
    }
}
UnlulerinDizisi.Sort();
Console.WriteLine($"Yazdığınız cümlede {count} tane ünlü bulunmuştur ve bunlar şu şekilde sıralanmıştır:");
foreach (var item in UnlulerinDizisi)
{
    Console.WriteLine(item);
}


