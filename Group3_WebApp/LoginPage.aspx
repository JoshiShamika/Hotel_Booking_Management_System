<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Group3_WebApp.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="HomeStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
 <table style="align-content:center;">
            <tr>
                <td>
                    <h2>Cheap Stay</h2>

                </td>
            </tr>

            <tr class="menu">
                <td>

                    <ul>
		                <li><a href="HomePage.aspx">Home</a></li>
		                <li><a href="#">Login</a></li>
		                <li><a href="UserReg.aspx">User Registration</a></li>
		                <li><a href="HotelReg.aspx">Hotel Registration</a></li>
		                <li><a href="HomePage.aspx">Contact Us</a></li>
	                </ul>
                </td>
            </tr>
     <tr>

         <td style="align-content:center;height:500px;">     
             
             <table  style="align-content:center;width:80%;padding-left:300px;margin:50px;">
                 <tr>
                     <td style="width:30%;color:white;font-family:Verdana;font-weight:bold;">
                         Enter User Id:
                     </td>
                     <td>
                         <asp:TextBox ID="txt_userName" CssClass="txtbox" runat="server"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                      <td style="width:30%;color:white;font-family:Verdana;font-weight:bold;">
                         Enter Password:
                     </td>
                     <td>
                         <asp:TextBox ID="txt_password" CssClass="txtbox" runat="server" TextMode="Password"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>

                     <td style="width:30%;color:white;font-family:Verdana;font-weight:bold;">
                         Select Type of User:
                     </td>
                     <td>
                         <asp:DropDownList ID="ddl_usertype" CssClass="txtbox" runat="server" OnSelectedIndexChanged="ddl_usertype_SelectedIndexChanged">
                             <asp:ListItem>Select user type</asp:ListItem>
                             <asp:ListItem>User</asp:ListItem>
                             <asp:ListItem>Hotel</asp:ListItem>
                             <asp:ListItem>Admin</asp:ListItem>
                         </asp:DropDownList>
                     </td>
                 </tr>
                 <tr>
                     <td colspan="2">
                         <br />
                         <br />
                     </td>
                 </tr>
                 <tr>
                     <td style="width:30%;">
                         <asp:Button ID="btn_submit" runat="server" CssClass="btn" Text="Submit" OnClick="btn_submit_Click" />
                     </td>
                     <td>
                         <asp:Label ID="lbl_Show" runat="server" Text="Label"></asp:Label>
                     </td>
                 </tr>
             </table>    
            
             
             <br />
              
           
         </td>
     </tr>
            
            <tr class="footer">
                <td>
                    <p>Copyright© 2016 Group3, Capgemini. All rights reservedp3, Capgemini. All rights reserved</p>

                </td>
            </tr>
       </table>



    </div>
    </form>
</body>
</html>
