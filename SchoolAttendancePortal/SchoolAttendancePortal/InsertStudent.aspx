<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertStudent.aspx.cs" Inherits="SchoolAttendancePortal.InsertStudent" %>
<asp:Content ID="mainContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Register Student</h1>
        <table style="width:100%;">
            <tr>
                <td style="width:20%"><strong>Admin Number:</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="adminNumberTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Name:</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="nameTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Gender:</strong></td>
                <td style="width:30%">
                    <asp:RadioButtonList ID="genderRadioButtonList" runat="server" RepeatDirection="Horizontal" Width="100%">
                        <asp:ListItem Selected="True" Value="M">Male</asp:ListItem>
                        <asp:ListItem Value="F">Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Date of Birth:</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="dobTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Address:</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="addressTextBox" runat="server" Height="150px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Citizenship:</strong></td>
                <td style="width:30%">
                    <asp:DropDownList ID="citizenshipDropDownList" runat="server" Width="100%">
                        <asp:ListItem Value="BD">Bangladesh</asp:ListItem>
                        <asp:ListItem Value="CA">Canada</asp:ListItem>
                        <asp:ListItem Value="CN">China</asp:ListItem>
                        <asp:ListItem Value="HK">Hong Kong</asp:ListItem>
                        <asp:ListItem Value="ID">Indonesia</asp:ListItem>
                        <asp:ListItem Value="JP">Japan</asp:ListItem>
                        <asp:ListItem Value="MY">Malaysia</asp:ListItem>
                        <asp:ListItem Selected="True" Value="SG">Singapore</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Mobile:</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="mobileTextBox" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Profile Image:</strong></td>
                <td style="width:30%">
                    <asp:FileUpload ID="profileImageFileUpload" runat="server" Width="100%" />
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:30%">&nbsp;</td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="statusLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="okButton" runat="server" Text="Ok" Width="100px" OnClick="okButton_Click" />
&nbsp;<asp:Button ID="clearButton" runat="server" Text="Clear" Width="100px" />
                </td>
            </tr>
        </table>
</asp:Content>
