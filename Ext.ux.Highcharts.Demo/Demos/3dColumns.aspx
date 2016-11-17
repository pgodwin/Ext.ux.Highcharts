<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3dColumns.aspx.cs" Inherits="Ext.ux.Highcharts.Demo.Demos._3dColumns" %>
<%@ Register TagPrefix="a" Namespace="Ext.ux.Highcharts" Assembly="Ext.ux.Highcharts" %>
<%@ Register TagPrefix="a" Namespace="Ext.ux.Highcharts.ChartSeries" Assembly="Ext.ux.Highcharts" %>
<%@ Register TagPrefix="a1" Namespace="Ext.ux.Highcharts.Chart" Assembly="Ext.ux.Highcharts" %>
<%@ Register TagPrefix="a" Namespace="Ext.ux.Highcharts.Chart" Assembly="Ext.ux.Highcharts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager runat="server" SourceFormatting="true" ScriptMode="Debug">
            <ResourceItems>
                <ext:ClientResourceItem Path="http://ajax.googleapis.com/ajax/libs/jquery/1.10.1/jquery.min.js" />
            </ResourceItems>
        </ext:ResourceManager>
        
      
        <ext:Panel runat="server" Height="500" Width="800" Layout="FitLayout">
            <TopBar>
                <ext:Toolbar runat="server">
                    <Items>
                        <ext:Button runat="server" Text="Reload" OnClientClick="#{StoreTemperature}.reload();" />
                    </Items>
                </ext:Toolbar>
            </TopBar>
            <Items>
                <a:HighChart runat="server" ID="Test" XField="Time">
                    <Store>
                        <ext:Store runat="server" ID="StoreTemperature" OnReadData="LoadTemperatures">
                            <Proxy>
                                <ext:PageProxy />
                            </Proxy>
                            <Model>
                                <ext:Model runat="server">
                                    <Fields>
                                        <ext:ModelField Name="time" />
                                        <ext:ModelField Name="yesterday" Type="float" />
                                        <ext:ModelField Name="today" Type="float" />
                                    </Fields>
                                </ext:Model>
                            </Model>
                        </ext:Store>
                    </Store>
                    <Series>
                        <a:ColumnSeries runat="server" DataIndex="yesterday" Name="Yesterday" Depth="25" />
                        <a:ColumnSeries runat="server" DataIndex="today" Name="Today" Depth="25" />
                    </Series>
                    <ChartConfig runat="server">
                        <Chart 
                            runat="server" 
                            ShowAxes="true"
                            MarginRight="130"
                            MarginBottom="120"
                            ZoomType="x"
                            Type="column" >
                            <Options3d
                                runat="server"
                                Enabled ="true"
                                Alpha="15"
                                Beta="15"
                                Depth="15" />
                        </Chart>
                        <Title runat="server" Text="Test Chart" x="-20" />
                        <Subtitle runat="server" Text="Click 'Reload Data' to see the 3D Columns animate" />
<%--                        <PlotOptions runat="server">
                            <Column runat="server" Depth="25" />
                        </PlotOptions>--%>
                        <XAxis>
                            <a1:XAxis runat="server">
                                <Title Text="Time" Margin="20" />
                            </a1:XAxis>
                        </XAxis>
                        <YAxis>
                            <a1:YAxis runat="server">
                                <Title runat="server" Text="Temperature" />
                            </a1:YAxis>
                        </YAxis>
                        <Legend 
                            runat="server"
                             Layout="vertical"
                             Align="right"
                             VerticalAlign="top"
                            x="-10"
                            y="100"
                            BorderWidth="0" />
                    </ChartConfig>
                </a:HighChart>
            </Items>
        </ext:Panel>
         
    </form>
</body>
</html>
