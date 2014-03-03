<%@ Page Language="C#" CodeBehind="~/UserControls/CodeBehind/ProductDetail.cs" Inherits="vote.UserControls.CodeBehind.ProductDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
    <title>作品详细信息 <%=productTitle %></title>
    <script runat="server">
	
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <object width="801" height="801" type="application/x-shockwave-flash" data="<%=pdfSource%>">
            <param name="src" value="<%=pdfSource%>" />
            <param name="quality" value="high" />
        </object>
    </form>
</body>
</html>
