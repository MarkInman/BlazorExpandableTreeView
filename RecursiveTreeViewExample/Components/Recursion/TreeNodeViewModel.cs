namespace RecursiveTreeViewExample.Components.Recursion;

public class TreeNodeViewModel
{
    public int TreeNodeId { get; set; }
    public string LinkText { get; set; } = string.Empty;
    public List<TreeNodeViewModel> Nodes { get; set; } = new List<TreeNodeViewModel>();
}
