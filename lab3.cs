using System;
using System.Collections.Generic;

// Part 1: Abstract Class Implementation
abstract class Animal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    public abstract void Eat();
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }
}

class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }
}

// Part 2: Interface Implementation
interface IAnimal
{
    string Name { get; set; }
    string Colour { get; set; }
    int Age { get; set; }
    int Height { get; set; }
    void Eat();
    string Cry();
}

class DogInterface : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }

    public void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }

    public string Cry()
    {
        return "Woof!";
    }
}

class CatInterface : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }

    public void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }

    public string Cry()
    {
        return "Meow!";
    }
}

class Program
{
    static void Main()
    {
        // Testing Part 1 (Abstract Class)
        Console.Write("Enter a dog's name: ");
        string dogName = Console.ReadLine();
        Dog dog = new Dog { Name = dogName, Colour = "Brown", Age = 3 };
        Console.WriteLine($"Dog: {dog.Name}, Colour: {dog.Colour}, Age: {dog.Age}");
        dog.Eat();

        Console.Write("Enter a cat's name: ");
        string catName = Console.ReadLine();
        Cat cat = new Cat { Name = catName, Colour = "Black", Age = 2 };
        Console.WriteLine($"Cat: {cat.Name}, Colour: {cat.Colour}, Age: {cat.Age}");
        cat.Eat();

        // Testing Part 2 (Interface Implementation)
        Console.Write("Enter a dog's name: ");
        string dogName2 = Console.ReadLine();
        DogInterface dog2 = new DogInterface { Name = dogName2, Colour = "Golden", Age = 4, Height = 50 };
        Console.WriteLine($"Dog: {dog2.Name}, Colour: {dog2.Colour}, Age: {dog2.Age}, Height: {dog2.Height}cm");
        dog2.Eat();
        Console.WriteLine($"Dog cry: {dog2.Cry()}");

        Console.Write("Enter a cat's name: ");
        string catName2 = Console.ReadLine();
        CatInterface cat2 = new CatInterface { Name = catName2, Colour = "White", Age = 3, Height = 30 };
        Console.WriteLine($"Cat: {cat2.Name}, Colour: {cat2.Colour}, Age: {cat2.Age}, Height: {cat2.Height}cm");
        cat2.Eat();
        Console.WriteLine($"Cat cry: {cat2.Cry()}");

        // Creating a list of animals
        List<IAnimal> animals = new List<IAnimal> { dog2, cat2 };

        Console.WriteLine("List of animals:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name);
        }
    }
}
