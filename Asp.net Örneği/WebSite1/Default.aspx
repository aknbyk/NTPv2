<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            text-align: center;
            color: #FF0000;
            height: 40px;
            font-size: large;
            font-family: "Courier New", Courier, monospace;
        }
        .style3
        {
            width: 224px;
        }
        .style4
        {
            width: 199px;
        }
        .style5
        {
            width: 263px;
        }
        .style8
        {
            width: 263px;
            font-weight: bold;
            color: #3399FF;
        }
        .style9
        {
            width: 199px;
            font-weight: bold;
            color: #3399FF;
        }
        .style10
        {
            width: 224px;
            font-weight: bold;
            color: #3399FF;
        }
        .style11
        {
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2" colspan="3">
                    <strong><span class="style11">MINI KREDI HESAPLAMA MAKINESI</span></strong></td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    Çekilecek Miktar</td>
                <td class="style9">
                    Vade</td>
                <td class="style8">
                    Kredi Türü</td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="style4">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Seçiminiz...</asp:ListItem>
                        <asp:ListItem>Konut Kredisi</asp:ListItem>
                        <asp:ListItem>Taşıt Kredisi</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    Aylık Ödeme Miktarı</td>
                <td class="style9">
                    Toplam Ödenecek Miktar</td>
                <td class="style5">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Hesapla" />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="style4">
                    <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
