using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VideoToGif.Core;

namespace VideoToGif
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		void BtnPlayPause_Click(object sender, RoutedEventArgs e)
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

		void BtnOpen_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			MediaControls.openFile(openFile);
		}

		void BtnConvert_Click(object sender, RoutedEventArgs e)
		{

		}

	}
}
