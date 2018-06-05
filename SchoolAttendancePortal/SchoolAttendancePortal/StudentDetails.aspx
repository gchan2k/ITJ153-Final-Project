<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentDetails.aspx.cs" Inherits="SchoolAttendancePortal.StudentDetails" %>
<asp:Content ID="mainContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Student Details</h1>
    <table style="width:100%;">
            <tr>
                <td style="width:20%">
                    <asp:Image ID="profileImage" runat="server" Height="150px" Width="120px" />
                </td>
                <td style="width:30%">
                    &nbsp;</td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Admin Number:</strong></td>
                <td style="width:30%">
                    <asp:Label ID="adminNumberLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Name:</strong></td>
                <td style="width:30%">
                    <asp:Label ID="nameLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Gender:</strong></td>
                <td style="width:30%">
                    <asp:RadioButtonList ID="genderRadioButtonList" runat="server" RepeatDirection="Horizontal" Width="100%" Enabled="False">
                        <asp:ListItem Selected="True" Value="M">Male</asp:ListItem>
                        <asp:ListItem Value="F">Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Date of Birth:</strong></td>
                <td style="width:30%">
                    <asp:Label ID="dobLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Address:</strong></td>
                <td style="width:30%">
                    <asp:TextBox ID="addressTextBox" runat="server" Height="150px" TextMode="MultiLine" Width="100%" ReadOnly="True"></asp:TextBox>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>Citizenship:</strong></td>
                <td style="width:30%">
                    <asp:DropDownList ID="citizenshipDropDownList" runat="server" Width="100%" Enabled="False">
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
                    <asp:Label ID="mobileLabel" runat="server" Width="100%"></asp:Label>
                </td>
                <td style="width:50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%"><strong>School Email:</strong></td>
                <td style="width:30%">
                    <asp:Label ID="emailLabel" runat="server" Width="100%"></asp:Label>
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
                    <asp:Button ID="backButton" runat="server" Text="Back" Width="100px" />
                </td>
            </tr>
        </table>
</asp:Content>
