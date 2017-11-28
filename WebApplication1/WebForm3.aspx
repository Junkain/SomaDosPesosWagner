<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTexto" runat="server" Text=""></asp:Label>
                        
        </div>

        <div>
            <asp:Button Text="Home" runat="server" ID="btnHome" OnClick="btnHome_Click" />
        </div>
    </form>
</body>
</html>
