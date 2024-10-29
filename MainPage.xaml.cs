using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiAppWindowTest;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    private bool hasNoInternet;
    public bool HasNoInternet
    {
        get => hasNoInternet;
        set
        {
            hasNoInternet = value;
            OnPropertyChanged();
        }
    }

	public ObservableCollection<string> WindowsList { get; set; } = new ObservableCollection<string>();
	
	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
		UpdateWindowsList();
		
		// Add connectivity monitoring
		Connectivity.Current.ConnectivityChanged += Connectivity_ConnectivityChanged;
		// Check initial state
		HasNoInternet = Connectivity.Current.NetworkAccess != NetworkAccess.Internet;
	}

	private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
	{
		HasNoInternet = Connectivity.Current.NetworkAccess != NetworkAccess.Internet;
	}

	private async void RequestPermissionClicked(object sender, EventArgs e)
	{
		var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
		if (status != PermissionStatus.Granted)
		{
			status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
		}

		UpdateWindowsList();
	}

	private async void RequestCameraPermissionClicked(object sender, EventArgs e)
	{
		var status = await Permissions.CheckStatusAsync<Permissions.Camera>();
		if (status != PermissionStatus.Granted)
		{
			status = await Permissions.RequestAsync<Permissions.Camera>();
		}

		UpdateWindowsList();

		if (status == PermissionStatus.Granted)
		{
			await DisplayAlert("Permission Granted", "Camera permission has been granted.", "OK");
		}
	}

	private async void RequestNotificationPermissionClicked(object sender, EventArgs e)
	{
		if (DeviceInfo.Platform == DevicePlatform.Android && DeviceInfo.Version.Major >= 13)
		{
			var status = await Permissions.CheckStatusAsync<Permissions.PostNotifications>();
			if (status != PermissionStatus.Granted)
			{
				status = await Permissions.RequestAsync<Permissions.PostNotifications>();
			}

			UpdateWindowsList();

			if (status == PermissionStatus.Granted)
			{
				await DisplayAlert("Permission Granted", "Notification permission has been granted.", "OK");
			}
		}
		else
		{
			await DisplayAlert("Not Required", "Notification permission is not required for this device.", "OK");
		}
	}

	private void RefreshClicked(object sender, EventArgs e)
	{
		UpdateWindowsList();
	}

	private void UpdateWindowsList()
	{
		WindowsList.Clear();
		if (Application.Current?.Windows != null)
		{
			foreach (var window in Application.Current.Windows)
			{
				WindowsList.Add(window.GetType().ToString());
			}
		}
		OnPropertyChanged(nameof(WindowsList));
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		UpdateWindowsList();
	}

	// Don't forget to cleanup
	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		Connectivity.Current.ConnectivityChanged -= Connectivity_ConnectivityChanged;
	}
}
