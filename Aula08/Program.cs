using System;

class Aula08{
    static void  Main(){
    //criando variaveis
    String nome;
    int v1,v2,soma;

    Console.WriteLine("Qual seu nome:");
     nome = Console.ReadLine();

     Console.WriteLine("Vamos calclar digite um numero:");
     v1=int.Parse(Console.ReadLine());
     Console.WriteLine("Digite o valor dois:");
     v2=int.Parse(Console.ReadLine());
     soma = v1+v2;

     Console.WriteLine(" {0} a soma de {1} +  {2} : {3}",nome,v1,v2,soma);
     
    }
}