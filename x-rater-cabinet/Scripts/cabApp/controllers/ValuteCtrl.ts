/// <reference path="../../types/reference.ts" />

module ValutesModule {
	export class Controller {
		valuteService: any;
		listValute: any;
		chosenValute: any;
		listDynamicCurs: any;


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

		/** Получения динамики изменений по курсу валюты !**/
		getDynamicCurs() {
			this.valuteService.getDynamicOfCurs(null, null, this.chosenValute.Vcode).then(
				(resList) => {
					this.listDynamicCurs = resList;
				});
		}


		/** Выбор валюты **/
		chosenValuteChanged(): void {
			this.getDynamicCurs();
		}
	}
}