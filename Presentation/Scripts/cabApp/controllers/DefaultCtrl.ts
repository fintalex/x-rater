/// <reference path="../../types/reference.ts" />

module DefaultModule {
	export class Controller {
		valuteService: any;
		listValute: any = [
			{ Name: 'USD', Code: '84034sd'},
			{ Name: 'EUR', Code: '926'},
			{ Name: 'YUN', Code: '555'}
		];
		list: any;


		static $inject = ['$scope', 'valuteService'];

		// dfg 
		constructor($scope, valuteService) {
			this.valuteService = valuteService;

			this.getValuteList();
		}
		getValuteList() {
			this.valuteService.getValuteList().then(
				(resultList) => {
					this.list = resultList;
				});
		}
	}
}