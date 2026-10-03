using desafio_dev.Model;
using Newtonsoft.Json;

string caminho = Path.Combine(
    Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName,
    "vendas.json"
);
decimal comissao = 0;

string json = File.ReadAllText(caminho);

DadosVendas? dados = JsonConvert.DeserializeObject<DadosVendas>(json);

foreach (var venda in dados.Vendas)
{
    if (venda.Valor < 100)
    {
        comissao = 0;
        System.Console.WriteLine($"Sem comissão {comissao} para {venda.Vendedor}");
    }
    else if (venda.Valor < 500)
    {
        comissao = venda.Valor * 0.01m;
        System.Console.WriteLine($"Comissão: {comissao} para {venda.Vendedor}");
    }
    else if (venda.Valor >= 500)
    {
        comissao = venda.Valor * 0.05m;
        System.Console.WriteLine($"Comissão: {comissao} para {venda.Vendedor}");
    }
}