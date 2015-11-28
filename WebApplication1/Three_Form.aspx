<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Three_Form.aspx.cs" Inherits="WebApplication1.Three_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Chart/Chart.min.js"></script>
    <script src="Chart/Chart.js"></script>
    <script src="lib/jquery-1.11.3.js"></script>
     <script>

        function drawChart(data, canvasId)
        {
            var ctx = $('#'+canvasId)[0].getContext('2d');
           
            //console.log('var d = ' + data);
            //eval('var d = ' + data);

            new Chart(ctx).Line(data,
            {
                responsive: true
            });
        }

        function evalSample()
        {
            eval('var x = 5 * 2');

            alert(x);
        }

        $(function()
        {
            //evalSample();
                
            //drawChart("{ labels: ['a1', 'a2', 'a3', 'a4', 'a5', 'a6', 'a7'], datasets: [{ label: '#1', fillColor: 'rgba(220,220,220,0.2)', strokeColor: 'rgba(220,220,220,1)', pointColor: 'rgba(220,220,220,1)', pointStrokeColor: '#fff', pointHighlightFill: '#fff', pointHighlightStroke: 'rgba(220,220,220,1)', data: [10, 20, 30, 40, 50, 60, 70] }, { label: '#2', fillColor: 'rgba(151,187,205,0.2)', strokeColor: 'rgba(151,187,205,1)', pointColor: 'rgba(151,187,205,1)', pointStrokeColor: '#fff', pointHighlightFill: '#fff', pointHighlightStroke: 'rgba(151,187,205,1)', data: [200, 150, 100, 50, 60, 100, 70] }] }");
            
            /*
            drawChart({
                labels: ['a1', 'a2', 'a3', 'a4', 'a5', 'a6', 'a7'],
                datasets: [
                    {
                        label: '#1',
                        fillColor: 'rgba(220,220,220,0.2)',
                        strokeColor: 'rgba(220,220,220,1)',
                        pointColor: 'rgba(220,220,220,1)',
                        pointStrokeColor: '#fff',
                        pointHighlightFill: '#fff',
                        pointHighlightStroke: 'rgba(220,220,220,1)',
                        data: [10, 20, 30, 40, 50, 60, 70]
                    },
                    {
                        label: '#2',
                        fillColor: 'rgba(151,187,205,0.2)',
                        strokeColor: 'rgba(151,187,205,1)',
                        pointColor: 'rgba(151,187,205,1)',
                        pointStrokeColor: '#fff',
                        pointHighlightFill: '#fff',
                        pointHighlightStroke: 'rgba(151,187,205,1)',
                        data: [200, 150, 100, 50, 60, 100, 70]
                    }
                ]

            });
            */


        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
        
<canvas id='canvas' height='150' width='300'></canvas>
        <canvas id='canvas1' height='150' width='300'></canvas>
    <div>

    </div>
    </form>
</body>
</html>
