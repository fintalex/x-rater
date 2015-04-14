/// <reference path="../../types/reference.ts" />

module DefaultModule {
	export class Controller {
		listValute: any = [
			{ Name: 'USD', Code: '840'},
			{ Name: 'EUR', Code: '926'},
			{ Name: 'YUN', Code: '555'}
		];
		static $inject = ['$scope'];

		constructor($scope) {

		}
	}
}