int qtyCars;
string qtyCarsString;
int totalSales;
string totalSalesString;
int fixedSalary;
string fixedSalaryString;
int valPerCar;
string valPerCarString;
bool isNumber;
double finalSalary;

Console.WriteLine("Olá. Seja bem vindo! \nEste programa vai retornar o valor final do seu salário baseado na sua performance deste mês. \nComo estamos falando de valores grandes, lembre-se de digitar apenas valores inteiros, sem vírgulas e sem sinal de moeda. Exemplo: Para dizer que você tem um salário de R$1.000,00 ao ser perguntado qual o seu salário fixo, digite apenas 1000");

void printMessage()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nIsso não está em um formato válido. Digite um formato válido, por favor.");
    Console.ForegroundColor = ConsoleColor.Gray;
}

do
{
    Console.WriteLine("\nQuantos carros você vendeu?");
    qtyCarsString = Console.ReadLine();

    if (int.TryParse(qtyCarsString, out _))
    {
        qtyCars = Convert.ToInt32(qtyCarsString);
        isNumber = true;
    } else
    {
        printMessage();
        isNumber = false;
        qtyCars = 0;
    }
} while (!isNumber);

do
{
    Console.WriteLine("\nQual o valor total de suas vendas?");
    totalSalesString = Console.ReadLine();

    if (int.TryParse(totalSalesString, out _))
    {
        totalSales = Convert.ToInt32(totalSalesString);
        isNumber = true;
    }
    else
    {
        printMessage();
        isNumber = false;
        totalSales = 0;
    }
} while (!isNumber);

do
{
    Console.WriteLine("\nQual o seu salário fixo?");
    fixedSalaryString = Console.ReadLine();

    if (int.TryParse(fixedSalaryString, out _))
    {
        fixedSalary = Convert.ToInt32(fixedSalaryString);
        isNumber = true;
    }
    else
    {
        printMessage();
        isNumber = false;
        fixedSalary = 0;
    }
} while (!isNumber);

do
{
    Console.WriteLine("\nQuanto você recebe por carro vendido?");
    valPerCarString = Console.ReadLine();

    if (int.TryParse(valPerCarString, out _))
    {
        valPerCar = Convert.ToInt32(valPerCarString);
        isNumber = true;
    }
    else
    {
        printMessage();
        isNumber = false;
        valPerCar = 0;
    }
} while (!isNumber);

finalSalary = fixedSalary + qtyCars * valPerCar + totalSales * 0.05;

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("\nSeu salário é de R$" + finalSalary);

Console.ForegroundColor = ConsoleColor.Gray;