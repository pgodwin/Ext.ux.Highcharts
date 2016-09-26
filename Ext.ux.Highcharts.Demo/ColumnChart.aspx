<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ColumnChart.aspx.cs" Inherits="Ext.ux.Highcharts.Demo.ColumnChart" %>
<%@ Register TagPrefix="a" Namespace="Ext.ux.Highcharts" Assembly="Ext.ux.Highcharts" %>
<%@ Register TagPrefix="a" Namespace="Ext.ux.Highcharts.ChartSeries" Assembly="Ext.ux.Highcharts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ext:ResourceManager runat="server" SourceFormatting="true" ScriptMode="Debug">
            <ResourceItems>
                <ext:ClientResourceItem Path="http://ajax.googleapis.com/ajax/libs/jquery/1.10.1/jquery.min.js" />
            </ResourceItems>
        </ext:ResourceManager>
        
      
        <ext:Panel runat="server" Height="500" Width="800" Layout="FitLayout">
            <Items>
                <a:HighChart runat="server" ID="Test" XField="Name">
                    <Store>
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
                    </Store>
                    <Series>
                        <a:Bar runat="server" DataIndex="Value" />
                    </Series>
                    <ChartConfig runat="server">
                        <Chart runat="server" ShowAxes="true" Type="bar" >
                            <Listeners>
                                <Click Handler="console.log(event);" />
                            </Listeners>
                        </Chart>
                        <Title runat="server" Text="Test Chart Test" />
                    </ChartConfig>
                </a:HighChart>
            </Items>
        </ext:Panel>
         
    </div>
    </form>
</body>
</html>
