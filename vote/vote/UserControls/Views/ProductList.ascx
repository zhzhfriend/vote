<%@ Control Language="C#" Inherits="vote.UserControls.CodeBehind.ProductsList" CodeBehind="~/UserControls/CodeBeind/ProductList.cs" %>

<asp:Panel runat="server" ID="pnlProductsList">
    <ul class="products">
        <asp:Repeater ID="rptProducts" runat="server">
            <ItemTemplate>
                <li>
                    <image src="<%# Eval("pic") %>" alt="<%#Eval("title") %>" width="180" height="190" />
                    <div class="title"><a href="productDetail.aspx?id=<%#Eval("Id")%>" target="_blank"><%#Eval ("title") %></a></div>
                    <div class="voteCounts">Æ±Êý: <%#Eval("VoteCount")%></div>
                    <input type="image" src="content/vote.png" value="Í¶Æ±" class="btnVote" productid="<%# Eval("Id")%>" />
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</asp:Panel>
<asp:Label runat="server" ID="lblNoProducts">No Products Currently</asp:Label>