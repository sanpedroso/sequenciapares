int numeroatual = 0;
int valordasoma = 0;
Console.WriteLine("Digite o valor desejado...");
int r = Convert.ToInt16(Console.ReadLine());
while (numeroatual < r)
{
    valordasoma = valordasoma + numeroatual;
    Console.WriteLine(numeroatual);
    numeroatual = numeroatual +2;
}
Console.WriteLine(numeroatual);
 