/// <reference path="../../types/reference.ts" />
var ValutesModule;
(function (ValutesModule) {
    var Controller = (function () {
        /** конструктор **/
        function Controller($scope, valuteService) {
            this.arrayCurs = [50];
            this.valuteService = valuteService;

            this.getValuteList();

            this.customiseChart();
        }
        Controller.prototype.getValuteList = function () {
            var _this = this;
            this.valuteService.getValuteList().then(function (resultList) {
                _this.listValute = resultList;
            });
        };

        /** Получения динамики изменений по курсу валюты !**/
        Controller.prototype.getDynamicCurs = function () {
            var _this = this;
            this.valuteService.getDynamicOfCurs(null, null, this.chosenValute.Vcode).then(function (resList) {
                _this.listDynamicCurs = resList;

                // делаем маппинг с андерскором для получения массива значений
                _this.arrayCurs = [];
                _this.arrayCurs = _.map(resList, function (item) {
                    return item.Vcurs;
                });
                _this.customiseChart();
            });
        };

        /** Выбор валюты **/
        Controller.prototype.chosenValuteChanged = function () {
            this.getDynamicCurs();
        };

        Controller.prototype.customiseChart = function () {
            // setOptions - doesn't need because it need only for global and lang
            var chart2 = new Highcharts.Chart({
                chart: {
                    renderTo: 'container',
                    height: 400,
                    spacingRight: 20,
                    zoomType: 'x'
                },
                title: {
                    text: 'exchange rate for last 3 months'
                },
                subtitle: {
                    text: 'Click and drag in the plot area to zoom in'
                },
                xAxis: {
                    type: 'datetime',
                    minRange: 14 * 24 * 3600000
                },
                yAxis: {
                    title: {
                        text: 'Exchange rate'
                    }
                },
                legend: {
                    enabled: false
                },
                plotOptions: {
                    area: {
                        fillColor: {
                            linearGradient: { x0: 0, y0: 0, x1: 0, y1: 1 },
                            stops: [
                                [0, Highcharts.getOptions().colors[0]],
                                [1, Highcharts.Color(Highcharts.getOptions().colors[0]).setOpacity(0).get('rgba')]
                            ]
                        },
                        marker: {
                            radius: 2
                        },
                        lineWidth: 1,
                        states: {
                            hover: {
                                lineWidth: 1
                            }
                        },
                        threshold: null
                    }
                },
                series: [{
                        type: 'area',
                        name: 'USD to EUR',
                        pointInterval: 24 * 3600 * 1000,
                        pointStart: Date.UTC(2015, 0, 1),
                        data: this.arrayCurs
                    }]
            });
            //var div: HTMLDivElement;
            //var r = new Highcharts.Renderer(div, 20, 30);
            //var box = r.text("Hello", 10, 10).getBBox();
            //var highChartSettings: HighchartsOptions = {
            //    chart: {
            //        width: 400,
            //        height: 400
            //    },
            //    xAxis: [{
            //    }],
            //    series: [<HighchartsPieChartSeriesOptions>{
            //        data: [29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4]
            //    }]
            //};
            //var container = $("#container").highcharts( (chart) => {
            //    chart.series[0].setVisible(true, true);
            //});
        };
        Controller.$inject = ['$scope', 'valuteService'];
        return Controller;
    })();
    ValutesModule.Controller = Controller;
})(ValutesModule || (ValutesModule = {}));
//# sourceMappingURL=valuteCtrl.js.map
