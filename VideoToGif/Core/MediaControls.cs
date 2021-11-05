using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Controls;

namespace VideoToGif.Core
{
	class MediaControls : MainWindow
	{
		public static void mediaPlay(MediaElement m)
		{
			m.Play();
		}

		public static void mediaPause(MediaElement m)
		{
			m.Pause();
		}

		public static void mediaStop(MediaElement m)
		{
			m.Stop();
		}
		public static string[] openFile(OpenFileDialog f)
		{
			string filePath = "";
			string fileName = "";
			f.Multiselect = false;
			f.Filter = "MP4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
			f.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
			if (f.ShowDialog() == true)
			{
				foreach (string filename in f.FileNames)
				{
					filePath= f.FileName;
					fileName = Path.GetFileNameWithoutExtension(filePath);
				}
			}
			return new string[]{filePath, fileName};
		}

	}
}