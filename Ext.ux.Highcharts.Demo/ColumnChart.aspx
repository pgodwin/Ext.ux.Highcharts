<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ColumnChart.aspx.cs" Inherits="Ext.ux.Highcharts.Demo.ColumnChart" %>
<%@ Register TagPrefix="a" Namespace="Ext.ux.Highcharts" Assembly="Ext.ux.Highcharts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ext:ResourceManager runat="server" />
        <ext:Panel runat="server" Height="500" Width="800" Layout="FitLayout">
            <Items>
                <a:HighChart runat="server">
                    <Series>
                        <a:ColumnSerie runat="server" DataIndex="test" />
                    </Series>
                </a:HighChart>
            </Items>
        </ext:Panel>
        
    </div>
    </form>
</body>
</html>
