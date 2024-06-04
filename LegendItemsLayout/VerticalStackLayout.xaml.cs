using Microsoft.Maui.Layouts;

namespace LegendItemsLayout;

public partial class VerticalStackLayouts : ContentPage
{
	public VerticalStackLayouts()
	{
		InitializeComponent();
	}
}

public class ColumnLayout : VerticalStackLayout
{
    protected override ILayoutManager CreateLayoutManager()
    {
        return new ColumnLayoutManager(this);
    }
}

public class ColumnLayoutManager : ILayoutManager
{
    readonly ColumnLayout _columnLayout;
    IGridLayout? _gridLayout;
    GridLayoutManager? _manager;

    public ColumnLayoutManager(ColumnLayout layout)
    {
        _columnLayout = layout;
    }


    IGridLayout ToColumnGrid(VerticalStackLayout stackLayout)
    {
        Grid grid = new LayoutGrid
        {
            ColumnDefinitions = new ColumnDefinitionCollection { new ColumnDefinition { Width = GridLength.Star } },
            RowDefinitions = new RowDefinitionCollection()
        };

        stackLayout.VerticalOptions = LayoutOptions.Start;

        for (int n = 0; n < stackLayout.Count; n++)
        {
            var child = stackLayout[n];
            grid.RowDefinitions.Add(new RowDefinition { Height = 30 });
            grid.Add(child);
            grid.SetRow(child, n);
        }

        return grid;
    }

    public Size Measure(double widthConstraint, double heightConstraint)
    {
        _gridLayout?.Clear();
        _gridLayout = ToColumnGrid(_columnLayout);
        _manager = new GridLayoutManager(_gridLayout);

        return _manager.Measure(widthConstraint, heightConstraint);
    }

    public Size ArrangeChildren(Rect bounds)
    {
        return _manager?.ArrangeChildren(bounds) ?? Size.Zero;
    }
}

class LayoutGrid : Grid
{
    protected override void OnChildAdded(Element child)
    {
        // We don't want to actually re-parent the stuff we add to this			
    }

    protected override void OnChildRemoved(Element child, int oldLogicalIndex)
    {
        // Don't do anything here; the base methods will null out Parents, etc., and we don't want that
    }
}