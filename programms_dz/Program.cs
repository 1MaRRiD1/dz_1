//Console.Write("Введите трехзначное число: ");
//int number = Convert.ToInt32(Console.ReadLine());
// 1 задача  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if ( number1>number2){
    Console.WriteLine( $"число {number1} наибольшее" ) ;
    Console.WriteLine( $"число {number2} наименьшее" ) ;
   }
else {
    Console.WriteLine( $"число {number2} наибольшее" ) ;
    Console.WriteLine( $"число {number1} наименьшее" ) ;
}*/

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
  int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
  int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье  число: ");
  int number3 = Convert.ToInt32(Console.ReadLine());
int count = 0 ;
int max = number1 ;
while(count<2){
    if(max<number2){
        max = number2;
    }
    else if(max<number3){
        max= number3;
    }
    else{
        count++ ;
    }
}
Console.Write($"{max} - наибольшее из трех чисел ");




