<%@ Page Title="Welcome Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="comfortWalk._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <link rel="stylesheet" href="Styles/myStyle.css" type="text/css" />


<div class="slideshow-container">

  <!-- Full-width images with number and caption text -->
  <div class="mySlides">
      <div class="numbertext">1 / 3</div>
      <a href="ProductList.aspx"><img src="Catalog/Images/categoryPics/boots3.png" style="width:100%"/></a>
  </div>

  <div class="mySlides">
     <div class="numbertext">2 / 3</div>
     <a href="ProductList.aspx"><img src="Catalog/Images/categoryPics/sport shoes.png" style="width:100%"/></a>  
  </div>

  <div class="mySlides">
     <div class="numbertext">3 / 3</div>
     <a href="ProductList.aspx"><img src="Catalog/Images/categoryPics/trekkings.png" style="width:100%" /></a>
  </div>

  <!-- Next and previous buttons -->
  <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
  <a class="next" onclick="plusSlides(1)">&#10095;</a>
</div>
<br>

<!-- The dots/circles -->
<div style="text-align:center">
  <span class="dot" onclick="currentSlide(1)"></span>
  <span class="dot" onclick="currentSlide(2)"></span>
  <span class="dot" onclick="currentSlide(3)"></span>
</div>


<script src="styleJavaScript.js" type="text/javascript" ></script>

      

</asp:Content>
