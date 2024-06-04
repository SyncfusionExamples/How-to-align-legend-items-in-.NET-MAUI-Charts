using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using Syncfusion.Maui.Charts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendItemsLayout
{
    public class LineSeriesViewModel
    {
        public ObservableCollection<Brush> PaletteBrushes { get; set; }
        public ObservableCollection<ChartDataModel> LineData1 { get; set; }

        public ObservableCollection<ChartDataModel> LineData2 { get; set; }

        public ObservableCollection<ChartDataModel> DashedLine { get; set; }
        public ObservableCollection<ChartDataModel> GroupToData { get; set; }
        public ObservableCollection<ChartDataModel> RevenueData { get; set; }

        public LineSeriesViewModel()
        {

            PaletteBrushes = new ObservableCollection<Brush>()
            {
               new SolidColorBrush(Color.FromArgb("#314A6E")),
                 new SolidColorBrush(Color.FromArgb("#48988B")),
                 new SolidColorBrush(Color.FromArgb("#5E498C")),
                 new SolidColorBrush(Color.FromArgb("#74BD6F")),
                 new SolidColorBrush(Color.FromArgb("#597FCA"))
            };

            GroupToData = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel( "US",22.90,0.244),
                new ChartDataModel("China",16.90,0.179),
                new ChartDataModel( "Japan",5.10,0.054),
                new ChartDataModel("Germany",4.20,0.045),
                new ChartDataModel("UK",3.10,0.033),
                new ChartDataModel("India",2.90,0.031),
                new ChartDataModel("France",2.90,0.031),
                new ChartDataModel( "Italy",2.10,0.023),
                new ChartDataModel( "Canada",2.00,0.021),
                new ChartDataModel( "Korea",1.80,0.019),
                new ChartDataModel("Russia",1.60,0.017),
                new ChartDataModel("Brazil",1.60,0.017),
                new ChartDataModel("Australia",1.60,0.017),
                new ChartDataModel("Spain",1.40,0.015),
                new ChartDataModel("Mexico",1.30,0.014),
                new ChartDataModel("Indonesia",1.20,0.012),
                new ChartDataModel("Iran",1.10,0.011),
                new ChartDataModel("Netherlands",1.00,0.011),
                new ChartDataModel("Saudi Arabia",0.80,0.009),
                new ChartDataModel("Switzerland",0.80,0.009),
                new ChartDataModel("Turkey",0.80,0.008),
                new ChartDataModel("Taiwan",0.80,0.008),
                new ChartDataModel("Poland",0.70,0.007),
                new ChartDataModel("Sweden",0.60,0.007),
                new ChartDataModel("Belgium",0.60,0.006),
                new ChartDataModel("Thailand",0.50,0.006),
                new ChartDataModel("Ireland",0.50,0.005),
                new ChartDataModel("Austria",0.50,0.005),
                new ChartDataModel("Nigeria",0.50,0.005),
                new ChartDataModel("Israel",0.50,0.005),
                new ChartDataModel("Argentina",0.50,0.005),
                //new ChartDataModel("Norway",0.40,0.005),
                //new ChartDataModel("South Africa",0.40,0.004),
                //new ChartDataModel("UAE",0.40,0.004),
                //new ChartDataModel("Denmark",0.40,0.004),
                //new ChartDataModel("Egypt",0.40,0.004),
                //new ChartDataModel("Philippines",0.40,0.004),
                //new ChartDataModel("Singapore",0.40,0.004),
                //new ChartDataModel("Malaysia",0.40,0.004),
                //new ChartDataModel("Hong Kong SAR",0.40,0.004),
                //new ChartDataModel("Vietnam",0.40,0.004),
                //new ChartDataModel("Bangladesh",0.40,0.004),
                //new ChartDataModel("Chile",0.30,0.004),
                //new ChartDataModel("Colombia",0.30,0.003),
                //new ChartDataModel("Finland",0.30,0.003),
                //new ChartDataModel("Romania",0.30,0.003),
                //new ChartDataModel("Czech Republic",0.30,0.003),
                //new ChartDataModel("Portugal",0.30,0.003),
                //new ChartDataModel("Pakistan",0.30,0.003),
                //new ChartDataModel("New Zealand",0.20,0.003),
            };

            RevenueData = new ObservableCollection<ChartDataModel>()
            {
                new ChartDataModel("2010", 13.767,7.726,22.769),
                new ChartDataModel("2011", 15.471,8.206,22.790),
                new ChartDataModel("2012", 18.097,9.057,24.170),
                new ChartDataModel("2013", 18.056,8.946,22.795),
                new ChartDataModel("2014", 17.739,9.164,21.533),
#if !IOS && !ANDROID
                new ChartDataModel("2015", 20.074,10.159,23.039),
                new ChartDataModel("2016", 20.172,10.009,22.532),
                new ChartDataModel("2017", 20.697,10.574,22.444),
#endif
            };


            LineData1 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("2005", 21),
                new ChartDataModel("2006", 24),
                new ChartDataModel("2007", 36),
                new ChartDataModel("2008", 38),
                new ChartDataModel("2009", 54),
                new ChartDataModel("2010", 57),
                new ChartDataModel("2011", 70)
            };

            LineData2 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("2005", 28),
                new ChartDataModel("2006", 44),
                new ChartDataModel("2007", 48),
                new ChartDataModel("2008", 50),
                new ChartDataModel("2009", 66),
                new ChartDataModel("2010", 78),
                new ChartDataModel("2011", 84)
            };

            DashedLine = new ObservableCollection<ChartDataModel>()
            {
                new ChartDataModel(2010, 6.6, 9.0, 15.1, 18.8),
                new ChartDataModel(2011, 6.3, 9.3, 15.5, 18.5),
                new ChartDataModel(2012, 6.7, 10.2, 14.5, 17.6),
                new ChartDataModel(2013, 6.7, 10.2, 13.9, 16.1),
                new ChartDataModel(2014, 6.4, 10.9, 13, 17.2),
                new ChartDataModel(2015, 6.8, 9.3, 13.4, 18.9),
                new ChartDataModel(2016, 7.7, 10.1, 14.2, 19.4),
            };
        }
    }

    public class StringFormatConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value != null && value is ChartDataModel model)
            {
                if (parameter is DoughnutSeries series)
                {
                    switch (series.GroupMode)
                    {
                        case PieGroupMode.Percentage:
                            return string.Format("{0:P0}", model.Size);
                        default:
                            return string.Format("${0:F2} T", model.Value);
                    }
                }
            }

            return "";
        }


        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value;
        }


    }

    public class ChartColorModel : ObservableCollection<Brush>
    {

    }
}
