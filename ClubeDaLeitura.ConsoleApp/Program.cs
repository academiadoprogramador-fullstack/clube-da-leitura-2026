using ClubeDaLeitura.ConsoleApp.Apresentacao;
using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.Dominio;
using ClubeDaLeitura.ConsoleApp.Infraestrutura;

RepositorioCaixa repositorioCaixa = new RepositorioCaixa();

TelaCaixa telaCaixa = new TelaCaixa(repositorioCaixa);

Caixa caixa = new Caixa("Lançamentos", "Vermelho", 3);
repositorioCaixa.Cadastrar(caixa);

TelaPrincipal telaPrincipal = new TelaPrincipal();

while (true)
{
    string? opcaoMenuPrincipal = telaPrincipal.ObterOpcaoMenuPrincipal();

    if (opcaoMenuPrincipal == "S")
    {
        Console.Clear();
        break;
    }

    while (true)
    {
        string? opcaoMenuInterno;

        if (opcaoMenuPrincipal == "1") // Caixas
        {
            opcaoMenuInterno = telaCaixa.ObterOpcaoMenu();

            if (opcaoMenuInterno == "S")
            {
                Console.Clear();
                break;
            }

            if (opcaoMenuInterno == "1")
                telaCaixa.Cadastrar();

            else if (opcaoMenuInterno == "2")
                telaCaixa.Editar();

            else if (opcaoMenuInterno == "3")
                telaCaixa.Excluir();

            else if (opcaoMenuInterno == "4")
                telaCaixa.VisualizarTodos(deveExibirCabecalho: true);
        }

        else if (opcaoMenuPrincipal == "2") // Revistas
        {

        }

        else if (opcaoMenuPrincipal == "3") // Amigos
        {

        }

        else if (opcaoMenuPrincipal == "4") // Empréstimos
        {

        }
    }
}