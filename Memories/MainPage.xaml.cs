namespace Memories;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		for (int i = 0; i < Rows; i++)
		{
			grid.RowDefinitions.Add(new RowDefinition() { Height = BlockSize });
		}

		for (int i = 0; i < Columns; i++)
		{
			grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = BlockSize });
		}

		foreach (var tile in tiles)
		{
			grid.Children.Add(tile);
			tile.Clicked += ImageButton_Clicked;
		}
  }

  readonly Tile[] tiles = new Tile[]
	{
    new Tile("lionel.png", 0, 0, new Color(255, 255, 0)),
    new Tile("don.png", 3, 5, new Color(0, 255, 0)),
		new Tile("milan.png", 3, 4, new Color(0, 255, 255))
	};

  readonly Tile[,] board = new Tile[Rows, Columns];

  private void ImageButton_Clicked(object sender, EventArgs e)
  {
		var image = (ImageButton) sender;
		image.RotateYTo(180);
		image.FadeTo(0, 500);
  }

	const int BlockSize = 100;
	const int Rows = 4;
	const int Columns = 6;
}

