using System;
class MainClass {
  public static void Main (string[] args) {
    string[,] tabela = new string[3,3]; //3x3
    bool jogadorVenceu = false; //condição para executar o jogo, caso torne-se verdadeira, o jogo acaba.
    bool xVenceu = false; //condição para verificar qual jogador venceu.
    int definidor = 0; //contador impar|par e preenchedor de matrizes.
    int opcao = 0; //armazenará as jogadas dos jogadores X e O.


    for(int i = 0; i<3; i++){   // preencher matriz.
      for(int j = 0; j<3; j++){
        tabela[i,j] = Convert.ToString(definidor);
        definidor++;
      }
    }

    definidor = 0;
    do{
        Console.WriteLine("=================\nJogo da Velha\n================="); //exibir tabela;
        for(int i = 0; i<3; i++){ 
          for(int j = 0; j<3; j++){
            Console.Write("|");
            Console.Write($"{tabela[i,j],3} ");
          }
          Console.WriteLine("|");
          Console.WriteLine("----------------");
        }
        Console.WriteLine("=================");


      if(definidor%2==0){ //verifica a vez de cada jogador.

        Console.Write($"----------\nJogador X\n----------\nInsira um valor: ");
        opcao = int.Parse(Console.ReadLine());
        while(opcao<0 || opcao>9){ //previnindo o erro do valor fora do desejado.
            Console.Write("Valor incorreto! Insira um valor de 0 a 8: ");
            opcao = int.Parse(Console.ReadLine());
        }

        if(opcao>=0 && opcao<=2){ // Aqui o computador verificará onde a coluna está.
            if(tabela[0,opcao] == "X" || tabela[0,opcao] == "O" ){
              Console.WriteLine("Esse espaço já está preenchido! Pressione ENTER para CONTINUAR.");
              Console.ReadLine();
              definidor--;
            }else{
              tabela[0,opcao] = "X";
            }
          }else if(opcao>=3 && opcao<=5){
            if(tabela[1,opcao-3] == "X" || tabela[1,opcao-3] == "O" ){
              Console.WriteLine("Esse espaço já está preenchido! Pressione ENTER para CONTINUAR.");
              Console.ReadLine();
              definidor--;
            }else{
              tabela[1,opcao-3] = "X";
            }
          }else{

            if(tabela[2,opcao-6] == "X" || tabela[2,opcao-6] == "O" ){
              Console.WriteLine("Esse espaço já está preenchido! Pressione ENTER para CONTINUAR.");
              Console.ReadLine();
              definidor--;
            }else{
              tabela[2,opcao-6] = "X";
            }
          
        }

      }else{

          Console.Write($"----------\nJogador O\n----------\nInsira um valor: ");
          opcao = int.Parse(Console.ReadLine());
          while(opcao<0 || opcao>9){ //previnindo o erro do valor fora do desejado.
            Console.Write("Valor incorreto! Insira um valor de 0 a 8.");
            opcao = int.Parse(Console.ReadLine());
        }

        if(opcao>=0 && opcao<=2){ // Aqui o computador verificará onde a coluna está.
            if(tabela[0,opcao] == "X" || tabela[0,opcao] == "O" ){
              Console.WriteLine("Esse espaço já está preenchido! Pressione ENTER para CONTINUAR.");
              Console.ReadLine();
              definidor--;
            }else{
              tabela[0,opcao] = "O";
            }
          }else if(opcao>=3 && opcao<=5){
            if(tabela[1,opcao-3] == "X" || tabela[1,opcao-3] == "O" ){
              Console.WriteLine("Esse espaço já está preenchido! Pressione ENTER para CONTINUAR.");
              Console.ReadLine();
              definidor--;
            }else{
              tabela[1,opcao-3] = "O";
            }
          }else{
            
            if(tabela[2,opcao-6] == "X" || tabela[2,opcao-6] == "O" ){
              Console.WriteLine("Esse espaço já está preenchido! Pressione ENTER para CONTINUAR.");
              Console.ReadLine();
              definidor--;
            }else{
              tabela[2,opcao-6] = "O";
            } 
          
        }

      }

      for(int i = 0; i<3; i++){ //Condições de vitória, horizontal: x,0 == x,1 == x,2
        if(tabela[i,0] == tabela[i,1] && tabela[i,1] == tabela[i,2]){
          jogadorVenceu = true;
        }
        if(tabela[i,0] == "X" && tabela[i,1] == "X" && tabela[i,2] == "X"){
          xVenceu = true;
        }
      }

      for(int j = 0; j<3; j++){ //Condições de vitória, vertical: 1,y == 2,y == 3,y
        if(tabela[0,j] == tabela[1,j] && tabela[1,j] == tabela[2,j]){
          jogadorVenceu = true;
        }

        if(tabela[0,j] == "X" && tabela[1,j] == "X" && tabela[2,j] == "X"){
          xVenceu = true;
        }

      }

      if(tabela[0,0] == tabela[1,1] && tabela[1,1] == tabela[2,2]){ //Condições de vitória, diagonal esquerda: x,x == x,x == x,x;
        jogadorVenceu = true;

        if(tabela[0,0] == "X" && tabela[1,1] == "X" && tabela[2,2] == "X"){
          xVenceu = true;
        }
      }

      if(tabela[0,2] == tabela[1,1] && tabela[1,1] == tabela[2,0]){ //Condições de vitória, diagonal direita: 1,3 == 2,2 == 3,1
       jogadorVenceu = true;

       if(tabela[0,2] == "X" && tabela[1,1] =="X"  && tabela[2,0] == "X"){
         xVenceu = true;
       }
      }
      
      Console.Clear();
      definidor++; //altera o número para par ou impar.
    }while(definidor != 9 && jogadorVenceu!=true);

     Console.WriteLine("=================\nJogo da Velha\n================="); //vai mostrar a tabela finalizada na tela.
        for(int i = 0; i<3; i++){ 
          for(int j = 0; j<3; j++){
            Console.Write("|");
            Console.Write($"{tabela[i,j],3} ");
          }
          Console.WriteLine("|");
          Console.WriteLine("----------------");
        }
        Console.WriteLine("=================");


    if(jogadorVenceu==true){ //verifica o resultado do jogo, mostra uma mensagem de acordo.
      Console.ForegroundColor = ConsoleColor.Yellow;
      if(xVenceu){
        Console.WriteLine("Jogador X VENCEU!");
      }else{
        Console.WriteLine("Jogador O VENCEU!");
      }
      
    }else{
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("Deu velha.");
    }

  }
}