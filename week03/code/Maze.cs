public class Maze
{
    private readonly Dictionary<(int, int), bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<(int, int), bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    /// <summary>
    /// Check to see if you can move left. If you can, then move. If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveLeft()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out var movements) && movements[0])
        {
            _currY--;
            Console.WriteLine($"Moved left. Current location (x={_currX}, y={_currY})");
        }
        else
        {
            Console.WriteLine("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move right. If you can, then move. If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveRight()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out var movements) && movements[1])
        {
            _currY++;
            Console.WriteLine($"Moved right. Current location (x={_currX}, y={_currY})");
        }
        else
        {
            Console.WriteLine("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move up. If you can, then move. If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveUp()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out var movements) && movements[2])
        {
            _currX--;
            Console.WriteLine($"Moved up. Current location (x={_currX}, y={_currY})");
        }
        else
        {
            Console.WriteLine("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move down. If you can, then move. If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveDown()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out var movements) && movements[3])
        {
            _currX++;
            Console.WriteLine($"Moved down. Current location (x={_currX}, y={_currY})");
        }
        else
        {
            Console.WriteLine("Can't go that way!");
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}
