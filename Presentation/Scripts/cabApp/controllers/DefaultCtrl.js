/// <reference path="../../types/reference.ts" />
var DefaultModule;
(function (DefaultModule) {
    var Controller = (function () {
        // dfg
        function Controller($scope, valuteService) {
            this.listValute = [
                { Name: 'USD', Code: '84034sd' },
                { Name: 'EUR', Code: '926' },
                { Name: 'YUN', Code: '555' }
            ];
            this.valuteService = valuteService;

            this.getValuteList();
        }
        Controller.prototype.getValuteList = function () {
            var _this = this;
            this.valuteService.getValuteList().then(function (resultList) {
                _this.list = resultList;
            });
        };
        Controller.$inject = ['$scope', 'valuteService'];
        return Controller;
    })();
    DefaultModule.Controller = Controller;
})(DefaultModule || (DefaultModule = {}));
