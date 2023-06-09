namespace GridBugsiOS;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		collection.ItemsSource = Enumerable.Range(0, 250).ToList();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		collection.IsVisible = !collection.IsVisible;
    }

    void Button_Clicked2(System.Object sender, System.EventArgs e)
    {
        grid.RowSpacing = grid.RowSpacing != 0 ? 0 : 8;
    }
}


