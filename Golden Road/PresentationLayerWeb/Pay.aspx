<%@ Page Title="Pay" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pay.aspx.cs" Inherits="PresentationLayerWeb.Pay" %>
<asp:Content ID="PayId" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
    <div style="background-color:rgb(64,64,64); text-align:center;">
            <div class="container" style="padding:50px;">
                <div style="background-color:rgb(50,50,50); padding:50px;">
                    <div class="row">
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelFromAcc" runat="server" Text="SA RAČUNA" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxFromAcc" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelLastName" runat="server" Text="STANJE NA RAČUNU" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            
                        </div>
                    </div>
                    <br>
                    <div class="row">
                        <div class="col-md-6" style="text-align:left;">
                            <asp:Label ID="LabeRecipient" runat="server" Text="PRIMALAC" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-6" style="text-align:left;">
                            <asp:Label ID="LabelDetails" runat="server" Text="DETALJI PLAĆANJA" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                    </div>
                    <br>
                    <div class="row">
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelName" runat="server" Text="NAZIV" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxName" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelAmount" runat="server" Text="*IZNOS" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxAmount" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                    </div>
                    <br>
                    <div class="row">
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelToAcc" runat="server" Text="*BROJ RAČUNA" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxToAcc" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelPurpose" runat="server" Text="SVRHA PLAĆANJA" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxPurpose" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                    </div>
                    <br>
                    <div class="row">
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelModel" runat="server" Text="*MODEL" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxModel" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelDate" runat="server" Text="*DATUM" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <label for="start">Start date:</label>
                            <input type="date" id="start" name="trip-start"value="2022-01-13" min="2018-01-01" max="2024-12-31" style="color:#2D2D2D; background-color:#EEBC1D; font-weight:bold;">
                        </div>
                    </div>
                    <br>
                    <div class="row">
                        <div class="col-md-3" style="text-align:left;">
                            <asp:Label ID="LabelReference" runat="server" Text="*POZIV NA BROJ" ForeColor="#EEBC1D"></asp:Label>
                        </div>
                        <div class="col-md-3" style="text-align:right;">
                            <asp:TextBox ID="TextBoxReference" runat="server" ForeColor="#EEBC1D" BackColor="#2D2D2D" BorderStyle="Solid" BorderColor="#EEBC1D"></asp:TextBox>
                        </div>
                    </div>
                    <br>
                    <div style="text-align:right;">
                        <asp:Button  ID="ButtonPayment" runat="server" Text="UPLATA" BackColor="#EEBC1D" ForeColor="#323232" BorderColor="#EEBC1D" BorderStyle="Solid" Font-Bold="True" />
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
