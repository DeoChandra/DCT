<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Project4.aspx.cs" Inherits="Assignments.Project4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
        <asp:TextBox ID="txtData" runat="server"></asp:TextBox> <br /><br />
        <asp:Button ID="btnGetData" runat="server" Text="Get Data" 
            onclick="btnGetData_Click" /> <br /><br />
         <asp:GridView ID="gvwData"
            runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
