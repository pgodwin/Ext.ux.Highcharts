<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ColumnChart.aspx.cs" Inherits="Ext.ux.Highcharts.Demo.ColumnChart" %>
<%@ Register TagPrefix="a" Namespace="Ext.ux.Highcharts" Assembly="Ext.ux.Highcharts" %>
<%@ Register TagPrefix="a" Namespace="Ext.ux.Highcharts.Series" Assembly="Ext.ux.Highcharts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ext:ResourceManager runat="server" SourceFormatting="true" />
        <ext:Panel runat="server" Height="500" Width="800" Layout="FitLayout">
            <Items>
                <a:HighChart runat="server" ID="Test" StateID="storeTest" YField="Value">
                    <Series>
                        <a:ColumnSerie runat="server" DataIndex="Name" />
                    </Series>
                    <ChartConfig>
                        <a:ChartConfig runat="server">
                            <Chart runat="server" Type="bar" />
                            <Title runat="server" Text="Test" />
                        </a:ChartConfig>
                    </ChartConfig>
                </a:HighChart>
            </Items>
        </ext:Panel>
         <ext:Store runat="server" ID="storeTest">
            <Model>
                <ext:Model runat="server">
                    <Fields>
                        <ext:ModelField Name="Name" />
                        <ext:ModelField Name="Value" Type="Float" />
                    </Fields>
                </ext:Model>
            </Model>
        </ext:Store>
    </div>
    </form>
</body>
</html>
