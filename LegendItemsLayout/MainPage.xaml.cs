using Syncfusion.Maui.Charts;

namespace LegendItemsLayout
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
      
    }

    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
                return 1;
        }
    }

}
