using ClubeDaLeitura.ConsoleApp.Apresentacao;
using ClubeDaLeitura.ConsoleApp.Apresentacao.Base;
using ClubeDaLeitura.ConsoleApp.Infraestrutura;

// 1. Instanciação de dependências
RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
RepositorioRevista repositorioRevista = new RepositorioRevista();
RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();

TelaPrincipal telaPrincipal = new TelaPrincipal
(
    repositorioCaixa,
    repositorioRevista,
    repositorioAmigo,
    repositorioEmprestimo
);

// 2. Loop do menu principal
while (true)
{
    TelaBase? telaSelecionada = telaPrincipal.ApresentarMenuOpcoesPrincipal();

    if (telaSelecionada == null)
    {
        Console.Clear();
        break;
    }

    // 3. Loop do menu interno
    while (true)
    {
        string? opcaoMenuInterno = telaSelecionada.ObterOpcaoMenu();

        if (opcaoMenuInterno == "S")
        {
            // Console.Clear();
            break;
        }

        if (opcaoMenuInterno == "1")
            telaSelecionada.Cadastrar();

        else if (opcaoMenuInterno == "2")
            telaSelecionada.Editar();

        else if (opcaoMenuInterno == "3")
            telaSelecionada.Excluir();

        else if (opcaoMenuInterno == "4")
            telaSelecionada.VisualizarTodos(deveExibirCabecalho: true);

        // else if (opcaoMenuPrincipal == "4") // Empréstimos
        // {
        //     opcaoMenuInterno = telaEmprestimo.ObterOpcaoMenu();

        //     if (opcaoMenuInterno == "S")
        //     {
        //         Console.Clear();
        //         break;
        //     }

        //     if (opcaoMenuInterno == "1")
        //         telaEmprestimo.Abrir();

        //     else if (opcaoMenuInterno == "2")
        //         telaEmprestimo.Concluir();

        //     else if (opcaoMenuInterno == "3")
        //         telaEmprestimo.VisualizarTodos(deveExibirCabecalho: true);
        // }
    }
}