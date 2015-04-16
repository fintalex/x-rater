/// <reference path="../../types/reference.ts" />
var ValutesModule;
(function (ValutesModule) {
    var Controller = (function () {
        // dfg
        function Controller($scope, valuteService) {
            this.valuteService = valuteService;

            this.getValuteList();
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
            });
        };

        /** Выбор валюты **/
        Controller.prototype.chosenValuteChanged = function () {
            this.getDynamicCurs();
        };
        Controller.$inject = ['$scope', 'valuteService'];
        return Controller;
    })();
    ValutesModule.Controller = Controller;
})(ValutesModule || (ValutesModule = {}));
