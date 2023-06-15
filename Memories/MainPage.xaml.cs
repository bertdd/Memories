namespace Memories;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

  private void ImageButton_Clicked(object sender, EventArgs e)
  {
		var image = (ImageButton) sender;
		image.RotateYTo(180);
		image.FadeTo(0, 500);
  }
}

