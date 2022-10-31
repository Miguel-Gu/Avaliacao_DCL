string years;
string months;
string days;
bool isNumber;
int totalDays;

Console.WriteLine("Olá. Seja bem vindo! \nEste programa vai retornar para você a sua idade expressa em dias. \n\nExemplo: Alguém que nasceu em 06/10/2004, no dia de hoje 31/10/2022 tem 18 anos, 0 meses e 25 dias. \nEntão ao ser perguntado, você deverá responder seguindo o seguinte exemplo: \n\nPergunta: Quantos anos você tem? \nResposta: 18 \nPergunta: Quantos meses de vida, sem contar os que contabilizam seus anos completos, você tem? \nResposta: 0 \nPergunta: Quantos dias de vida, sem contar os que contabilizam seus anos e meses completos, você tem? \nResposta: 25 \nCom isso, você receberá o resultado: \nVocê tem 6595 dias de vida. \nLembre-se de digitar apenas números! \nAgora que você já sabe como funciona, vamos lá!");

void printMessage()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nIsso não é um número. Digite um número, por favor.");
    Console.ForegroundColor = ConsoleColor.Gray;
}

do
{
    Console.WriteLine("\nQuantos anos você tem?");
    years = Console.ReadLine();

    if (years != null && years.All(char.IsDigit) && years != "")
    {
        isNumber = true;
    } else
    {
        printMessage();
        isNumber = false;
    }
    
} while (!isNumber);

do
{
    Console.WriteLine("\nQuantos meses de vida, sem contar os que contabilizam seus anos completos, você tem?");
    months = Console.ReadLine();

    if (months != null && months.All(char.IsDigit) && months != "")
    {
        isNumber = true;
    }
    else
    {
        printMessage();
        isNumber = false;
    }

} while (!isNumber);

do
{
    Console.WriteLine("\nQuantos dias de vida, sem contar os que contabilizam seus anos e meses completos, você tem?");
    days = Console.ReadLine();

    if (days != null && days.All(char.IsDigit) && days != "")
    {
        isNumber = true;
    }
    else
    {
        printMessage();
        isNumber = false;
    }

} while (!isNumber);

totalDays = Int32.Parse(years) * 365 + Int32.Parse(months) * 30 + Int32.Parse(days);

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("\nVocê tem " + totalDays + " dias de vida!");

Console.ForegroundColor = ConsoleColor.Gray;