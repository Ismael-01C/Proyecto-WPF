using Proyecto_Final.MVVM.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Proyecto_Final.Helpers.Consumo
{
    public class Consumo
    {
        public void Reduced(TextBox Artista, ListView ListArtist)
        {
            if (Artista.Text == string.Empty)
            {
                ListArtist.ItemsSource = null;
                return;
            }
            var result = SearchHelper.SearchArtistOrSong(Artista.Text);

            if (result == null)
            {
                return;
            }
            var listArtist = new List<SpotifyArtist>();

            foreach (var item in result.artists.items)
            {
                listArtist.Add(new SpotifyArtist()
                {
                    ID = item.id,
                    Image = item.images.Any() ? item.images[0].url : "https://w7.pngwing.com/pngs/973/860/png-transparent-anonym-avatar-default-head-person-unknown-user-user-pictures-icon-thumbnail.png",
                    Name = item.name,
                    Popularity = $"{item.popularity}%",
                    Followers = $"{item.followers.total.ToString("N")} seguidores",

                });
            }
            ListArtist.ItemsSource = listArtist;
        }
    }
    
}
