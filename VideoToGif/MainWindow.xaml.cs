using Microsoft.Win32;
using System;
using System.Windows;
using VideoToGif.Core;


namespace VideoToGif
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		string filePath;
		string fileName;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void BtnPlayPause_Click(object sender, RoutedEventArgs e)
		{
			if (btnPlayPause.Content.ToString() == "Play")
			{
				MediaControls.mediaPlay(videoPreview);
				btnPlayPause.Content = "Pause";
			}
			else if (btnPlayPause.Content.ToString() == "Pause")
			{
				MediaControls.mediaPause(videoPreview);
				btnPlayPause.Content = "Play";
			}
		}

		private void BtnOpen_Click(object sender, RoutedEventArgs e)
		{
			String[] fileInfo;
			OpenFileDialog openFile = new OpenFileDialog();
			fileInfo = MediaControls.openFile(openFile);
			filePath = fileInfo[0];
			fileName = fileInfo[1];
			// MessageBox.Show(filePath + fileName);
			videoPreview.Source = new Uri(filePath);
		}

		private void Media_Opened(object sender, EventArgs e)
		{
			video_slider.Maximum = videoPreview.NaturalDuration.TimeSpan.TotalMilliseconds;
		}

		private void Media_Ended(object sender, EventArgs e)
		{
			MediaControls.mediaStop(videoPreview);
		}

		private void SeekMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> args)
		{
			MediaControls.mediaPause(videoPreview);
			int Slider = (int)video_slider.Value;
			TimeSpan ts = new TimeSpan(0, 0, 0, 0, Slider);
			videoPreview.Position = ts;
		}

		private void BtnConvert_Click(object sender, RoutedEventArgs e)
		{
			ConvertGif.ConvertToGif(filePath, fileName);
		}
	}
}
