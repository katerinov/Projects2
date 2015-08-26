    function OnButtonsClick() {
        document.getElementById('<%=ButtonNext.ClientID %>').style.display = "none";
        document.getElementById('<%=ButtonBack.ClientID %>').style.display = "none";
        return true;
    }