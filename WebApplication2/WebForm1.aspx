<%@ Page Language = "C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="wk2InClassAssignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns = "http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id = "form1" runat="server">
        <div>
            <asp:Button ID="btnContact" runat="server" OnClick="btnContact_Click" Text="Display Contact Info." />
            <asp:Button ID="btnMen" runat="server" OnClick="btnMen_Click" Text="Men's Info" />
            <asp:Button ID="btnLast" runat="server" OnClick="btnLast_Click" Text="Search Last Name" />
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            <asp:Button ID = "btnVersion" runat="server" OnClick="btnVersion_Click" Text="Display Version Info." />
            <asp:TextBox ID = "txtResult" runat="server" Height="584px" Width="558px" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
        </div>
    </form>
</body>
</html>
