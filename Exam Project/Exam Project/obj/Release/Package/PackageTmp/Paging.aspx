<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paging.aspx.cs" Inherits="ExamProject3.Paging" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 1095px;
            width: 1351px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnStart" runat="server" OnClick="btnStart_Click" Text="START" />
        <br />
        <fieldset style="border-style: dotted"><legend style="font-family: Arial; font-weight: bold; font-style: normal">Search</legend>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" Font-Bold="True" Text="SEARCH" BorderStyle="Solid" OnClick="btnSearch_Click" />
        </fieldset>
        
        <br />
        <fieldset style="border-style: dotted"><legend style="font-family: Arial; font-weight: bold; font-style: normal">Translation Lookaside Buffer</legend>
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lbxTLB" runat="server" AutoPostBack="True" Height="200px" ToolTip="TLB" Width="100px"></asp:ListBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        </fieldset>
        <br />
        <fieldset style="border-style: dotted"><legend style="font-family: Arial; font-weight: bold; font-style: normal">Page Table</legend>
        <br />
&nbsp;&nbsp;
        <asp:ListBox ID="lbxPageTable" runat="server" AutoPostBack="True" Height="300px" Width="100px" ></asp:ListBox>
        <br />
        <br />
            </fieldset>
        <br />
        <fieldset style="border-style: dotted"><legend style="font-family: Arial; font-weight: bold; font-style: normal">RAM (HDD)</legend>
        &nbsp;
        <br />
        <br />
&nbsp;&nbsp;
        <asp:ListBox ID="lbxHDD" runat="server" AutoPostBack="True" Height="300px" Width="100px"></asp:ListBox>
            <br />
            </fieldset>
    </form>
</body>
</html>
