﻿using ApiProjeKampi.WEBUI.Dtos.ChefDtos;
using ApiProjeKampi.WEBUI.Dtos.EventDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiProjeKampi.WEBUI.ViewComponents
{
    public class _ChefDefaultComponentPartial :ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _ChefDefaultComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7173/api/Chefs/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultChefDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
