using System.Net.Http.Headers;
using System.Text.Json;

using var client = new HttpClient();
client.BaseAddress = new Uri("https://rickandmortyapi.com/api/");

Character personaje = null;

var response = client.GetAsync("character/1").Result;

Console.WriteLine(response.Content.ReadAsStringAsync().Result);


public class Character
{
    public string id { get; set; }
    public string name { get; set; }
    public string status { get; set; }
    public string species { get; set; }
    public string type { get; set; }
    public string gender { get; set; }
    public string origin { get; set; }
    public string location { get; set; }
    public string episode { get; set; }


}