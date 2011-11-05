<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="UserControls.Menu.Menu" %>
<%@ Register Src="~/UserControls/Menu/ElementMenu.ascx" TagPrefix="uc1" TagName="ElementMenu" %>
<ul id="HorizentalMenu">
   <li>
        <uc1:ElementMenu ID="HomeItem" runat="server" LblElement="Home" UrlElement="~/Pages/Home.aspx" />
   </li>
   <li>
        <uc1:ElementMenu ID="CustomizeItem" runat="server" LblElement="Customize" UrlElement="~/Pages/Customize.aspx" />
   </li>
</ul>