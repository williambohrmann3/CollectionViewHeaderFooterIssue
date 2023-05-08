using System.Collections.ObjectModel;

namespace CollectionViewHeaderFooterIssue;

public partial class MainPage : ContentPage
{
	// On Windows, header and footer not showing. Notice on Android for example, this is not the case.
	public MainPage()
	{
		InitializeComponent();
		var liveMusic = new ObservableCollection<Concert>();
		liveMusic.Add(new Concert("Flume", "Red Rocks"));
		liveMusic.Add(new Concert("Drake", "Kia Forum"));
		Concerts.ItemsSource = liveMusic;
	}

	public class Concert
	{
		public string Artist { get; private set; }
		public string Venue { get; private set; }

		public Concert(string artist, string venue) 
		{ 
			Artist = artist;
			Venue = venue;
		}

	}
}

