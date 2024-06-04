namespace LegendItemsLayout
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("default", typeof(Default));
            Routing.RegisterRoute("page1", typeof(FlexLayout));
            Routing.RegisterRoute("page2", typeof(MainPage));
            Routing.RegisterRoute("page3", typeof(VerticalStackLayouts));
            Routing.RegisterRoute("page4", typeof(UniformItems));
        }
    }
}
