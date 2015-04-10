var AppModule;
(function (AppModule) {
    angular.module('cabinetApp', []).config(function ($logProvider) {
        $logProvider.debugEnabled(true);
    }).run(function ($rootScope) {
        $rootScope.appStarted = new Date();
    });
})(AppModule || (AppModule = {}));
//# sourceMappingURL=app.js.map
