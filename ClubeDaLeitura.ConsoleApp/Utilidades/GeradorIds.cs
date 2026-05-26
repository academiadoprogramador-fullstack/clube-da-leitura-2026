namespace ClubeDaLeitura.ConsoleApp.Utilidades;

public static class GeradorIds
{
    private static int contadorIdsCaixas = 1;

    public static int ObterIdCaixa()
    {
        return contadorIdsCaixas++;
    }
}