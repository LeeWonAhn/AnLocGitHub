﻿using System;
class AbstractAndInterfaceTests
{
  static void Main(string[] args)
  {
    Animal[] animals = new Animal[2];
    animals[0] = new Tiger();
    animals[1] = new Chicken();

    foreach (Animal animal in animals)
    {
      Console.WriteLine(animal.MakeSound());

      if (animal is Chicken)
      {
        Edible edibler = (Chicken)animal;
        Console.WriteLine(edibler.HowToEat());
      }
    }
    Fruit[] fruits = new Fruit[2];
    fruits[0] = new Orange();
    fruits[1] = new Apple();
    foreach (Fruit fruit in fruits)
    {
      Console.WriteLine(fruit.HowToEat());
    }
  }
}

public interface Edible
{
  public string HowToEat();
}