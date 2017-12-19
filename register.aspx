<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 290px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 885px; background-color: #0066FF; background-image: url('Pic/regsiter.jpg'); width: 956px;">
    <center><h1>REGISTER TO PLAY</h1></center>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">NAME:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="201px" BorderColor="#003300" BorderStyle="Solid"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">PHONE NO:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="201px" BorderColor="#003300" BorderStyle="Solid"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">GMAIL:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="200px" BorderColor="#003300" BorderStyle="Solid"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">GENDER:</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Width="195px">
                        <asp:ListItem Value="MALE" Selected="True">MALE</asp:ListItem>
                        <asp:ListItem Value="FEMALE">FEMALE</asp:ListItem>
                    </asp:RadioButtonList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button2" runat="server" Text="LOGIN" OnClick="Button2_Click" BorderColor="#003366" BorderStyle="Dashed" />
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="REGISTER" BorderColor="#003366" BorderStyle="Dashed" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
