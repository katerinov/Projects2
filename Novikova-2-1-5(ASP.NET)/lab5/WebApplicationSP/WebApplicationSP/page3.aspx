<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page3.aspx.cs" Inherits="WebApplicationSP.page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PAGE3</title>
</head>
<body style="background-color:antiquewhite">
    <form id="form1" runat="server">
        <div style="height: 46px">
            <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="ВЕРИФІКАЦІЯ АДРЕСИ ЕЛЕКТРОННОЇ ПОШТИ"></asp:Label>
        </div>
        <div style="height: 132px">
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="На Вашу адресу направлений одноразовий пароль." Width="357px"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Введіть його в поле і натисніть &quot;ДАЛІ&quot;:"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="18px" Width="246px"></asp:TextBox>
        </div>
        <div style="height: 70px">
            <asp:Button ID="ButtonNext" runat="server" Height="36px" Text="ДАЛІ" Width="133px" OnClick="ButtonNext_Click" OnClientClick="return OnButtonsClick()" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonBack" runat="server" Height="36px" Text="НАЗАД" Width="129px" OnClick="ButtonBack_Click" OnClientClick="return OnButtonsClick()"/>
        </div>
    </form>
    <script type="text/javascript" src="Namespace.js"></script>
    <script type="text/javascript" language="JavaScript">

        function OnButtonsClick() {
            document.getElementById('<%=ButtonNext.ClientID %>').style.display = "none";
            document.getElementById('<%=ButtonBack.ClientID %>').style.display = "none";
            setTimeout(function () { onclick = "" }, 2000);
            return true;
        }
    </script>
</body>
</html>
