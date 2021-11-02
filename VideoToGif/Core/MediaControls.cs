using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

		public static void openFile(OpenFileDialog f)
		{
			f.Multiselect = false;
			f.Filter = "MP4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
			f.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
			if (f.ShowDialog() == true)
			{
				foreach (string filename in f.FileNames)
				{
					
				}
			}
		}
	}
}