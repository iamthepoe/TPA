using System;
class MainClass {
  public static void Main (string[] args) {
    string[] nome = new string[10];
    double[] preco = new double[10];
    double valor = 0;

    for(int i = 0; i<10; i++){
      Console.Write($"Insira o NOME do {i+1}° PRODUTO: ");
      nome[i] = Console.ReadLine();
      Console.Write($"Insira o PREÇO do {i+1}° PRODUTO: ");
      preco[i] = double.Parse(Console.ReadLine());
      Console.Clear();
    }

    Console.Write("Insira um preço para a pesquisa: ");
    valor = double.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("PRODUTOS: ");
    for(int i = 0; i<10; i++){
      if(preco[i]<=valor){
        Console.WriteLine($"====================\nPRODUTO: {nome[i]}\nPREÇO: {preco[i]}\n====================");
      }
    }

  }
}