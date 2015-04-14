/// <reference path="../../types/reference.ts" />
var DefaultModule;
(function (DefaultModule) {
    var Controller = (function () {
        function Controller($scope) {
            this.listValute = [
                { Name: 'USD', Code: '840' },
                { Name: 'EUR', Code: '926' },
                { Name: 'YUN', Code: '555' }
            ];
        }
        Controller.$inject = ['$scope'];
        return Controller;
    })();
    DefaultModule.Controller = Controller;
})(DefaultModule || (DefaultModule = {}));
