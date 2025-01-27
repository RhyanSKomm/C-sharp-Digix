using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Aula_27_Manipulacao2
{
    public class ConsumirJsonParaTxt
    {
        static async Task Main(string[] args)
        {
            string url = "https://raw.githubusercontent.com/manami-project/anime-offline-database/master/anime-offline-database-minified.json";

            string nomeArquivo = "animes.txt";

            try
            {
                using(HttpClient cliente = new HttpClient())
                {
                    var responseString = await cliente.GetAsync(url);

                    var response = await response.Content.ReadSasStringAsync();

                    using(JsonDocument document = JsonDocument.Parse(responseString))
                    {
                        var animeList = document.RootElement.GetProperty("data");

                        SalvarEmTxt(animeList,nomeArquivo);
                    }

                    System.Console.WriteLine("Informações salvas com sucesso!");
                }
            }
            catch
            {

            }
        } 

        static void SalvarEmTxt(JsonElement animeList, string nomeArquivo)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(nomeArquivo))
                {
                    foreach (var anime in animeList.EnumerateArray())
                    {
                        string title = anime.GetProperty("title").GetString() ?? "Sem Titulo";
                        string type = anime.GetProperty("type").GetString() ?? "Sem Tipo";
                        string episodes = anime.GetProperty("episodes").GetString() ?? "Sem Episodios";
                        string status = anime.GetProperty("status").GetString() ?? "Sem Status";

                        string season = "N/A";
                        int year = 0;

                        // if(animeList.TryGetProperty("animeSeason", out JsonElement animeSeason))
                        // {
                        //     season = animeSeason.TryGetProperty("season").GetString() ?? "N/A";
                            
                    }
                }
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}