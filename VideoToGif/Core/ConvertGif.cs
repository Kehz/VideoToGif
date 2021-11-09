using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
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
			string pd = Directory.GetCurrentDirectory();
			string pd2 = Path.GetDirectoryName(pd);
			string ffmpeg = Path.GetDirectoryName(pd2);
			string output = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
			var startInfo = new ProcessStartInfo
			{
				FileName = $@"{ffmpeg}\" + "ffmpeg.exe",
				Arguments = $"-i {filePath} -pix_fmt rgb24 -r 10 {fileName}.gif",
				WorkingDirectory = $@"{output}",
				UseShellExecute = false
			};
			using (var process = new Process { StartInfo = startInfo })
			{
				process.Start();
				process.WaitForExit();
			}
		}
	}
}
