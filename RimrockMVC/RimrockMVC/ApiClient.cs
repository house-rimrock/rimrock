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
        private static readonly string url = "https://rimrockapi.azurewebsites.net/api/";

		/// <summary>
		/// Gets a list of Regions from the API.
		/// </summary>
		/// <returns>A list of Regions</returns>
		public static async Task<List<Region>> GetRegionsAsync()
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri(url);

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
		/// Gets an individual Region from the API.
		/// </summary>
        /// <param name="id">The Region's ID.</param>
		/// <returns>A Region</returns>
		public static async Task<Region> GetRegionsAsync(int id)
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri(url);

				HttpResponseMessage response = await client.GetAsync($"region/{id}");

				if (response.IsSuccessStatusCode)
				{
                    var responseString = await response.Content.ReadAsStringAsync();
                    Region parsedRegion = JsonConvert.DeserializeObject<Region>(responseString);
                    return parsedRegion;
				}
				return null;
			}
		}

        /// <summary>
        /// Gets a list of Locations from the API.
        /// </summary>
        /// <returns>A list of Locations</returns>
        public static async Task<List<Location>> GetLocationsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                HttpResponseMessage response = await client.GetAsync("location/");

                if (response.IsSuccessStatusCode)
                {
                    var responseAsString = await response.Content.ReadAsStringAsync();

					// List<Location> is return type of API-side GET method for getting an individual Location object
					List<Location> parsedRegions = JsonConvert.DeserializeObject<List<Location>>(responseAsString);

                    return parsedRegions;
                }
                return null;
            }
        }

        /// <summary>
        /// Gets a single Location from the API.
        /// </summary>
        /// <param name="id">The location's ID.</param>
        /// <returns>A Location.</returns>
        public static async Task<Location> GetLocationsAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                HttpResponseMessage response = await client.GetAsync($"location/{id}");

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    Location location = JsonConvert.DeserializeObject<Location>(responseString);
                    return location;
                }
                return null;
            }
        }

		/// <summary>
		/// Gets list of locations with foreign key of the specified region ID
		/// </summary>
		/// <param name="regionId">ID of region to get locations for</param>
		/// <returns>List of locations</returns>
		public static async Task<List<Location>> GetLocationsByRegionAsync(int regionId)
        {
            List<Location> allLocations = await GetLocationsAsync();
            try
            {
                return allLocations.Where(l => l.RegionID == regionId).ToList();
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

		/// <summary>
		/// Gets list of all retailers from database
		/// </summary>
		/// <returns>List of all retailers</returns>
        public static async Task<List<Retailer>> GetRetailersAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                HttpResponseMessage response = await client.GetAsync("retailer/");

                if (response.IsSuccessStatusCode)
                {
                    var responseAsString = await response.Content.ReadAsStringAsync();

					// List<Retailer> is return type of API-side GET method for getting an individual Retailer object
					List<Retailer> parsedRegions = JsonConvert.DeserializeObject<List<Retailer>>(responseAsString);

                    return parsedRegions;
                }
                return null;
            }
        }

		/// <summary>
		/// Gets retailer with specified ID 
		/// </summary>
		/// <param name="id">ID of retailer in database</param>
		/// <returns>Retailer object from database</returns>
        public static async Task<Retailer> GetRetailersAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                HttpResponseMessage response = await client.GetAsync($"retailer/{id}");

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    Retailer retailer = JsonConvert.DeserializeObject<Retailer>(responseString);
                    return retailer;
                }
                return null;
            }
        }

		/// <summary>
		/// Gets list of all retailers with foreign key of specified region ID
		/// </summary>
		/// <param name="regionId">ID of region to get retailers for</param>
		/// <returns>List of retailers matching specified region ID</returns>
        public static async Task<List<Retailer>> GetRetailersByRegionAsync(int regionId)
        {
            List<Retailer> allRetailers = await GetRetailersAsync();
            try
            {
                return allRetailers.Where(r => r.RegionID == regionId).ToList();
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }
	}
}
