using System.Collections;

public class BinarySearchTree : IEnumerable<int>
{
    private class Node
    {
        public int Data;
        public Node? Left;
        public Node? Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public void Insert(int value)
        {
            if (value < Data)
            {
                if (Left == null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else if (value > Data)
            {
                if (Right == null)
                    Right = new Node(value);
                else
                Right.Insert(value);
            }
            //If value == Data, do nothing (no duplicates allowed)
        }

        public bool Contains(int value)
        {
            if (value == Data)        
                return true;
            else if (value < Data)
                return Left?.Contains(value) ?? false;
            else
                return Right?.Contains(value) ?? false;
            
        }

        public int GetHeight()
        {
            int leftHeight = Left?.GetHeight() ?? 0;
            int rightHeight = Right?.GetHeight() ?? 0;
            return 1 + Math.Max(leftHeight, rightHeight);
        }
    }
    private Node? _root;

    /// <summary>
    /// Insert a new node in the BST.
    /// </summary>
    public void Insert(int value)
    {        
        // If the list is empty, then point both head and tail to the new node.
        if (_root == null)
            _root = new Node(value);
        // If the list is not empty, then only head will be affected.
        else
            _root.Insert(value);
    }

    /// <summary>
    /// Check to see if the tree contains a certain value
    /// </summary>
    /// <param name="value">The value to look for</param>
    /// <returns>true if found, otherwise false</returns>
    public bool Contains(int value)
    {
        return _root != null && _root.Contains(value);
    }

    /// <summary>
    /// Yields all values in the tree
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        // call the generic version of the method
        return GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the BST
    /// </summary>
    public IEnumerator<int> GetEnumerator()
    {
        var numbers = new List<int>();
        TraverseForward(_root, numbers);
        foreach (var number in numbers)
        {
            yield return number;
        }
    }

    private void TraverseForward(Node? node, List<int> values)
    {
        if (node != null)
        {
            TraverseForward(node.Left, values);
            values.Add(node.Data);
            TraverseForward(node.Right, values);
        }
    }

    /// <summary>
    /// Iterate backward through the BST.
    /// </summary>
    public IEnumerable Reverse()
    {
        var numbers = new List<int>();
        TraverseBackward(_root, numbers);
        foreach (var number in numbers)
        {
            yield return number;
        }
    }

    private void TraverseBackward(Node? node, List<int> values)
    {
        // TODO Problem 3
    }

    /// <summary>
    /// Get the height of the tree
    /// </summary>
    public int GetHeight()
    {
        if (_root is null)
            return 0;
        return _root.GetHeight();
    }

    public override string ToString()
    {
        return "<Bst>{" + string.Join(", ", this) + "}";
    }
}