using Syncfusion.Maui.Charts;
using System;
using System.Collections;
using System.Collections.Generic;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Layouts;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;
using CommunityToolkit.Maui.Layouts;

namespace LegendItemsLayout;

public partial class UniformItems : ContentPage
{
	public UniformItems()
	{
		InitializeComponent();
	}
}

public class LegendExt1 : ChartLegend
{
    protected override double GetMaximumSizeCoefficient()
    {
        return 1;
    }
}

public class UniformLayouts : UniformItemsLayout
{

}
