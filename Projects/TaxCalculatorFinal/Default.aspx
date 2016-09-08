<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Salary Tax Calculator</title>
      <link rel="stylesheet" href="Content/bootstrap.min.css" />
        <link rel="stylesheet" href="~/css/site.css" />
</head>   
<body>
   <script src =" https://code.jquery.com/jquery.js/"><</script>
    <script src="Scripts/bootstrap.min.js"></script>
    <div class="container">
        <div class="row">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <asp:Label ID="Header" runat="server" Text="Income Tax Calculator"></asp:Label>
                                </div>
                                <div class="panel-body bg-info">
                            

    <div class="col-sm-6">
                    
    <%-- <asp:Label ID="Header" runat="server" Text="Income Tax Calculator"></asp:Label>--%>
        <br /><br />
        <%--<asp:Label ID="grossSalary" runat="server" Text="My Gross Income: £"></asp:Label>--%>
        <%-- <asp:Label ID ="Label8" runat="server" Text="Enter Gross Salary"></asp:Label>--%>
        <h3>Enter Gross Salary</h3>     
                    <div class="input-group">
                        <div class="input-group-addon">£</div>
           
        <asp:TextBox CssClass ="form-control" ID="TextBox1" runat="server" Placeholder="Gross Salary"></asp:TextBox></div>
        <br /><br/>
        <asp:Button CssClass="btn btn-danger btn-lg" ID="calculate" runat="server" Text="Calculate Tax" OnClick="calculate_Click" />
        <br /><br /></div>
                                    <div class="col-sm-6">
        <div class="form-group">
        <div class ="panel panel-primary">
            <div class ="panel-heading">
        <asp:Label ID ="Label1" runat="server" Text="Gross Salary"></asp:Label>
                </div>
            <div class ="panel-body">
        <asp:Label ID="grossSalarylbl" runat="server" Text=""></asp:Label>
            </div></div></div>
          <div class="form-group">
               <div class ="panel panel-primary">
                   <div class ="panel-heading">
        <asp:Label ID="Label2" runat="server" Text="Tax Free Allowance"></asp:Label>
                       </div>
                   <div class ="panel-body">
        <asp:Label ID="taxFreeLbl" runat="server" Text=""></asp:Label>
              </div></div></div>
                     <div class="form-group">
                          <div class ="panel panel-primary">
                              <div class ="panel-heading">
        <asp:Label ID="Label3" runat="server" Text="Total Taxable"></asp:Label>
                                  </div>
                          <div class ="panel-body">
        <asp:Label ID="totaltxbleLbl" runat="server" Text=""></asp:Label>
                         </div></div></div>
                     <div class="form-group">
                         <div class ="panel panel-primary">
                               <div class ="panel-heading">
        <asp:Label ID="Label4" runat="server" Text="Income Tax Paid"></asp:Label>
                                   </div><div class ="panel-body">
        <asp:Label ID="taxPaidlbl" runat="server" Text=""></asp:Label>
                         </div></div></div>
                    <div class="form-group">
                        <div class ="panel panel-primary">
                               <div class ="panel-heading">
        <asp:Label ID="Label6" runat="server" Text="NI Contribution"></asp:Label>
                                   </div><div class ="panel-body">
        <asp:Label ID="nIlbl" runat="server" Text=""></asp:Label>
                        </div></div></div>
                    <div class="form-group">
                        <div class ="panel panel-primary">
                             <div class ="panel-heading">
        <asp:Label ID="Label5" runat="server" Text="Net Salary"></asp:Label>
                                 </div>
                            <div class ="panel-body">
        <asp:Label ID="netSalarylbl" runat="server" Text=""></asp:Label>
                                 </div></div></div>
        
    </div></div></div></div></div></ContentTemplate></asp:UpdatePanel>
    </form>
            </div></div>
</body>
</html>
