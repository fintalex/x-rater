 
module AppModule {

	angular
		.module('xraterApp', [
			//'ngSanitize',
			//'ui.bootstrap',
			//'ui'
		])
		.config(function ($logProvider) {
			$logProvider.debugEnabled(true);
		})
		.run(function ($rootScope) {
			$rootScope.appStarted = new Date();
        });

}