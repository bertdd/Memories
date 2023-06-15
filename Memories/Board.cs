namespace Memories;

internal class Board
{
  internal Board(int rows, int columns)
  {
    board = new Tile[rows, columns];
  }

  internal readonly Tile[] Tiles = new Tile[]
  {
    new Tile("lionel.png", 0, 0, new Color(255, 255, 0)),
    new Tile("don.png", 3, 5, new Color(0, 255, 0)),
    new Tile("milan.png", 3, 4, new Color(0, 255, 255))
  };

  readonly Tile[,] board;
}
