<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FinanceSite.WebPages.WelcomeSplashPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome!</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400" rel="stylesheet"/> 
    <link rel="stylesheet" type="text/css" href="Assets/css/SplashPage2.css" />
    <link href="Assets/css/fontawesome-free-5.13.0-web/css/all.css" rel="stylesheet" />
    <script src="Assets/js/jquery-3.5.1.min.js" type="text/javascript"></script>
</head>
<body>

    <div class="page-wrapper">
 <div class="nav-wrapper">
  <div class="grad-bar"></div>
  <nav class="navbar">
    <img src="Assets/images/logo.png" alt="Company Logo"/>
    <div class="menu-toggle" id="mobile-menu">
      <span class="bar"></span>
      <span class="bar"></span>
      <span class="bar"></span>
    </div>
    <ul class="nav no-search">
      <li class="nav-item"><a href="Login.aspx">Login</a></li>
      <li class="nav-item"><a href="#">Register</a></li>
    </ul>
  </nav>
  </div>
  <section class="headline">
    <h1>Righteous Revenue</h1>
    <p>Be in control of your finances with God!</p>
  </section>
  <section class="features">
    <div class="feature-container">
      <img src="Assets/images/point1.jpg" alt="Bible"/>
      <h2>Control</h2>
      <p>Be in Control of your Money, Mind, and Motives. With a great foundation and plan for the
          future.
      </p>
    </div>
    <div class="feature-container">
      <img src="Assets/images/point2.jpg" alt="picture of money"/>
      <h2>Christ</h2>
      <p>God has a lot to say about money. We have the opportunity to learn
          about what God has to say about finance through scriptures. Having a basis on morality
          with your finance can create a new perspective on the way you see money. 
      </p>
    </div>
    <div class="feature-container">
      <img src="Assets/images/point3.jpg" alt="picture of nature"/>
      <h2>Clarity</h2>
      <p>Break out of the chains of financial insecurity and consumerism. Move towards a new life
          of dicipline and financial freedom.
      </p>
    </div>
  </section>
</div>
<script src="Assets/js/SplashPage2.js"></script>
</body>
</html>
