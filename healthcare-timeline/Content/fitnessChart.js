var arraydata;
var ctx = document.getElementById("fitnessChart");

var myChart = new Chart(ctx, {
    type: "line",
    data: {
    labels: ["January", "February", "March", "April", "May", "June", "July"],
    datasets: [{
            label: "",
            fill: false,
            lineTension: 0.1,
            backgroundColor: "rgba(0,100,183,0.4)",
            borderColor: "rgba(0,100,183,1)",
            borderCapStyle: 'butt',
            borderDash: [],
            borderDashOffset: 0.0,
            borderJoinStyle: 'miter',
            pointBorderColor: "rgba(0,100,183,1)",
            pointBackgroundColor: "#fff",
            pointBorderWidth: 1,
            pointHoverRadius: 5,
            pointHoverBackgroundColor: "rgba(254,254,254,1)",
            pointHoverBorderColor: "rgba(0,100,183,1)",
            pointHoverBorderWidth: 2,
            pointRadius: 1,
            pointHitRadius: 10,
            data: arraydata ? arraydata : [65, 59, 80, 81, 56, 55],
            spanGaps: false
        }]
    },
    options: {
        legend: {
            display: false
        }
    } 
});