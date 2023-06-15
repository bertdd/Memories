namespace Memories;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		for (int i = 0; i < 4; i++)
		{
			grid.RowDefinitions.Add(new RowDefinition() { Height = BlockSize });
		}

		for (int i = 0; i < 6; i++)
		{
			grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = BlockSize });
		}
	}

  private void ImageButton_Clicked(object sender, EventArgs e)
  {
		var image = (ImageButton) sender;
		image.RotateYTo(180);
		image.FadeTo(0, 500);
  }

	const int BlockSize = 100;
}

