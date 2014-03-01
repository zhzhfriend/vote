<%@ Control Language="C#" Inherits="vote.UserControls.CodeBehind.ProductsList" CodeBehind="~/UserControls/CodeBeind/ProductList.cs" %>

This is from UC
<asp:Panel runat="server" id="pnlProductsList">
<ul>
<asp:Repeater id="rptProducts" runat="server">
	<ItemTemplate>
<li><%# Eval("Id")%></li>
	</ItemTemplate>
</asp:Repeater>
	</ul>
	</asp:Panel>
	<asp:Label runat="server" id="lblNoProducts">No Votes Now</asp:Label>