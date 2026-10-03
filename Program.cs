using desafio_dev.Model;
using Newtonsoft.Json;

string caminho = Path.Combine(
    Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName,
    "vendas.json"
);

string json = File.ReadAllText(caminho);

DadosVendas? dados = JsonConvert.DeserializeObject<DadosVendas>(json);

foreach (var venda in dados.Vendas)
{
    Console.WriteLine($"Vendedor: {venda.Vendedor} Produto: {venda.Produto} Valor: {venda.Valor}");
}