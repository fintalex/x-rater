 
module AppModule {

	angular
		.module('cabinetApp', [
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