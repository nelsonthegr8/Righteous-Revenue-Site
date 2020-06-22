<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinanceSite.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
   <title>Welcome!</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" type="text/css" href="Assets/css/HomePageNew.css" />
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400" rel="stylesheet" />
    <link href="Assets/css/fontawesome-free-5.13.0-web/css/all.css" rel="stylesheet" />
    <link href="Assets/css/Bootstrap-css/bootstrap.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Arimo:400,700,400italic,700italic" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Stint+Ultra+Condensed" rel="stylesheet" type="text/css" />

</head>
<body>
    <form runat="server">
    <div class="main">
    <h1 id="UserHeader" runat="server"></h1>
      <ul class="cards">
        <li class="cards_item">
          <div class="card">
            <div class="card_image"><img src="Assets/images/Layout Picture.png"/></div>
            <div class="card_content">
              <h2 class="card_title">Bills Checklist</h2>
                <div class="Billscontainer">
                    <asp:CheckBoxList ID="BillsChckbx" runat="server"></asp:CheckBoxList>
                    <asp:button runat="server" ID="billsAddBtn" CssClass="btn btn-success" Text="Add"></asp:button>
                </div>               
            </div>
          </div>
        </li>
        <li class="cards_item">
          <div class="card">
            <div class="card_image"><img src="Assets/images/CardImage3.png"/></div>
            <div class="card_content">
              <h2 class="card_title">Atm Withdrawl Calculator</h2>
                <asp:CheckBoxList ID="Atmchkbx" runat="server"></asp:CheckBoxList>
                <div class="AtmCalculatorContainer">
                    <span id="Twentytxt" class="Twentytxt">$20:</span>
                    <span id="Tentxt" class="Tentxt">$10:</span>
                    <span id="Fivetxt" class="Fivetxt">$5:</span>
                    <span id="Singletxt" class="Singletxt">$1:</span>
                    <span id="TwentyOutput" class="TwentyOutput">10</span>
                    <span id="TenOutput" class="TenOutput">5</span>
                    <span id="FiveOutput" class="FiveOutput">2</span>
                    <span id="SingleOutput" class="SingleOutput">1</span>
                    
                    <asp:button runat="server" ID="UncheckAllbtn" Text="Reset" class="uncheckallbtn btn btn-info"></asp:button>
                    <asp:button runat="server" ID="Deletebtn" Text="Delete" class="deletebtn btn btn-danger"></asp:button>

                    <asp:TextBox runat="server" ID="billnameTxtbx" Placeholder="Enter: Bill Name" class="billnametxtbx"></asp:TextBox>
                    <asp:TextBox runat="server" ID="billamntTxtbx" Placeholder="Enter: Bill Amount" class="billamnttxtbx"></asp:TextBox>

                    <button class="atmaddbtn btn btn-success">Add</button>
                </div>
              
            </div>
          </div>
        </li>
          <li class="cards_item">
          <div class="card">
            <div class="card_image"><img src="Assets/images/CardImage2.png"/></div>
            <div class="card_content">
              <h2 class="card_title">Savings Goals and Scriptures</h2>
                
              <button class="btn card_btn btn-success">Add</button>
            </div>
          </div>
        </li>
      </ul>     
    </div>
   </form>
</body>
</html>

