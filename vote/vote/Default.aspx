<%@ Page Language="C#" codeBehind="Default.aspx.cs" Inherits="vote.Default" %>
<%@ Register src="~/UserControls/Views/ProductList.ascx" tagname="productsList" tagprefix="uc" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
<title>"纳薇 东华杯"第八届中国大学生服装立体剪裁大赛</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link rel="stylesheet" type="text/css" href="Content/site.css" />
<script type="text/javascript" src="Content/Default.js"></script>
</head>
<body>
<div class="header">
<img src="content/header.png" alt="纳薇 东华杯第八届中国大学生服装立体剪裁大赛"/>
</div>
<form id="form1" runat="server">
<uc:productsList runat="server" id="UCProductsList"></uc:productsList>
</form>
<div class="footer">
<img src="content/footer.png" alt="纳薇 东华杯第八届中国大学生服装立体剪裁大赛"/>
</div>
</body>
</html>
