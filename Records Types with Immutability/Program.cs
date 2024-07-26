using Records_Types_with_Immutability;

var person = new Person("John", 30) { Adress = "123 Main St" };
Console.WriteLine($"Name: {person.name}, Age: {person.age}, Adress: {person.Adress}");