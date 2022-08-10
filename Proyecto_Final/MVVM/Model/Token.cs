namespace Proyecto_Final.Models
{
    public class Token
    {
        public string access_token { get; set; } //el acceso

        public string token_type { get; set; } //el tipo

        public int expires_in { get; set; } //cuando expira
    }
}
