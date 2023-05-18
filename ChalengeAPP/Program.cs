// Kobieta poniżej 30 lat 
// Ewa lat 33
// Niepełnoletni mężczyzna 


using System.ComponentModel.Design;

string name = "Ewa";
int age = 33;
string gender = "Kobieta";

if (age < 30) ;
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
if (name == "Ewa" && age > 33) ;
{
    Console.WriteLine("Ewa lat 33");
}
if (!(gender == "Kobieta")) ;
else
    Console.WriteLine("niepełnoletni mężczyzna");
