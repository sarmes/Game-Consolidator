<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloWorld.Default" %>
<%@ Register TagPrefix="My" TagName="UserInfoBoxControl" Src="~/UserInfoBoxControl.ascx" %>
<%@ Register TagPrefix="My" TagName="EventUserControl" Src="~/EventUserControl.ascx" %>
<%@ Reference Control="~/UserInfoBoxControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="HelloWorldLabel"></asp:Label>
            <br /><br />
            <asp:TextBox runat="server" ID="TextInput" />
            <asp:Button runat="server" ID="GreetButton" Text="Say Hello!" OnClick="GreetButton_Click" />
            <asp:DropDownList runat="server" ID="GreetList" AutoPostBack="true" onselectedindexchanged="GreetList_SelectedIndexChanged">
                <asp:ListItem Value="no one">No one</asp:ListItem>
                <asp:ListItem Value="world">World</asp:ListItem>
                <asp:ListItem Value="Universe">Universe</asp:ListItem>
            </asp:DropDownList>
            <asp:PlaceHolder runat="server" ID="phUserInfoBox" />
            <My:EventUserControl runat="server" ID="MyEventUserControl" OnPageTitleUpdated="MyEventUserControl_PageTitleUpdated" />
        </div>
    </form>
</body>
</html>
