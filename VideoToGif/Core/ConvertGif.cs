using System;
using System.Diagnostics;
using System.Windows;

namespace VideoToGif.Core
{
	class ConvertGif
	{
		public static void ConvertToGif(String filePath, String fileName)
		{
			ExecuteConvert(filePath, fileName);
		}

		public static void TrimConverToGif(string path, int startTime, int endTime)
		{
			return;
		}

		public static void ExecuteConvert(String filePath, String fileName)
		{
			var startInfo = new ProcessStartInfo
			{
				FileName = @"P:\Projects\VideoToGif\VideoToGif\FFMPEG\ffmpeg.exe",
				Arguments = $"-i {filePath} -pix_fmt rgb24 -r 10 {fileName}.gif",
				WorkingDirectory = @"P:\Projects\VideoToGif\VideoToGif\Media",
				UseShellExecute = false,

			};
			using (var process = new Process { StartInfo = startInfo })
			{
				process.Start();
				process.WaitForExit();
			}
		}
	}
}
