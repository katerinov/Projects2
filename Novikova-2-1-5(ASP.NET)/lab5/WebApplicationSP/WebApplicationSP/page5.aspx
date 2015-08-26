<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page5.aspx.cs" Inherits="WebApplicationSP.page5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PAGE5</title>
</head>
<body style="background-color:antiquewhite">
    <form id="form1" runat="server">
    <div>
  <asp:Label ID="page5Title" runat="server">Вітаємо Вас на нашому сайті,</asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        &nbsp;
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Image ID="Image2" runat="server"  ImageUrl="" />
        <br />
        <br />
    </div>
        <asp:Label ID="Label1" runat="server" Text="Логін ..... "></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Е-mail .... "></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server" Height="44px" OnClick="Button1_Click" OnClientClick="return OnButtonsClick()" Text="ВИХІД" Width="141px" />
    </form>
    <script type="text/javascript" src="Namespace.js"></script>
    <script type="text/javascript" language="JavaScript">

        function OnButtonsClick() {
            document.getElementById('<%=Button1.ClientID %>').style.display = "none";
            setTimeout(function () { onclick = "" }, 2000);
            return true;
        }
    </script>
</body>
</html>
