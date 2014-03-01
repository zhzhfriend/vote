<%@ Page Language="C#" codeBehind="Default.aspx.cs" Inherits="vote.Default" %>
<%@ Register src="~/UserControls/Views/ProductList.ascx" tagname="productsList" tagprefix="uc" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
	<title>Default</title>
	<script runat="server">
	
	</script>
</head>
<body>
	<form id="form1" runat="server">
	<uc:productsList runat="server" id="UCProductsList"></uc:productsList>
	</form>
</body>
</html>
