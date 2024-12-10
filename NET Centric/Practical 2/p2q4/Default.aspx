<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practical2Question4.Default" %>

<!DOCTYPE html>
<html>
<head>
    <title>Registration Form</title>
</head>
<body>
    <h2>Practical 2, Question 4</h2>
<p>Name: Bimochan Poudel<br />Class Roll: 21-00031-5 (20780638)<br />TU Roll: 28555/078 <br /></p>
    <h2>Registration Form</h2>
    <form id="form1" runat="server">
        <div>
            <label>Username:</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is required!" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required!" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Re-enter Password:</label>
            <asp:TextBox ID="txtRepassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvRepassword" runat="server" ControlToValidate="txtRepassword" ErrorMessage="Re-enter password is required!" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cvPassword" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtRepassword" ErrorMessage="Passwords do not match!" ForeColor="Red"></asp:CompareValidator>
        </div>
        <div>
            <label>Gender:</label>
            <asp:RadioButton ID="rbMale" runat="server" GroupName="Gender" Text="Male" />
            <asp:RadioButton ID="rbFemale" runat="server" GroupName="Gender" Text="Female" />
        </div>
        <div>
            <label>Course:</label>
            <asp:DropDownList ID="ddlCourse" runat="server">
                <asp:ListItem Text="Select Course" Value="" />
                <asp:ListItem Text="Computer Science" Value="Computer Science" />
                <asp:ListItem Text="Engineering" Value="Engineering" />
                <asp:ListItem Text="Medicine" Value="Medicine" />
                <asp:ListItem Text="Business" Value="Business" />
            </asp:DropDownList>
        </div>
        <div>
            <label>Country:</label>
            <asp:DropDownList ID="ddlCountry" runat="server">
                <asp:ListItem Text="Select Country" Value="" />
                <asp:ListItem Text="Nepal" Value="Nepal" />
                <asp:ListItem Text="India" Value="India" />
                <asp:ListItem Text="USA" Value="USA" />
            </asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
        <div>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>
