<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 275px;
        }
        h1
        {
            color:white;
        }
        h3
        {
            color:white;
        }
        .auto-style4 {
            width: 282px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 630px; background-color: #99CCFF; background-image: url('Pic/dynamic2.jpg');">
    
       
    <center><h1>WELCOME TO DYNAMIC SUDOKU</h1></center>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4"><h3>ENTER&nbsp; PHONE&nbsp; NUMBER :</h3></td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="177px" BorderColor="#FF0066" BorderStyle="Solid"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="LOGIN" BorderColor="#000066" BorderStyle="Dashed" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button2" runat="server" Text="REGISTER" OnClick="Button2_Click" BorderColor="#003366" BorderStyle="Dashed" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button3" runat="server" Text="HOW TO PLAY" OnClick="Button3_Click" BorderColor="#000066" BorderStyle="Dashed" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" BorderColor="Black" BorderStyle="Dashed" OnClick="Button4_Click" style="margin-right: 0px" Text="About Us" Width="147px" />
                </td>
            </tr>
        </table>
    
       
    
    </div>
    </form>
</body>
</html>
