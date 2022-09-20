double num;

Console.Write("Digite um número: ");

num = Convert.ToDouble(Console.ReadLine());

if(num > 20){
    Console.WriteLine($"Número maior que 20 portanto sua metade é: {num/2}");
    Console.ReadKey();
}else{
    Console.WriteLine($"Número menor ou igual a 20 portanto seu dobro é: {num*2}");
}
Console.ReadKey();