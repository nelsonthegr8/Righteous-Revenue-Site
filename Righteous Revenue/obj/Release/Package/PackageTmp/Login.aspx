<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinanceSite.Login_Register_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
    <link href="Assets/css/fontawesome-free-5.13.0-web/css/all.css" rel="stylesheet"/>

    <link href='https://fonts.googleapis.com/css?family=Arimo:400,700,400italic,700italic' rel='stylesheet' type='text/css'/>
    <link href='https://fonts.googleapis.com/css?family=Stint+Ultra+Condensed' rel='stylesheet' type='text/css'/>


    <meta content='width=device-width, initial-scale=1, maximum-scale=1' name='viewport'/>
    <link rel="stylesheet" href="Assets/css/SignUp.css" type="text/css" />
</head>
<body>
<div class="signform">

   <!-- left side will be in the top at 640px screen-->
<div class="left">
<div class="bts">
<a href="Default.aspx" class="fblogin"><i class="fas fa-home"></i><span>Home</span></a>

</div>
</div>
<!-- end left side -->
  
  <!-- right side will be in the bottom at 640px screen-->
<div class="right">

  <div class="headit">
    <a href="SignUp.aspx">sign up now</a>
  </div>
<form runat="server">
<div class="input-group margin-bottom-sm">
  <span class="input-group-addon"><i class="fas fa-envelope fa-fw"></i></span>
  <asp:TextBox runat="server" id="Usertxt" class="form-control" type="text" placeholder="Username"></asp:TextBox>
</div>
<div class="input-group">
  <span class="input-group-addon"><i class="fa fa-key fa-fw"></i></span>
  <asp:TextBox runat="server" id="Passtxt" class="form-control" type="password" placeholder="Password"></asp:TextBox>
</div>
    <asp:Button ID="Loginbtn" runat="server" Text="login" class="subbt" OnClick="Loginbtn_Click" />
</form>
<!-- <a href="#">Forgot your password?</a> -->

<asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

</div>
  <!-- end left side -->
</div>

</body>
</html>
