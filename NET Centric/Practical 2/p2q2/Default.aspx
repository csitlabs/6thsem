<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practical2Question2.Default" %>

<!DOCTYPE html>
<html>
<head>
    <title>Practical 2, Question 2</title>
</head>
<body>
    <h2>Practical 2, Question 2</h2>
    <p>Name: Bimochan Poudel<br />Class Roll: 21-00031-5 (20780638)<br />TU Roll: 28555/078</p>
    
    <form id="form1" runat="server">
        <div>
            <label>Enter First Number:</label>
            <asp:TextBox ID="txtFirstNumber" runat="server"></asp:TextBox><br /><br />
            <label>Enter Second Number:</label>
            <asp:TextBox ID="txtSecondNumber" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label><br /><br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnSubtract" runat="server" Text="Subtract" OnClick="btnSubtract_Click" />
            <asp:Button ID="btnFindPrime" runat="server" Text="Find Prime" OnClick="btnFindPrime_Click" /><br /><br />
            <label>Result:</label>
            <asp:TextBox ID="txtResult" runat="server" ReadOnly="true"></asp:TextBox>
        </div>
    </form>
</body>
</html>
