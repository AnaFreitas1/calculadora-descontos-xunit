namespace CalculadoraDescontos.App;

public class DescontoService
{
    // 1. Retorno string
    public string ObterCategoriaCliente(int totalCompras)
    {
        if (totalCompras < 5)
            return "BRONZE";
        if (totalCompras <= 10)
            return "PRATA";
        return "OURO";
    }

    // 2. Retorno int
    public int CalcularDescontoPorPercentual(int valorOriginal, int percentualDesconto)
    {
        return valorOriginal - (valorOriginal * percentualDesconto / 100);
    }

    // 3. Retorno bool
    public bool EValidoParaCupom(int idade, bool primeiraCompra)
    {
        return idade >= 18 || primeiraCompra;
    }
}