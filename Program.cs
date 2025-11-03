using static psc_lista_08_2025.Models.Atividades;

int menu = -1;
bool exit = false;

while (!exit)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Atividade 1");
        Console.WriteLine("2. Atividade 2");
        Console.WriteLine("3. Atividade 3");
        Console.WriteLine("4. Atividade 4");
        Console.WriteLine("5. Atividade 5");
        Console.WriteLine("6. Atividade 6");
        Console.WriteLine("0. Sair");
        Console.Write("Escolha uma opção: ");

        string? input = Console.ReadLine();
        if (!int.TryParse(input, out menu))
        {
            Console.WriteLine("Por favor, insira um número válido.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            continue;
        }

        switch (menu)
        {
            case 1:
                Atividade1();
                break;
            case 2:
                Atividade2();
                break;
            case 3:
                Atividade3();
                break;
            case 4:
                Atividade4();
                break;
            case 5:
                Atividade5();
                break;
            case 6:
                Atividade6();
                break;
            case 0:
                exit = true;
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro: " + ex.Message);
    }
    if (!exit)
    {
        Console.WriteLine("Clique em qualquer tecla para continuar...");
        Console.ReadKey();
    }
}