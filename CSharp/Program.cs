using System;
using Primeiro;
using CSharp;
using Interface;
using Enum;

namespace CSharp;

class Program
{
    static void Main(string[] args)
    {
        var pessoa = (Pessoas)0;

        Pessoas pessoa2 = Pessoas.Joao;

        Pessoas pessoa3 = (Pessoas)4;

        Pessoa person = new Pessoa();

        person.Nome = "Welinton";
        person.Idade = 18;
        person.Estado = "SP";

        var person2 = new Pessoa();

        person2.Nome = "Giovanna";
        person2.Idade = 18;
        person2.Estado = "SP";

        Animal animal = new Animal();

        animal.Nome = "Pipoca";
        animal.NomeDono = "Welinton";
        animal.Especie = "Cachorro"; 

        var classe = new Classe();
        var classe2 = new Segundo.Classe();

        Console.WriteLine("Hello World!");

        Console.WriteLine(pessoa3);
    }
}