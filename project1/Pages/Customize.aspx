<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customize.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Pages.Customize" %>
<%@ Register Assembly="AllControls" Namespace="PictureControls" TagPrefix="cc1" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<div class="cutomize_content_class">
    <div class="images_uploaded clear">
        <div class="img_custom_img float_left">
            <img src="../Images/Test/1218633623880.jpg"  alt="a" height="80px" width="100px" />
        </div>
        <div class="desc_custom float_left">
            <asp:Label runat="server" ID="img_title1" Text="Title1" CssClass="img_title_class" /><br />
            <asp:Label runat="server" ID="img_desc_1" Text="jfdskjdshgisd" CssClass="img_desc_class" />
        </div>
    </div>
    <div class="images_uploaded clear">
        <div class="img_custom_img float_left">
            <img src="../Images/Test/1218633623880.jpg"  alt="a" height="80px" width="100px" />
        </div>
        <div class="desc_custom float_left">
            <asp:Label runat="server" ID="Label1" Text="Title1" CssClass="img_title_class" /><br />
            <asp:Label runat="server" ID="Label2" Text="jfdskjdshgisd" CssClass="img_desc_class" />
        </div>
    </div>
    <%--<div class="images_uploaded clear">--%>
        <cc1:NewPicture ID="NewPicture1" runat="server" />
    <%--</div>--%>

</div>
</asp:Content>