<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeSettings.aspx.cs" Inherits="FinanceSite.HomeSettings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Assets/css/HomeSettings.css" type="text/css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="holder">
            <table width="100%">
                <tr>
                    <td>Include me in the public list</td>
                    <td>
                        <div>
                            <input type="checkbox" />
                            <span></span>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>Let my friends see my phone number</td>
                    <td>
                        <div>
                            <input type="checkbox" />
                            <span></span>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>Let my friends see my email address</td>
                    <td>
                        <div>
                            <input type="checkbox" />
                            <span></span>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>Include me in the public list</td>
                    <td>
                        <div>
                            <input type="checkbox" />
                            <span></span>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <input type="submit" value="Save Settings"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
