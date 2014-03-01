<%@ Control Language="C#" ClassName="vote.ProductList" CodeBehind="~/UserControls/CodeBeind/ProductList.cs" %>

This is from UC
<ul>
<asp:Repeater id="rptProducts" runat="server">
	<ItemTemplate>
<li><%# Eval("Id")%></li>
	</ItemTemplate>
</asp:Repeater>
	</ul>