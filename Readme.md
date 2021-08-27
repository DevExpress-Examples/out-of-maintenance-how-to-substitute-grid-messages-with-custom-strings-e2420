<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653242/11.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2420)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomGridLocalizer.cs](./CS/CustomGridResourceText/CustomGridLocalizer.cs) (VB: [CustomGridLocalizer.vb](./VB/CustomGridResourceText/CustomGridLocalizer.vb))
* [MainWindow.xaml](./CS/CustomGridResourceText/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomGridResourceText/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomGridResourceText/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomGridResourceText/MainWindow.xaml.vb))
<!-- default file list end -->
# How to substitute grid messages with custom strings


<p>This example demonstrates how to change the DXGrid's default text messages, e.g. 'Drag a column header here to group by that column' or 'Click here to add a new row', with custom messages. Here, we create a GridControlResXLocalizer descendant and override the GetLocalizedString method.</p><p>The Localizer class instance is stored in the GridControlResXLocalizer.Active static property. All grids of an application use one and the same localizer. Said differently, if a default message text is changed via a custom localizer, it is changed for all grids in a given application.</p><p>This approach is good for changing just a few strings. For complete localization, please use satellite assemblies from <a href="https://www.devexpress.com/Support/Center/p/A421">The collection of localized DevExpress assemblies</a>.</p><p><strong>See Also:</strong><br />
<a href="http://documentation.devexpress.com/#WPF/CustomDocument7542">Localization Overview</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E2310">How to localize PivotGridControl via the PivotGridLocalizer class</a></p>

<br/>


