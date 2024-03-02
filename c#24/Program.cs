// See https://aka.ms/new-console-template for more information
using c_24.Business;
using c_24.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables --> camelCase
bool isAuthenticated = false;
Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton--> Hoşgeldin Nizes");
}
else
{
    Console.WriteLine("Buton--> Sisteme giriş yap");
}



string[] loans = { "Kredi 1", "Kredi 2", "Kresi 3", "Kresi 4", "Kredi 5", "Kredi 6"};// db den gelecek
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

      //start   condition         increment      
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}



CourseManager courseManager = new();
Course[] courses2= courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name +"/"+ courses2[i].Price);
}



Console.WriteLine("Kod bitti");
