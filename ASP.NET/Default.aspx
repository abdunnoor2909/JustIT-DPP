<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crib Sheet Excercise</title>
</head>
<body>
    <h1>Here are some examples from the ASP.NET crib sheet</h1>
    
    <br /><br />
    <h3>Standard Controls</h3>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="List controls"></asp:Label><br />
        <p>Choose your favourite programming language</p>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>Javascript</asp:ListItem>
        </asp:DropDownList>
        <br /><br />
        <asp:Button ID="confirmLang" runat="server" Text="Confirm Language" Height="19px" Width="137px" OnClick="confirmLang_Click" />
        <br /><br />
        <asp:Label ID="langDisplayed" runat="server" Text=""></asp:Label>
        <br /><br />
        <p>Choose all the ice-creams flavours that you like form the list (you can choose more than one)</p>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Vanilla</asp:ListItem>
            <asp:ListItem>Chocolate</asp:ListItem>
            <asp:ListItem>Strawberry</asp:ListItem>
            <asp:ListItem>Rasberry</asp:ListItem>
            <asp:ListItem>Mint</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Confirm Ice-Cream" OnClick="Button1_Click" />
        <br/>
        <br/>
        <asp:Label ID="LabelForIcecreams" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <p>This is a bulleted list Marilyn Manroe movies.</p>
        <br />
        <asp:BulletedList ID="BulletedList1" runat="server">
            <asp:ListItem>Some like it hot</asp:ListItem>
            <asp:ListItem>Gentlemen prefer Blondes</asp:ListItem>
            <asp:ListItem>Niagra</asp:ListItem>
        </asp:BulletedList>
        <br />
        <br />
        <p>From the list box. Choose your preffered candidate to be Liverpools manager (You can pick more than one)</p>
        <br />
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>Rafael Benitez</asp:ListItem>
            <asp:ListItem>Jorgen Klopp</asp:ListItem>
            <asp:ListItem>Pep Guardiola</asp:ListItem>
        </asp:ListBox>
        <br/>
        <asp:Button ID="Button2" runat="server" Text="Confirm Choice" OnClick="Button2_Click" />
        <br />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>




    </div>
    </form>
</body>
</html>
