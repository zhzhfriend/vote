<%@ Page Language="C#" CodeBehind="Default.aspx.cs" Inherits="vote.Default" EnableViewState="false" %>

<%@ Register Src="~/UserControls/Views/ProductList.ascx" TagName="productsList" TagPrefix="uc" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
    <title>"纳薇 东华杯"第八届中国大学生服装立体剪裁大赛</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="Content/site.css" />
    <link rel="stylesheet" type="text/css" href="Content/css/blitzer/jquery-ui-1.10.4.custom.min.css" />
    <script type="text/javascript" src="Content/jquery-2.1.0.min.js"></script>
    <script type="text/javascript" src="Content/Default.js"></script>
    <script type="text/javascript" src="Content/jquery-ui-1.10.4.custom.min.js"></script>
</head>
<body>
    <div class="header">
        <img src="content/header1.png" alt="纳薇 东华杯第八届中国大学生服装立体剪裁大赛" />
    </div>
    <div class="main">
        <form id="form1" runat="server">
            <uc:productsList runat="server" ID="UCProductsList"></uc:productsList>
        </form>
    </div>
    <div class="footer">
        <img src="content/footer.png" alt="纳薇 东华杯第八届中国大学生服装立体剪裁大赛" />
    </div>
    <div id="dialog-modal" title="请输入验证码">
        <input type="text" id="txtRandomCode" /><span id="randomCode"><%=RandomCode%></span><input type="button" id="btnSubmit" value="提交" />
    </div>
</body>
</html>
