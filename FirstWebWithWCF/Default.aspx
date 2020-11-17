<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstWebWithWCF._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  


    <div style="width:50%">
        <div style="background-color:blue; color:white; font-size:large; font-weight:bolder">My Calculator Using WEB</div>
   <br />

        <div style="color:blue; font-size:medium; font-weight:bolder">
            Number 1 : <asp:TextBox ID="TextBox1" runat="server" Width="80px"></asp:TextBox>
            Number 2 : <asp:TextBox ID="TextBox2" runat="server" Width="80px"></asp:TextBox>
        </div>

        <br />

        <div>
            <asp:Button ID="Button1" runat="server" Text="Add" BackColor="#0099FF" Font-Bold="True" ForeColor="White" OnClick="Button1_Click" Width="64px" /> &nbsp;
           <asp:Button ID="Button2" runat="server" Text="Sub" BackColor="#0099FF" Font-Bold="True" ForeColor="White"  Width="64px" OnClick="Button2_Click" /> &nbsp;
            <asp:Button ID="Button3" runat="server" Text="Multiple" BackColor="#0099FF" Font-Bold="True" ForeColor="White"  Width="64px" OnClick="Button3_Click" /> &nbsp;
            <asp:Button ID="Button4" runat="server" Text="Divide" BackColor="#0099FF" Font-Bold="True" ForeColor="White"  Width="64px" OnClick="Button4_Click" /> &nbsp;
            </div>
        <br />
        <div style=" color:blue; font-size:medium; font-weight:bolder">
            Result : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
    </div>
</asp:Content>
