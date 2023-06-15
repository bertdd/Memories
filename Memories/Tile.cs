
namespace Memories;

public class Tile : ImageButton
{
  public Tile(string source, int row, int col, Color color)
  {
    Source = source;
    BackgroundColor = color;
    SetValue(Grid.RowProperty, row);
    SetValue(Grid.ColumnProperty, col);
    RotationY = 180;
    Opacity = 0;
  }

  public bool Flipped => RotationY != 180;
}
