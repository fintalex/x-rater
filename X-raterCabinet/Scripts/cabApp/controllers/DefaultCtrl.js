/// <reference path="../../types/reference.ts" />
var DefaultModule;
(function (DefaultModule) {
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

        /** Выбор валюты **/
        Controller.prototype.chosenValuteChanged = function () {
        };
        Controller.$inject = ['$scope', 'valuteService'];
        return Controller;
    })();
    DefaultModule.Controller = Controller;
})(DefaultModule || (DefaultModule = {}));
