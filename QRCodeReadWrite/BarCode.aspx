<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BarCode.aspx.cs" Inherits="QRCodeReadWrite.BarCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtbarcode" runat="server"></asp:TextBox>
            <asp:Button ID="btnbarcode" runat="server" OnClick="btnbarcode_Click" Text="Bar Code" />
            <hr />
            <asp:PlaceHolder ID="plbarcode" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
