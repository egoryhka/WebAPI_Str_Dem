using DiplomsClassLibrary.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using WebAPI_Client.Config;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Net;

namespace WebAPI_Client.Services
{
    public class DiplomCatalogService
    {
        private readonly IOptions<DiplomsWebApiConfig> _diplomsWebApiConfig;
        public DiplomCatalogService(IOptions<DiplomsWebApiConfig> diplomsWebApiConfig)
        {
            _diplomsWebApiConfig = diplomsWebApiConfig;
        }

        // Generic
        public async Task<IEnumerable<T>> GetAll<T>(string method)
        {
            using var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(1) };

            try
            {
                var response = await httpClient.GetAsync((string)_diplomsWebApiConfig.Value.Endpoint + method);
                var responseData = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = JsonConvert.DeserializeObject<IEnumerable<T>>(responseData);
                    return result;
                }
            }
            catch { }
            return null;
        }
        public async Task<T> GetItem<T>(string method, int id) where T : class
        {
            using var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(1) };

            try
            {
                var response = await httpClient.GetAsync((string)_diplomsWebApiConfig.Value.Endpoint + method + '/' + id);
                var responseData = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = JsonConvert.DeserializeObject<T>(responseData);
                    return result;
                }
            }
            catch { }
            return null;
        }
        public async Task<bool> RemoveItem<T>(string method, int id)
        {
            using var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(1) };

            try
            {
                var response = await httpClient.DeleteAsync((string)_diplomsWebApiConfig.Value.Endpoint + method + '/' + id);
                var responseData = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
            }
            catch { }
            return false;
        }
        public async Task<bool> AddItem<T>(string method, T item)
        {
            using var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(1) };

            try
            {
                var response = await httpClient.PutAsJsonAsync((string)_diplomsWebApiConfig.Value.Endpoint + method, item);
                var responseData = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
            }
            catch { }
            return false;
        }
        public async Task<bool> EditItem<T>(string method, T item) where T : IItem
        {
            using var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(1) };

            try
            {
                var response = await httpClient.PostAsJsonAsync((string)_diplomsWebApiConfig.Value.Endpoint + method + '/' + item.Id, item);
                var responseData = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
            }
            catch { }
            return false;
        }

        // No Generic
        public async Task<IEnumerable<Diplom>> GetDiploms() => await GetAll<Diplom>("Diplom");
        public async Task<IEnumerable<Author>> GetAuthors() => await GetAll<Author>("Author");
        public async Task<IEnumerable<Direction>> GetDirections() => await GetAll<Direction>("Direction");
        public async Task<IEnumerable<Position>> GetPositions() => await GetAll<Position>("Position");

        public async Task<Diplom> GetDiplom(int id) => await GetItem<Diplom>("Diplom", id);
        public async Task<Author> GetAuthor(int id) => await GetItem<Author>("Author", id);
        public async Task<Direction> GetDirection(int id) => await GetItem<Direction>("Direction", id);
        public async Task<Position> GetPosition(int id) => await GetItem<Position>("Position", id);

        public async Task<bool> AddDiplom(Diplom diplom) => await AddItem("Diplom", diplom);
        public async Task<bool> AddAuthor(Author author) => await AddItem("Author", author);
        public async Task<bool> AddDirection(Direction direction) => await AddItem("Direction", direction);
        public async Task<bool> AddPosition(Position position) => await AddItem("Position", position);

        public async Task<bool> EditDiplom(Diplom diplom) => await EditItem("Diplom", diplom);
        public async Task<bool> EditAuthor(Author author) => await EditItem("Author", author);
        public async Task<bool> EditDirection(Direction direction) => await EditItem("Direction", direction);
        public async Task<bool> EditPosition(Position position) => await EditItem("Position", position);

        public async Task<bool> RemoveDiplom(int id) => await RemoveItem<Diplom>("Diplom", id);
        public async Task<bool> RemoveAuthor(int id) => await RemoveItem<Author>("Author", id);
        public async Task<bool> RemoveDirection(int id) => await RemoveItem<Direction>("Direction", id);
        public async Task<bool> RemovePosition(int id) => await RemoveItem<Position>("Position", id);
    }
}
