using UnityEngine;

public class Maze
{
    internal MazeGeneratorCell[,] cells;
    internal Vector2Int finishPosition;
}

public class MazeGeneratorCell
{
    internal int X;
    internal int Y;

    internal bool WallLeft = true;
    internal bool WallBottom = true;

    internal bool Visited = false;
    internal int DistanceFromStart;
}
