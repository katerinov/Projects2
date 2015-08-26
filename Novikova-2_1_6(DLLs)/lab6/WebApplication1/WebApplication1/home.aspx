<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication1.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 150px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label4" runat="server" Text="Solve F3(X,Y)+2*F4(X,Y)"></asp:Label>
        <br />
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="X:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Y:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Height="55px" OnClick="Button1_Click" Text="Get answer" Width="182px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
