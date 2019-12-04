<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GoldReviews.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Client Reviews App</h1>
    </div>

    <div class="row">
        <form name="ReviewsForm" id="reviewsForm" runat="server" method="post" >
            <asp:Button id="reviewsButton" Text="Submit" runat="server" />
        </form>
    </div>

</asp:Content>
