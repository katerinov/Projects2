<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page4.aspx.cs" Inherits="WebApplicationSP.page4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:antiquewhite">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="#66FF66" Text="РЕЄСТРАЦІЮ УСПІШНО ЗАВЕРШЕНО!" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="ПОМИЛКА РЕЄСТРАЦІЇ!  " Visible="False"></asp:Label>
        <br />
        <br />

    </div>
        <asp:Button ID="Button1" runat="server" Height="64px" Text="НА ГОЛОВНУ " Width="151px" OnClick="Button1_Click" OnClientClick="return OnButtonsClick()"/>
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
