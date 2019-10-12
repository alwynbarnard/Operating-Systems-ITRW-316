<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="ExamProject3.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset><legend>Sizing Information</legend>
        <div>
        </div>
        <asp:Label ID="lbOSMem" runat="server" Text="How much memory must be reserved for the OS?"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtOSMem" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOSMem" ErrorMessage="REQUIRED!" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="How big should the page frames be?"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtPFSize" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPFSize" ErrorMessage="REQUIRED!" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br>
            <asp:Button ID="btnComplete" runat="server" Text="Complete" style= Font-Bold OnClick="btnComplete_Click" ></asp:Button>
            &nbsp;&nbsp;&nbsp;
            <a href="Paging.aspx">NEXT</a>
            </fieldset>
    </form>
  
</body>
</html>
