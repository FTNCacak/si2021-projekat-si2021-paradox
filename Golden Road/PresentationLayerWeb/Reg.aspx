<%@ Page Title="Reg" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="PresentationLayerWeb.Reg" %>
<asp:Content ID="RegId" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
    <div style="background-color:rgb(64,64,64); text-align:center;">
            <div class="container" style="padding:50px;">
                <div style="background-color:rgb(50,50,50); padding:50px;">
                    <div class="row">
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelFirstName" runat="server" Text="*IME" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxFirstName" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelLastName" runat="server" Text="*PREZIME" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxLastName" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                    </div>
                    <br>
                    <div class="row">
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabeUserId" runat="server" Text="*KORISNIČKO IME" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxUserId" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelPassword" runat="server" Text="*LOZINKA" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxPassword" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                    </div>
                    <br>
                    <div class="row">
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelJmbg" runat="server" Text="*JMBG" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxJmbg" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelEmail" runat="server" Text="*E-MAIL" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxEmail" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                    </div>
                    <br>
                    <div class="row">
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelPhone" runat="server" Text="BROJ TELEFONA" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxPhone" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelAdress" runat="server" Text="ADRESA" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxAdress" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                    </div>
                    <br>
                    <div style="text-align:right;">
                        <asp:Button  ID="ButtonRegister" runat="server" Text="REGISTRUJ SE" BackColor="#EEBC1D" ForeColor="#323232" BorderColor="#EEBC1D" BorderStyle="Solid" Font-Bold="True" />
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
