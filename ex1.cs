using System;
class MainClass {
  public static void Main (string[] args) {
    int[] numero = new int[15];

    for(int i = 0; i<15; i++){
      Console.Write($"Insira o valor do índice {i}: ");
      numero[i] = int.Parse(Console.ReadLine());
      Console.Clear();
    }

    for(int i = 0; i<15; i++){
      if(i%2==0){
        Console.WriteLine(numero[i]);
      }
    }
  }
}