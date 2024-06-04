public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if  (value == Data)
        {
            return;
        }
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        if (value == Data)
        {
            return true;
        }

        else if (value < Data)
        {
            if (Left == null)
            {
                return false;
            }

            else 
            {
                return Left.Contains(value);
            }
        }

        else 
        {
            if (Right == null)
            {
                return false;
            }

            else 
            {
                return Right.Contains(value);
            }
        }
    }

    public int GetHeight() {
        if (Left == null && Right == null)
        {
            return 1;
        }
        else if (Left == null)
        {
            return Right.GetHeight() + 1; 
        }
        else if (Right == null)
        {
            return Left.GetHeight() + 1; 
        }
        else
        {
            int leftHeight = Left.GetHeight();
            int rightHeight = Right.GetHeight();
            
            if (leftHeight > rightHeight)
            {
                return leftHeight + 1;
            }

            else 
            {
                return rightHeight + 1;
            }
        }
    }
}