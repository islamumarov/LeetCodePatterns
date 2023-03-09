namespace src;

public class Node
{
    public int data;
    public Node next;

    public Node(int data=0, Node next = null)
    {
        this.data = data;
        this.next = next;
    }
};