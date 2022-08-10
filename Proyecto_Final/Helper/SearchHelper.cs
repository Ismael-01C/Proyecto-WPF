using Newtonsoft.Json;
using RestSharp;
using Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static Proyecto_Final.Models.SpotifySearch;

namespace Proyecto_Final.Helpers

{
    public static class SearchHelper
    {
        public static Token token { get; set; }

        public static async Task GetTokenAsync()
        {
            #region SecretVault
            string clientID = "d6c62bd2908e49a68a29c204b9c716e5";

            string clientSecret = "7af3b3575a264224abfc9f22c380bbfb";
            #endregion

            string auth = Convert.ToBase64String(Encoding.UTF8.GetBytes(clientID + ":" + clientSecret)); //se define el tipo de acceso y la credencial

            List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            };

            HttpClient client = new HttpClient(); //creo un cliente Http
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {auth}");
            HttpContent content = new FormUrlEncodedContent(args); //invoco

            HttpResponseMessage resp = await client.PostAsync("https://accounts.spotify.com/api/token", content); //es como una firma para traerme los objetos
            string msg = await resp.Content.ReadAsStringAsync();

            token = JsonConvert.DeserializeObject<Token>(msg);
        }

        public static SpotifyResult SearchArtistOrSong(string searchWord)
        {
            var client = new RestClient("https://api.spotify.com/v1/search");
            client.AddDefaultHeader("Authorization", $"Bearer {token.access_token}");
            var request = new RestRequest($"?q={searchWord}&type=artist", Method.Get); //Buaqueda por letra con el tipo de artista
            var response = client.Execute(request); //se realiza la ejecución

            if (response.IsSuccessful) //si es exitoso se realiza deserialización del objeto que se esta mapeando (lo que trajo el Json)
            {
                var result = JsonConvert.DeserializeObject<SpotifyResult>(response.Content); //deserializa el contenido
                return result; //devuelve el resultado
            }
            else
            {
                return null;
            }

        }
    }
}
