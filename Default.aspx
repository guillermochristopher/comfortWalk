<%@ Page Title="Welcome Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="comfortWalk._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Styles/myStyle.css" />

    <img alt="coverImage" src="cover.jpeg" style="max-width:100%" />

        <div class="carrousel">
            <div class="carrousel-items">
                <div class="carrousel-item">
                    <img src="Catalog/Images/categoryPics/Summers.png" alt="Summer Shoe Picture" />
                </div>
                <div class="carrousel-item">
                    <img src="Catalog/Images/categoryPics/boots.png" alt="Boots ShoePicture" />
                </div>
                <div class="carrousel-item">
                    <img src="Catalog/Images/categoryPics/sport.png" alt="Sport Shoe Picture" />
                </div>
                <div class="carrousel-item">
                    <img src="Catalog/Images/categoryPics/trekking.png" alt="Trekking Shoe Picture" />
                </div>
                <div class="carrousel-item">
                    <img src="Catalog/Images/categoryPics/casual.png" alt="Casual Shoes picture" />
                </div>               
            </div>          
        </div>
        
    <script src="styleJavaScript.js"></script>

        <h2>“Comfort and fashion in every step”</h2>

</asp:Content>
