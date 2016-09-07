<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="Header" runat="server" Text="Income Tax Calculator"></asp:Label>
        <br /><br />
        <asp:Label ID="grossSalary" runat="server" Text="My Gross Income: £"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="calculate" runat="server" Text="Calculate" OnClick="calculate_Click" />
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text="Gross Salary"></asp:Label><br />
        <asp:Label ID="grossSalarylbl" runat="server" Text=""></asp:Label><br /><br />
        <asp:Label ID="Label2" runat="server" Text="Tax Free Allowance"></asp:Label><br />
        <asp:Label ID="taxFreeLbl" runat="server" Text=""></asp:Label><br /><br />
        <asp:Label ID="Label3" runat="server" Text="Total Taxable"></asp:Label><br />
        <asp:Label ID="totaltxbleLbl" runat="server" Text=""></asp:Label><br /><br />
        <asp:Label ID="Label4" runat="server" Text="Income Tax Paid"></asp:Label><br />
        <asp:Label ID="taxPaidlbl" runat="server" Text=""></asp:Label><br /><br />
        <asp:Label ID="Label6" runat="server" Text="NI Contribution"></asp:Label><br />
        <asp:Label ID="nIlbl" runat="server" Text=""></asp:Label><br /><br />
        <asp:Label ID="Label5" runat="server" Text="Net Salary"></asp:Label><br />
        <asp:Label ID="netSalarylbl" runat="server" Text=""></asp:Label><br /><br />
        
    </div>
    </form>
</body>
</html>
