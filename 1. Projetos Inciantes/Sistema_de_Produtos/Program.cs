using System.Collections.Generic;
using System.Linq;
using Sistema;
public class Program
{
  public static void Main()
  {
    List<Produto> produtos =
    [
      new() { Id = 1, Nome = "Notebook", Preco = 3500.00, Categoria = "Eletrônicos", Ativo = true },
            new() { Id = 2, Nome = "Mouse", Preco = 50.00, Categoria = "Eletrônicos", Ativo = true },
            new() { Id = 3, Nome = "Teclado", Preco = 120.00, Categoria = "Eletrônicos", Ativo = false },
            new() { Id = 4, Nome = "Camiseta", Preco = 45.00, Categoria = "Roupas", Ativo = true },
            new Produto { Id = 5, Nome = "Calça Jeans", Preco = 150.00, Categoria = "Roupas", Ativo = true },
            new Produto { Id = 6, Nome = "Tênis", Preco = 250.00, Categoria = "Roupas", Ativo = true },
            new Produto { Id = 7, Nome = "Maçã", Preco = 5.00, Categoria = "Alimentos", Ativo = true },
            new Produto { Id = 8, Nome = "Leite", Preco = 4.50, Categoria = "Alimentos", Ativo = true },
            new Produto { Id = 9, Nome = "Pão", Preco = 8.00, Categoria = "Alimentos", Ativo = false }
    ];

    // Nível 1
    IEnumerable<Produto> produtos_filtrados = produtos.Where(p => p.Ativo);
    foreach ( Produto produto in produtos_filtrados)
    {
      Console.WriteLine($" Nome = {produto.Nome} | Preço = {produto.Preco}");
    }

    Console.WriteLine("------------------------------------");

    IEnumerable<Produto> produtos_preco = produtos.Where(p => p.Preco > 100);
    foreach ( Produto produto in produtos_preco)
    {
      Console.WriteLine($" Nome = {produto.Nome} | Preço = {produto.Preco}");
    }

    Console.WriteLine("------------------------------------");

    List<string?> lista_produto_nomes = produtos.Select(p => p.Nome).ToList();
    foreach(String? nome in lista_produto_nomes)
    {
      Console.WriteLine(nome);
    }

    Console.WriteLine("------------------------------------");

    var produtos_sorted = produtos.OrderBy(p => p.Preco);
    foreach ( Produto produto in produtos_sorted)
    {
      Console.WriteLine($" Nome = {produto.Nome} | Preço = {produto.Preco}");
    }

    Console.WriteLine("------------------------------------");

    var produtos_sorted_decre = produtos.OrderByDescending(p => p.Preco);
    foreach ( Produto produto in produtos_sorted_decre)
    {
      Console.WriteLine($" Nome = {produto.Nome} | Preço = {produto.Preco}");
    }

    Console.WriteLine("------------------------------------");

    // Nível 2
    var média_produtos = produtos.Average(p => p.Preco);
    Console.WriteLine($" A média dos produtos é {média_produtos:F2}");
    Console.WriteLine("------------------------------------");
    var produtos_eletronicos = produtos.Count(p => p.Categoria == "Eletrônicos");
    Console.WriteLine($" O total de produtos eletronicos é {produtos_eletronicos}");
    Console.WriteLine("------------------------------------");
    var existe_menor10 = produtos.Any(p => p.Preco < 10);
    Console.WriteLine(existe_menor10);
    Console.WriteLine("------------------------------------");
    var primeiroProdutoC = produtos.FirstOrDefault(p => p.Nome.Contains('C'));
    Console.WriteLine(primeiroProdutoC?.Nome);
    Console.WriteLine("------------------------------------");
    var paginacao = produtos.Skip(3).Take(3).ToList();
    foreach (var produto in paginacao)
    {
      Console.WriteLine(produto.Nome);
    }
  }
}