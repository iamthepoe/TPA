using System;
class MainClass {
  public static void Main (string[] args) {
    int[,] matriz = new int[5,5];
    int n = 0;
    for(int i = 0; i<5; i++){ // inserindo os valores
      for(int j = 0; j<5; j++){
        n++;
        matriz[i,j] = n;
      }
    }

    for(int x = 0; x<5; x++){ // mostrar diagonais na tela
      for(int y = 0; y<5; y++){
        if(x == y){
          Console.Write($" [{matriz[x,y]}], ");
        }else if((x + y) == 4){
          Console.Write($" [{matriz[x,y]}], ");
        }
      }
    }

  }
}