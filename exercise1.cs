using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    int total = 5;
    for(int i = 0; i < total; i++){
        for(int j = 0; j < i; j++){
            Console.Write((char)(j+65)+" ");
        }
        for(int k = i; k>=0;k--){
            Console.Write((char)(k+65)+" ");
        }
        Console.WriteLine();
    }
  }
}
