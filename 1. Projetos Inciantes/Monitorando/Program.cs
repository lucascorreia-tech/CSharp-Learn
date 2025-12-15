
static async Task DownloadArquivoAsync(string nome, int tempo)
{
    await Task.Delay(tempo);
    Console.WriteLine($"Download do arquivo com nome: {nome} foi concluido");
}

var taskNotion = DownloadArquivoAsync("Notion", 3000); 
var taskFirefox = DownloadArquivoAsync("Firefox", 4000);
var taskChrome = DownloadArquivoAsync("Chrome", 2000);

await Task.WhenAll(taskNotion, taskChrome, taskFirefox);

Console.WriteLine("Todas foram concluidas");