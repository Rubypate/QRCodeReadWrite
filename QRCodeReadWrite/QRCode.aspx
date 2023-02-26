<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="QRCode.aspx.cs" Inherits="QRCodeReadWrite.QRCode" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron text-center">

        <div class="container text-center">
            <div class="row text-center">
                <div class="col-md-4">
                    <asp:Label ID="lblurl" runat="server">Enter the URL :</asp:Label>
                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtqrcode"  runat="server" placeHolder="Enter text"></asp:TextBox>
                    
                </div>
                <asp:RequiredFieldValidator ID="rftxtqrcode" runat="server" ControlToValidate="txtqrcode" ErrorMessage="Please enter the url link" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <br />
              <div class="row text-center-block">
                  <div class="col-md-4">
                 <asp:Button ID="Button1" OnClick="btngenerate_Click" runat="server" text="Generate QR Code" CssClass="btn-btn-primary"/>
             </div>
                  <div class="col-md-4">
                      <asp:Image ID="imgqrcode" runat="server" visible="false"/> 
                  </div>
              </div>
            <br />
            <div class="row text-center-block">
                  <div class="col-md-4">
                 <asp:Button ID="Button2" runat="server" Text="Read QR Code" OnClick="btnreadqrcode_Click" CssClass="btn-btn-primary" />
             </div>
                  <div class="col-md-4">
                      <asp:Label ID="lblreadqr" runat="server" ></asp:Label>
                  </div>
              </div>
             
            
        </div>
    </div>
 </asp:Content>


   

