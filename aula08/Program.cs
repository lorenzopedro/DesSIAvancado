using System;
using System.Collections.Generic;
using System.Linq;

//O  método Where é um método de extensão da LINQ() Language Integrated Query

public class Program{
    public static void Main(){
    List<int> numeros = new List<int>{1,2,3,4,5,6,7,8,9,10};

    //Usando uma expressão lambda para filtrar os números pares

    List<int> numerosPares = numeros.Where(n => n % 2 == 0).ToList();

    Console.WriteLine("Números Pares: ");
    numerosPares.ForEach(n => Console.WriteLine(n));

    List<string> frutas = new List<string>{"Maçã", "Banana", "Manga", "Abacaxi", "Melancia", "Morango"};


    //Ordenando a lista de frutas por ordem alfabética
    List<string> frutasOrdenadas = frutas.OrderBy(f => f).ToList();

    List<string> frutasComM = frutasOrdenadas.Where(f => f.StartsWith("M")).ToList();

    Console.WriteLine("Frutas que começam com M: ");
    frutasComM.ForEach(f => Console.WriteLine(f));

    //Terceira Pratica
    List<Pessoa> pessoas = new List<Pessoa> {
        new Pessoa("Lorenzo", 33),
        new Pessoa("Kauan", 1),
        new Pessoa("Ananda", 24),
        new Pessoa("Leone", 55),
        new Pessoa("Lara", 28),
    };

    List<Pessoa> pessoasFiltradas = pessoas
    .Where(p => p.Idade > 25)
    .OrderBy(p => p.Nome)
    .ToList();

    Console.WriteLine("Pessoas com idade maior que 25, ordenadas por Nome: ");
    pessoasFiltradas.ForEach(p => Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}"));

    }
} 
