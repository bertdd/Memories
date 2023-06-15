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

		foreach (var tile in board.Tiles)
		{
			grid.Children.Add(tile);
			tile.Clicked += ImageButton_Clicked;
    }
  }

  private void ImageButton_Clicked(object sender, EventArgs e)
  {
		var tile = (Tile) sender;

		if (tile.Flipped)
		{
			tile.RotateYTo(180);
			tile.FadeTo(0, 500);
		}
		else
		{
      tile.RotateYTo(0);
      tile.FadeTo(1.0, 500);
    }
  }

	const int BlockSize = 100;
	const int Rows = 4;
	const int Columns = 6;

	Board board = new Board(Rows, Columns);
}

