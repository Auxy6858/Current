using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace WaterWheel
{
	

	public class GameSettings {

		public int DisplayWidth { get; set; }
		public int DisplayHeight { get; set; }

		public bool FullScreen { get; set; }

		public static void SettingsSet()
		{
			var settings = new GameSettings()
			{
				DisplayHeight = 1080,
				DisplayWidth = 1920,
				FullScreen = true
			};
			string FileName = "Settings.json";
			string JsonString = JsonSerializer.Serialize(settings);
			File.WriteAllText(FileName, JsonString);
		}

	}



	
}
