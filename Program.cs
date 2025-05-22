int[] arr = { 30, 87, 21, 14, 99, 53, 6, 105, 20};
BST tree = new BST();
foreach (int i in arr)
{
    tree.InsertNode(i);
}
Node node = tree.Search(21);
if  (node != null)
{
    Console.WriteLine($"Found value: {node.Data}");
}
else
{
    Console.WriteLine("Value not found!");
}