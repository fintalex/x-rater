﻿/// <reference path="../../types/reference.ts" />
var ValutesModule;
(function (ValutesModule) {
    var Controller = (function () {
        /** конструктор **/
        function Controller($scope, valuteService) {
            this.arrayCurs = [];
            this.seriesForCurs = [];
            // set current date and 3 month ago
            var curDate = new Date();
            curDate.setMonth(curDate.getMonth() - 3);
            this.chosenDataFrom = curDate;
            this.chosenDataTo = new Date();

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
            this.valuteService.getDynamicOfCurs(this.chosenDataFrom, this.chosenDataTo, this.chosenValute.Vcode).then(function (resList) {
                _this.listDynamicCurs = resList;

                // делаем маппинг(на курс и дату) с андерскором для получения массива значений
                //this.arrayCurs = [];
                var tempArray = [];
                tempArray = _.map(resList, function (item) {
                    return [new Date(item.CursDate).getTime(), item.Vcurs];
                });

                var name = angular.copy(_this.chosenValute.Vname);
                _this.seriesForCurs.push({
                    name: name,
                    data: tempArray
                });

                //this.customiseChart();
                _this.chart.addSeries({
                    name: name,
                    data: tempArray
                });
            });
        };

        /** Выбор валюты sdf **/
        Controller.prototype.chosenValuteChanged = function () {
            this.getDynamicCurs();
        };

        Controller.prototype.customiseChart = function () {
            // setOptions - doesn't need because it need only for global and lang
            this.chart = new Highcharts.Chart({
                chart: {
                    type: 'spline',
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
                    enabled: true
                },
                plotOptions: {},
                series: this.seriesForCurs
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
