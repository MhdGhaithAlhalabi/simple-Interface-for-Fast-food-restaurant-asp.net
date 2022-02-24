<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="fastfood2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>fast food</h1>
        <p class="lead">you can chose fast food from here and .</p>
        <p>&nbsp;</p>
    </div>

    <div class="row">
        <div class="col-md-4">

            <asp:Panel ID="Panel1" runat="server" BackColor="#333333" Height="224px" style="margin-top: 0px" Width="330px">
                
                    <asp:Image ID="Image1" runat="server" Height="108px" ImageUrl="~/pictureBox1.Image.jpg" Width="330px" />
                <h2 style="color: #FFFFFF">
                    burger </h2>
                <p style="color: #FFFFFF">
                    nice burger yammy
                </p>
                <p style="color: #FFFFFF">
                    price is 5$
                </p>
                    
                    
            </asp:Panel>
                                    <asp:Button ID="Button1" runat="server" Text="add" Width="330px" OnClick="Button1_Click1" />

            
        </div>
        <div class="col-md-4">
     <asp:Panel ID="Panel2" runat="server" BackColor="#333333" Height="233px" style="margin-top: 0px" Width="330px">
                         <asp:Image ID="Image2" runat="server" Height="120px" ImageUrl="~/pictureBox2.Image.jpg" Width="330px" />

            <h2 style="color: #FFFFFF">cake</h2>
           
            
            <p style="color: #FFFFFF">
             nice cake yammy 
            </p>
             <p style="color: #FFFFFF">
               price is 3$
            </p>
           </asp:Panel>
                             <asp:Button ID="Button2" runat="server" Height="22px" Text="add" OnClick="Button2_Click1" Width="330px" />

        </div>
        <div class="col-md-4">
                 <asp:Panel ID="Panel3" runat="server" BackColor="#333333" Height="224px" style="margin-top: 0px" Width="330px">
                <asp:Image ID="Image3" runat="server" Height="101px" ImageUrl="~/pictureBox3.Image.jpg" Width="330px" />

            <h2 style="color: #FFFFFF">pizza</h2>
            
           
            <p style="color: #FFFFFF">
                nice pizza yammy 
            </p>
             <p style="color: #FFFFFF">
               price is 4$
            </p>
         </asp:Panel>
                             <asp:Button ID="Button3" runat="server" Text="add" OnClick="Button3_Click1" Width="330px" />

        </div>
    </div>

</asp:Content>
