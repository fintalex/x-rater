var AppModule;
(function (AppModule) {
    angular.module('xraterApp', []).config(function ($logProvider) {
        $logProvider.debugEnabled(true);
    }).run(function ($rootScope) {
        $rootScope.appStarted = new Date();
    });
})(AppModule || (AppModule = {}));
