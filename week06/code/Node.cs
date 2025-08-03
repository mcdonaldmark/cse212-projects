public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // Do not insert duplicate values
        if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            // Check left subtree if it exists
            if (Left == null)
                return false;
            return Left.Contains(value);
        }
        else // value > Data
        {
            // Check right subtree if it exists
            if (Right == null)
                return false;
            return Right.Contains(value);
        }
    }


    public int GetHeight()
    {
        int leftH = Left != null ? Left.GetHeight() : 0;
        int rightH = Right != null ? Right.GetHeight() : 0;
        return 1 + Math.Max(leftH, rightH);
    }
}