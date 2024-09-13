using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace BXM308_Assignment.Model
{
    public class AppPreferences
    {
        public static async Task<string> GetString(string key, string defaultValue = "")
        {
            var result =await SecureStorage.GetAsync(key);

            if (string.IsNullOrEmpty(result))
                return null;
           
            return result;
        }

        public static async Task SetString(string key, string value)
        {
            await SecureStorage.SetAsync(key, value);
        }
    }
}
