using ClubeDaLeitura.ConsoleApp.Utilidades;

namespace ClubeDaLeitura.ConsoleApp.Dominio;

/*
    ● Campos obrigatórios:
        ○ Etiqueta (texto único, máximo 50 caracteres)
        ○ Cor (seleção de paleta ou hexadecimal)
        ○ Dias de empréstimo (número, padrão 7)
    ● Não pode haver etiquetas duplicadas
    ● Não permitir excluir uma caixa caso tenha revistas vinculadas
    ● Cada caixa define o prazo máximo para empréstimo de suas revistas
*/
// Encapsulamento
public class Caixa
{
    public int Id { get; private set; }
    public string Etiqueta { get; private set; } = string.Empty;
    public string Cor { get; private set; } = string.Empty;
    public int DiasDeEmprestimo { get; private set; } = 7;

    // Construtor de Classe
    // Toda instância que for criada PRECISA conter essas informações
    public Caixa(string etiqueta, string cor, int diasDeEmprestimo)
    {
        Id = GeradorIds.ObterIdCaixa();

        Etiqueta = etiqueta;
        Cor = cor;
        DiasDeEmprestimo = diasDeEmprestimo;
    }

    public string[] Validar()
    {
        string erros = string.Empty;

        if (string.IsNullOrWhiteSpace(Etiqueta))
            erros += "O campo \"Etiqueta\" deve ser preenchido;";

        else if (Etiqueta.Length > 50)
            erros += "O campo \"Etiqueta\" deve conter no máximo 50 caracteres;";

        if (string.IsNullOrWhiteSpace(Cor))
            erros += "O campo \"Cor\" deve ser preenchido;";

        if (DiasDeEmprestimo < 1)
            erros += "O campo \"Dias de Empréstimo\" deve conter um valor maior que 0;";

        return erros.Split(';', StringSplitOptions.RemoveEmptyEntries);
    }

    public void Atualizar(Caixa caixaAtualizada)
    {
        Etiqueta = caixaAtualizada.Etiqueta;
        Cor = caixaAtualizada.Cor;
        DiasDeEmprestimo = caixaAtualizada.DiasDeEmprestimo;
    }
}
