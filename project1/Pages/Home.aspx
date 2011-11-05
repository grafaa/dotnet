<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Pages.Home" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
        <asp:ScriptManagerProxy ID="CarrouselScript" runat="server">
            <Scripts>
                <asp:ScriptReference Path="~/Scripts/carrousel.js" />
            </Scripts>
        </asp:ScriptManagerProxy>
        <div class="infiniteCarousel">
            <div class="wrapper"> 
                <ul>
	                <li>
                        <img src="../Images/Test/1218633623880.jpg" alt="a" height="400px" width="600px" />
                        <div class="img_lbl_div_class">
                            <asp:Label runat="server" class="image_label_class" Text="Crazy isnt?"></asp:Label>
                        </div>
                    </li>
	                <li>
                        <img src="../Images/Test/1218633773171.jpg" alt="b" height="400px" width="600px"/>
                        <div class="img_lbl_div_class">
                            <asp:Label ID="Label1" runat="server" class="image_label_class" Text="Crazy isnt?"></asp:Label>
                        </div>
                    </li>
	                <li>
                        <img src="../Images/Test/1218641130700.jpg" alt="c" height="400px" width="600px"/>
                        <div class="img_lbl_div_class">
                            <asp:Label ID="Label2" runat="server" class="image_label_class" Text="Crazy isnt?"></asp:Label>
                        </div>
                    </li>
	                <li>
                        <img src="../Images/Test/1218700775965.jpg" alt="d" height="400px" width="600px"/>
                        <div class="img_lbl_div_class">
                            <asp:Label ID="Label3" runat="server" class="image_label_class" Text="Crazy isnt?"></asp:Label>
                        </div>
                    </li>
	                <li>
                        <img src="../Images/Test/1219027230810.jpg" alt="e" height="400px" width="600px"/>
                        <div class="img_lbl_div_class">
                            <asp:Label ID="Label4" runat="server" class="image_label_class" Text="Crazy isnt?"></asp:Label>
                        </div>
                    </li>
	            </ul>
            </div>
        </div>
        <div class="carrousel_min">
            <ul class="carrousel_min">
	            <li><img src="../Images/Test/1218633623880.jpg" alt="a" height="80px" width="100px" /></li>
	            <li><img src="../Images/Test/1218633773171.jpg" alt="b" height="80px" width="100px"/></li>
	            <li><img src="../Images/Test/1218641130700.jpg" alt="c" height="80px" width="100px"/></li>
	            <li><img src="../Images/Test/1218700775965.jpg" alt="d" height="80px" width="100px"/></li>
	            <li><img src="../Images/Test/1219027230810.jpg" alt="e" height="80px" width="100px"/></li>
	        </ul>
        </div>
</asp:Content>