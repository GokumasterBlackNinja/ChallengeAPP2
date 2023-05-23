// Kobieta poniżej 30 lat 
// Ewa lat 33
// Niepełnoletni mężczyzna 

using System;

string name = "Ewa";
int age = 33;
string gender = "Kobieta";

if (age < 30 && gender == "Kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender == "mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

