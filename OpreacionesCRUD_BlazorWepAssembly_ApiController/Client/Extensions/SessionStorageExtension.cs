using Blazored.SessionStorage;
using System.Text;
using System.Text.Json;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Client.Extensions
{
    public static class SessionStorageExtension
    {
        public static async Task SaveItemEncryptedAsync<T>(this ISessionStorageService sessionStorageServices, string key, T item)
        {
            //crea una cadena json apartir del objeto usando JsonSerializar
            var itemJson = JsonSerializer.Serialize(item);
            var itemJsonBytes = Encoding.UTF8.GetBytes(itemJson);//CONVERTIR el Json en Bytes
            var base64Json = Convert.ToBase64String(itemJsonBytes);//luego a base 64
            await sessionStorageServices.SetItemAsync(key, base64Json);

        }
        public static async Task<T> ReadEncryptedItemAsync<T>(this ISessionStorageService sessionStorageService, string key)
        {
            var base64Json = await sessionStorageService.GetItemAsync<string>(key);
            var itemJsonBytes = Convert.FromBase64String(base64Json);
            var itemJson = Encoding.UTF8.GetString(itemJsonBytes);
            var item = JsonSerializer.Deserialize<T>(itemJson);
            return item;
        }
    }
}
