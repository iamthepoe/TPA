using System;
class MainClass {
  public static void Main (string[] args) {
    double[,] matriz = new double[3,5];
    double[] soma = new double[3];



    for(int i = 0; i<3; i++){ // entrada dos valores
      for(int j = 0; j<5; j++){
        Console.Write($"Insira o {j+1}° valor da {i+1}° coluna: ");
        matriz[i,j] = double.Parse(Console.ReadLine());
        Console.Clear();
      }
    }

    for(int i = 0; i<3; i++){ // soma dos valores
      for(int j = 0; j<5; j++){
        soma[i]+= matriz[i,j];
      }
    }

    Console.WriteLine($"SOMA LINHA 1: {soma[0]}\nSOMA LINHA 2: {soma[1]}\nSOMA LINHA 3: {soma[2]}");

  }
}