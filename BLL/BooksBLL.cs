using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Web.Http.Results;
using BLL.Entities;
using Newtonsoft.Json;
namespace BLL
{
 
    public class BooksBLL
    {
        private static string BASEAPIUrl { get; set; } = "https://fakerestapi.azurewebsites.net";
        private static HttpClient HttpClient = new HttpClient();
        //public static async IEnumerable<Book> GetBooks()
        //{
        //   List<Book> books = new List<Book>();
        //   HttpResponseMessage url =  await HttpClient.GetAsync( BASEAPIUrl + "/api/v1/Books");
        //   string respuesta = await url.Content.ReadAsStringAsync();
        //   var datos = JsonConvert.DeserializeObject<IEnumerable<Book>>(respuesta);
          
        //}
    }
}
