using System;
using System.Data;

public class Program{
    public static void main(string[] args){
        //Cadastrar os dados de Pessoa
        Console.WriteLine("Cadastro de pessoa!");
        Console.Write("Nome: ");
        string? nomePessoa = Console.ReadLine();

        Console.WriteLine("Idade: ");
        int idadePessoa = int.Parse(Console.ReadLine());

        Pessoa pessoa1 = new Pessoa(nomePessoa, idadePessoa);

        Console.WriteLine(pessoa1.ToString());
        Console.WriteLine("FIM");
    }
}