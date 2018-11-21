<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 210px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="mesesList" runat="server" Height="306px"></asp:ListBox>
        <br />
        <asp:Label runat="server" Text="Máxima"></asp:Label>
        <asp:TextBox ID="max" runat="server"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Mínima"></asp:Label>
        <asp:TextBox ID="min" runat="server"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Media"></asp:Label>
        <asp:TextBox ID="med" runat="server"></asp:TextBox>
    </form>
</body>
</html>
