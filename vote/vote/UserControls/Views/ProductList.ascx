<%@ Control Language="C#" Inherits="vote.UserControls.CodeBehind.ProductsList" CodeBehind="~/UserControls/CodeBeind/ProductList.cs" %>

<asp:Panel runat="server" id="pnlProductsList">
	<ul class="products">
		<asp:Repeater id="rptProducts" runat="server">
			<ItemTemplate>
				<li>
                    <%# Eval("Id")%>
                    <img src="<%# Eval("pic") %>" />
                    <%#Eval ("title") %>
                    Æ±Êý: <%#Eval ("Count") %>
                    <input type="button" value="Í¶Æ±" />
				</li>
			</ItemTemplate>
		</asp:Repeater>
	</ul>
</asp:Panel>
<asp:Label runat="server" id="lblNoProducts">No Products Currently</asp:Label>