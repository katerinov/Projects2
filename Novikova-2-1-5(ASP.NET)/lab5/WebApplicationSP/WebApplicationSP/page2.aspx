<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="WebApplicationSP.page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:antiquewhite">
    <form id="form1" runat="server">
        <div style="height: 33px">
            <asp:Label ID="LabelPhoto" runat="server"></asp:Label>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="FileUpload1" ErrorMessage="format invalid!" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="AllValidators"></asp:CustomValidator>
        </div>
        <div style="height: 56px">
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ShowMessageBox="True" ValidationGroup="AllValidators" Height="104px" style="margin-left: 341px; margin-top: 0px" Width="317px" />
        </div>
        <div style="height: 77px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbname" Display="Dynamic" ErrorMessage="first name is required" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:Label ID="name" runat="server" Font-Size="Medium" Width="120px"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbsurname" Display="Dynamic" ErrorMessage="surname is required" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:Label ID="surname" runat="server" Font-Size="Medium" Width="120px"></asp:Label>
            <br />
            <asp:TextBox ID="tbname" runat="server" Width="108px"></asp:TextBox>
            <asp:TextBox ID="tbsurname" runat="server"></asp:TextBox>
            &nbsp;<br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbname" Display="Dynamic" ErrorMessage="Name consists of Ukrainian letters only" ValidationExpression="^[а-яА-ЯёЁіІїЇ]{1,20}$" ValidationGroup="AllValidators">invalid format!</asp:RegularExpressionValidator>
&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tbsurname" Display="Dynamic" ErrorMessage="surname consists of Ukrainian letters" ValidationExpression="^[а-яА-ЯёЁіІїЇ]{1,20}$" ValidationGroup="AllValidators">invalid format!</asp:RegularExpressionValidator>
        </div>
        <div style="height: 75px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tblogin" Display="Dynamic" ErrorMessage="login is required" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:Label ID="login" runat="server" Font-Size="Medium" Width="120px"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbemail" Display="Dynamic" ErrorMessage="e-mail is required" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:Label ID="email" runat="server" Font-Size="Medium" Width="120px"></asp:Label>
            <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="tblogin" Display="Dynamic" ErrorMessage="login already exists" OnServerValidate="CustomValidator2_ServerValidate" ValidationGroup="AllValidators"></asp:CustomValidator>
            <br />
            <asp:TextBox ID="tblogin" runat="server" Width="107px"></asp:TextBox>
            <asp:TextBox ID="tbemail" runat="server"></asp:TextBox>
        &nbsp;<br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="tblogin" Display="Dynamic" ErrorMessage="login consists of 3-16 English letters and numbers only" ValidationExpression="^[a-z0-9]{3,16}$" ValidationGroup="AllValidators">invalid format!</asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="tbemail" Display="Dynamic" ErrorMessage="email must be correct format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="AllValidators">invalid format!</asp:RegularExpressionValidator>
        </div>
        <div style="height: 63px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbpassword1" Display="Dynamic" ErrorMessage="password required" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:Label ID="password" runat="server" Font-Size="Medium" Width="120px"></asp:Label>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="tbpassword2" Display="Dynamic" ErrorMessage="password confirmation is required" ValidationGroup="AllValidators">* Confirm password</asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="tbpassword1"  runat="server" Width="114px" type="password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tbpassword1" ControlToValidate="tbpassword2" Display="Dynamic" ErrorMessage="password must repeat" ValidationGroup="AllValidators"></asp:CompareValidator>
            <asp:TextBox ID="tbpassword2" runat="server" type="password"></asp:TextBox>
        </div>
        <div>
            <asp:RadioButtonList ID="rbs" runat="server" AutoPostBack = "true" OnSelectedIndexChanged="rbs_SelectedIndexChanged">
                <asp:ListItem
                    Enabled="True"
                    Selected="False"
                    Text="Студент" Value="student" />
                <asp:ListItem
                    Enabled="True"
                    Selected="True"
                    Text="Викладач" Value="teacher" />
                <asp:ListItem
                    Enabled="True"
                    Selected="False"
                    Text="Навчально-допоміжний персонал"
                    Value="assistent" />
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" CellPadding="1" CellSpacing="1" Height="53px" RepeatDirection="Horizontal" Width="923px">
                <asp:ListItem Value="sportmaster">Майстер спорту</asp:ListItem>
                <asp:ListItem Value="sciences">Кандидат наук</asp:ListItem>
                <asp:ListItem Enabled="False" Value="sciencephd">Доктор наук</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div style="height: 32px">
            <asp:Label ID="Label1" runat="server" Text="Курс:" Width="150px"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Факультет:"></asp:Label>
        </div>
        <div style="height: 82px">
            <asp:DropDownList ID="DropDownList1" runat="server" Height="48px" Width="152px">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" Height="48px" Width="152px">
            </asp:DropDownList>
        </div>
        <div style="height: 28px">
            <asp:Label ID="Label3" runat="server" Text="Структурний підрозділ:"></asp:Label>
        </div>
        <div style="height: 94px">
            <asp:DropDownList ID="DropDownList3" runat="server" Height="49px" Width="299px">
            </asp:DropDownList>
        </div>
        <div style="height: 151px">
            <asp:Button ID="ButtonNext" runat="server" Height="34px" Text="ДАЛІ" Width="159px" OnClick="ButtonNext_Click"  OnClientClick="return OnButtonsClick()" ValidationGroup="AllValidators" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonBack" runat="server" Height="34px" Text="НАЗАД" Width="170px" OnClientClick="return OnButtonsClick()" OnClick="ButtonBack_Click" />
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
