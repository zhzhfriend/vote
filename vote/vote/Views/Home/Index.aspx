<%@ Page Language="C#"%>
<head id="Head2" runat="server">
<script>

    function disp_alert(i) {
        var a = "投票成功！！"+i
        alert(a)
    }

    function createTable() {
        with (document) {
            write("<table border='1' height='3000' width='900' align='center'  cellpadding=0 cellspacing=0>");
            write("<tr height='300'></tr>");
            for (var i = 0; i < 10; i++) {
                write("<tr>");
                for (var j = 0; j < 3; j++) {
                    write("<td>");
                    write("<table border='1'height='280' width='280' align='center' cellpadding=0 cellspacing=0  >");
                    write("<tr height='80%'></tr>");

                    write("<tr height='10%' align='center' ><td colspan='2'><p>恰同学</p></td></tr>");

                    write("<tr height='10%'>");

                    write("<td width='50%'>");
                    write("<label for='male' align='left' >当前投票数</label>");
                    write("<label for='male' >   </label>");
                    write("<label for='count' align='right'>2</label>");
                    write("</td>");
                    write("<td align='center' width='50%'>");

                    write("<input type='button' onclick='disp_alert(i) ' value='投票' id='i' />");

                    write("</td>");

                    write("</tr>");
                    write("</table>");
                    write("</td>");
                }

                write("</tr>");
            }
            write("</table>")
        }
    }
</script>
</head>
<body onload="createTable()" id="showText"></body>
