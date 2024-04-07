using c_24.Business;
using c_24.DataAccess.Concretes;
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



string[] loans = { "Kredi 1", "Kredi 2", "Kresi 3", "Kresi 4", "Kredi 5", "Kredi 6" };// db den gelecek
                                                                                      //string[] loans2 = new string[6];
                                                                                      //loans2[0] = "Kredi 1";

//start   condition         increment      
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new(new EfCourseDal());
List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}

Console.WriteLine("Kod bitti");


//Day2 INHERITANCE

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "123456789";
customer1.FirstName = "Deniz";
customer1.LastName = "Yılmaz";
customer1.CustomerNumber = "12345";


IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "123456788";
customer2.FirstName = "Ezgi";
customer2.LastName = "Yılmaz";
customer2.CustomerNumber = "12346";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "112233";
customer3.TaxNumber = "987654323";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Ertuğrulgazioo";
customer4.CustomerNumber = "654789";
customer4.TaxNumber = "987654324";


//value types--> int, bool, double...
int number1 = 10;//20
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

//reference types--> array, class, interface...
string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Artvin";
Console.WriteLine(cities2[0]);

//POLYMORPHISM
//101        102        103        104
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}


