# How to align legend items in .NET-MAUI Charts
This sample demonstrates How to align the chart legend items in [.NET MAUI Circular Chart](https://www.syncfusion.com/maui-controls/maui-circular-charts).

## Chart Legend:
The legend provides information about the data point displayed in the chart. The Legend property of the chart was used to enable it.

Additionally, set label for each series using the Label property of chart series, which will be displayed in corresponding legend.

## Chart legend visibility
Using [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_IsVisible) property, display or hide the legend items.

## ToggleSeriesVisibility
Using [ToggleSeriesVisiblity](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ToggleSeriesVisibility) property, indicate whether the chart series visibility by tapping the legend item.

## ItemsTemplate
Using [ItemsTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ItemTemplate) property, customize the legend items appearance.

## ItemsLayout
Using ItemsLayout property, align legend items in various ways, such as horizontally, vertically, in a grid, or in a custom arrangement.

## Legend maximum size request
To set the maximum size request for the legend view, override the GetMaximumSizeCoefficient protected method in ChartLegend class. The value should be between 0 and 1, representing the maximum size request, not the desired size for the legend items layout.

## Output

![KB_Legend-Items](https://github.com/SyncfusionExamples/How-to-align-legend-items-in-.NET-MAUI-Charts/assets/105482474/67a13117-259f-46db-8efd-04cd633a1dce)

For more detail, refer this article [link](https://support.syncfusion.com/kb/article/16201/how-to-align-the-chart-legend-items-in-net-maui-circular-chart).
