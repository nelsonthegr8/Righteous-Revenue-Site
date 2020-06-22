<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FinanceSite.WebPages.WelcomeSplashPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome!</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" type="text/css" href="Assets/css/SplashPage.css" />
    <script>
        function hamburgerToggle()
        {
            toggleSidebar("hidden");
        }
        function exitToggle()
        {
            toggleSidebar("visible");
        }
        function toggleSidebar(setting) {        
            document.getElementById("sidebar").classList.toggle('active');
            document.getElementsByClassName('toggle-btn')[0].style.visibility = setting;    
        }
    </script>
</head>
<body>
    <div id="container">

        <header>
            <div class="Title">Righteous Revenue</div>
     
        </header>

        <div id="sidebar">

            <ul>
                <li><a href="#" class="close" onclick="exitToggle();"></a></li>
                <li style="cursor:pointer;" onclick="">Login</li>
                <li style="cursor:pointer;" onclick="">Register</li>
            </ul>

            <div class="toggle-btn" onclick="hamburgerToggle();">
                <span></span>
                <span></span>
                <span></span>
            </div>

        </div>

        <nav>
            <input runat="server" id="loginbtn" type="button" value="Login"/>
            <input runat="server" id="registerbtn" type="button" value="Register"/>
         
        </nav>

        <div class="info1">
            <p>Helllo  Testing Nelson Brumaire</p>
        </div>

        <div class="info2">
            <p>Hello Testing Nelson Brumaire</p>
        </div>

        <div class="info3">
            <p>Testing Nelson Brumaire</p>
        </div>

    </div>
</body>
</html>
