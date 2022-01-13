<%@ Page Title="Log" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Log.aspx.cs" Inherits="PresentationLayerWeb.Log" %>
<asp:Content ID="LogId" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="PanelLog" runat="server">
         <div style="background-color:rgb(64,64,64); text-align:center;">
            <div class="container" style="padding:50px;">
                <div style="background-color:rgb(50,50,50); padding:50px;">
                    <div class="row">
                        <div class="col-md-6" style="text-align:left;">
                            <asp:Label ID="LabelUserId" runat="server" Text="KORISNIČKO IME" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-6" style="text-align:right;">
                            <asp:TextBox ID="TextBoxUserId" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                    </div>
                    <br>
                    <div class="row">
                        <div class="col-md-6" style="text-align:left;">
                            <asp:Label ID="LabeUserPassword" runat="server" Text="LOZINKA" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-6" style="text-align:right;">
                            <asp:TextBox ID="TextBoxUserPassword" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderColor="#EEBC1D" BorderStyle="Solid"></asp:TextBox>
                        </div>
                    </div>
                    <br>
                    <div style="text-align:right;">
                        <asp:Button  ID="ButtonLogin" runat="server" Text="PRIJAVI SE" BackColor="#EEBC1D" ForeColor="#323232" BorderColor="#EEBC1D" BorderStyle="Solid" Font-Bold="True" />
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
