/// <reference path="../../types/reference.ts" />

module DefaultModule {
	export class Controller {
		valuteService: any;
		listValute: any;
		chosenValute: any;



		static $inject = ['$scope', 'valuteService'];

		// dfg 
		constructor($scope, valuteService) {
			this.valuteService = valuteService;

			this.getValuteList();
		}
		getValuteList() {
			this.valuteService.getValuteList().then(
				(resultList) => {
					this.listValute = resultList;
				});
		}

		/** Выбор валюты **/
		chosenValuteChanged(): void {

		}
	}
}