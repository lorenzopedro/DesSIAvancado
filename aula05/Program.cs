﻿public class Program{
    public static void Main(string[] args){
        //Conversão implícita
        int numInt = 45;
        double numDouble = numInt;
        Console.WriteLine("Conversão implícita de int para double: ");
        Console.WriteLine($"Int: {numInt}, Double: {numDouble}");

        //Conversão usando o convert
        double valorDouble = 7.45;
        int valorConvertidoInt = Convert.ToInt32(valorDouble);

        string textoValor = "123";
        int textoConvertidoInt = Convert.ToInt32(textoValor);

        Console.WriteLine("Conversão usando Convert: ");
        Console.WriteLine($"Double: {valorDouble}, Inteiro: {valorConvertidoInt}, String: {textoValor}, StringConvertida: {textoConvertidoInt}");
    }
}