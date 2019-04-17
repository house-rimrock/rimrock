using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RimrockMVC.Models.APImodels;
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
		/// Gets a list of Regions
		/// </summary>
		/// <returns>JSON object containing list of all Regions in DB</returns>
		public static async Task<List<Region>> GetRegionsAsync()
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://rimrockapi.azurewebsites.net/api/");

				HttpResponseMessage response = await client.GetAsync("region/");

				if (response.IsSuccessStatusCode)
				{
					var responseAsString = await response.Content.ReadAsStringAsync();

					// List<Region> is return type of API-side GET method for getting an individual Region object
					List<Region> parsedRegions = JsonConvert.DeserializeObject<List<Region>>(responseAsString);

					return parsedRegions;
				}
				return null;
			}
		}

		/// <summary>
		/// Gets an individual Region
		/// </summary>
		/// <returns>JSON object containing specified Region</returns>
		public static async Task<JObject> GetRegionsAsync(int id)
		{
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
