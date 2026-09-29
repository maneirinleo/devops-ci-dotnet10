namespace DevOps.Api.Services;

public class CalculadoraService
{
    public int Somar(int primeiroNumero, int segundoNumero)
    {
        // Erro corrigido
        return primeiroNumero + segundoNumero;    

    }
    public bool EhPar(int numero)
    {
        return numero % 2 == 0;
    }
}