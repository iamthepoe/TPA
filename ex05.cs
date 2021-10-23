using System;
class MainClass {
  public static void Main (string[] args) {
    string[] nome = new string[10];
    float[] media = new float[10];
    float[,] nota = new float[10,3];
    
    for(int i = 0; i<10; i++){
        Console.Write($"Insira o nome do {i+1}° aluno: ");
        nome[i] = Console.ReadLine();
      for(int j = 0; j<3; j++){
        Console.Write($"Insira a {j+1}° nota do {i+1}° aluno: ");
        nota[i,j] = float.Parse(Console.ReadLine());
        media[i]+= nota[i,j];
      }
      media[i] = media[i]/3;
      Console.Clear();
    }

    Console.WriteLine(String.Format("{0,-10} | {1,-36} | {2, -10}", "Alunos", "NOTAS", "MÉDIA"));
    for(int v = 0; v<10; v++){
      if(media[v]>=7){
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10} | {3,-10} | {4, -10}", nome[v], nota[v,0],nota[v,1],nota[v,2],media[v]));
      }else{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10} | {3,-10} | {4, -10}", nome[v], nota[v,0],nota[v,1],nota[v,2],media[v]));
      }
    }
  }
}
