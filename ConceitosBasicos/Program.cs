// See https://aka.ms/new-console-template for more information
using System.Reflection.PortableExecutable;

//EXERCICIOS COM VETORES

/*
 * crie um vetor para armazenar as idades de 5 pessoas e ao final imprima:
 * 1) a pessoa mais nova
 * 2) a pessoa mais velha
 * 3) a media das idades
 * 4) todas as idades impares
 * 5) todas as idades pares
 */

byte[] idades = new byte[5];
for(int i = 0; i < 5; i++)
{
    Console.WriteLine( $"informe a {i+1}ª idade");
    idades[i] = byte.Parse(Console.ReadLine());

}
Console.WriteLine("As idades informadas foram:");
foreach(byte idade in idades)
{
    Console.WriteLine(idade);
}
