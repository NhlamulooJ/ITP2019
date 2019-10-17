<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ITP2019.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link rel="stylesheet" href="LoginStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
                <section>
            <div class="container" style="background-image: url('Images/sunset_scenery-5120x2880.jpg')">
        
                <div class="inner2">
                    <h3 style="font-family:'Bell MT'">Login</h3>
                    <asp:TextBox ID="txtemail" placeholder="E-mail" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtpasswd" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" CssClass="btn" Text="Login" OnClick="Button1_Click" />
            </div>
        </section>
    </form>
</body>
</html>
