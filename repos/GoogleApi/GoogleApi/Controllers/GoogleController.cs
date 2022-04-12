using GoogleApi.Models;
using MapsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GoogleApi.Controllers
{
    public class GoogleController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var responseMessage =await client.GetAsync("https://localhost:44326/api/Google");
            //asenkron programlama her sunucu ayrı çalışır birden fazla api ayağa kalkarsa kontrol edilmesi çin kullanılır
            //await asenkronu tanımlamak için kullanılan bir yapı
            //jsontipine dönüştüreceğiz
            //content içerik contenti async şeklinde oku
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Hotels>>(jsonString);
            //jsondan .net e deserializable
            return View(values);           
        }
    }
}
