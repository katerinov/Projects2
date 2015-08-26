<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="WebApplicationSP.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PAGE1</title>
</head>
<body style="background-color: antiquewhite">
    <form id="form1" runat="server">
        <div style="height: 65px">
            <asp:Label ID="page1Title" runat="server" Font-Size="Large"></asp:Label>
        </div>
        <div style="height: 72px">
            <asp:Label ID="LabelLogin" runat="server" Font-Size="Medium"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxLogin" runat="server" Height="19px" Width="160px"></asp:TextBox>
        </div>
        <div style="height: 77px">
            <asp:Label ID="LabelPassword" runat="server" Text="Label" Font-Size="Medium"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxPassword" runat="server" Height="19px" Width="166px" Type="password"></asp:TextBox>
        </div>
        <div style="height: 61px">
            <asp:Button ID="Button1" runat="server" Text="ВХІД" Font-Size="Medium"  OnClientClick="return OnButtonsClick()" OnClick="Button1_Click"/>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
        <div style="height: 62px">
            <asp:Button ID="Button2" runat="server" Text="РЕЄСТРАЦІЯ  " Font-Size="Medium" OnClientClick="return OnButtonsClick()" OnClick="Button2_Click" />
        </div>
    </form>

    <script type="text/javascript" >

        function OnButtonsClick() {
            document.getElementById('<%=Button1.ClientID %>').style.display = "none";
            document.getElementById('<%=Button2.ClientID %>').style.display = "none";
            setTimeout(function () { onclick = "" }, 2000);
            return true;
        }
    </script>
</body>
</html>
