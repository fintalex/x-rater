/// <reference path="../../types/reference.ts" />
var ServiceModule;
(function (ServiceModule) {
    function angularServiceTemplateMethod($http, $q, $log) {
        function angularServiceTemplateMethod(path, parametresJson) {
            $log.debug([new Date().toLocaleTimeString(), path, 'send', parametresJson]); // LOGGER
            var deferred = $q.defer();
            $http.post(path, parametresJson).success(function (data) {
                var result;
                if ('r' in data.d) {
                    result = JSON.parse(data.d.r);
                    $log.debug([new Date().toLocaleTimeString(), path, 'return', result, 'server time', data.d.t]); // LOGGER
                } else {
                    result = data.d;
                    $log.debug([new Date().toLocaleTimeString(), path, 'return', result]); // LOGGER
                }
                deferred.resolve(result);
            }).error(function (err) {
                $log.debug([path, err]);
                deferred.reject(err);
            });

            return deferred.promise;
        }
        return { call: angularServiceTemplateMethod };
    }

    /* выфва */
    function valuteService(angularServiceTemplateMethod) {
        return {
            ROOT: MAIN_ROOT + 'ValuteService.asmx/',
            /* Наши комментарии  */
            getValuteList: function () {
                return angularServiceTemplateMethod.call(this.ROOT + 'GetValuteList', {});
            }
        };
    }

    angular.module('xraterApp').factory('angularServiceTemplateMethod', angularServiceTemplateMethod).factory('valuteService', valuteService);
})(ServiceModule || (ServiceModule = {}));
