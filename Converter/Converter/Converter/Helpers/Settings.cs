// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using Newtonsoft.Json;
using System.Collections.Generic;
using Converter.ViewModels;
using System.Collections.ObjectModel;

namespace Converter.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Settings
	{
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

        #region Setting Constants

	    private const string myIntListKey = "myintlist_key";

        #endregion


        public static ObservableCollection <ItemsDetail> myIntList
	    {
	        get
	        {
	            string value = AppSettings.GetValueOrDefault(myIntListKey, string.Empty);
	            ObservableCollection<ItemsDetail> myList;
	            if (string.IsNullOrEmpty(value))
	                myList = new ObservableCollection<ItemsDetail>();
	            else
	                myList = JsonConvert.DeserializeObject<ObservableCollection<ItemsDetail>>(value);
                
	            return myList;
	        }
	        set
	        {
	            string listValue = JsonConvert.SerializeObject(value);
	            AppSettings.AddOrUpdateValue(myIntListKey, listValue);
	        }
	    }

    }
}