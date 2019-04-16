using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RimrockMVC
{
	public static class ApiClient
	{

		/// <summary>
		/// Get list of Regions as JObject
		/// </summary>
		/// <returns>JSON object containing list of all Regions in DB</returns>
		public static async Task<JObject> GetRegionsAsync()
		{

			//TODO Try to make Http client static instead of below approach


			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://rimrockapi.azurewebsites.net/api/");

				HttpResponseMessage response = await client.GetAsync("regions/");

				if (response.IsSuccessStatusCode)
				{
					return JObject.Parse(await response.Content.ReadAsStringAsync());
				}
				return null;
			}
		}

		/// <summary>
		/// Get individual Region as JObject
		/// </summary>
		/// <returns>JSON object containing specified Region</returns>
		public static async Task<JObject> GetRegionsAsync(int id)
		{

			//TODO Try to make Http client static instead of below approach


			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://rimrockapi.azurewebsites.net/api/");

				HttpResponseMessage response = await client.GetAsync($"regions/{id}");

				if (response.IsSuccessStatusCode)
				{
					return JObject.Parse(await response.Content.ReadAsStringAsync());
				}
				return null;
			}
		}
	}
}
