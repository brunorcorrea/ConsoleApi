using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var apiPath = RestService.For<ApiService>("https://elearning-tcc.herokuapp.com");
                var dataResponse = await apiPath.GetSeriesAsync();
             
                ApiResponse[] series = JsonConvert.DeserializeObject<ApiResponse[]>(dataResponse.ToString());

                for (int i = 0; i < series.Length; i++){
                    ApiResponse serie = series[i];
                    Console.WriteLine($"\nId:{serie.Id},\n{serie.Curso},\n{serie.Tipo},\n{serie.Ano},\n{serie.Periodo}\n");
                }

                //Console.WriteLine(dataResponse[0]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro na Consulta: " + e.Message);
            }
        }
    }
}