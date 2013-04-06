/// <reference path="../typings/angularjs/angular.d.ts" />
/// <reference path="../typings/angularjs/angular-resource.d.ts" />

class Product{
    constructor (public Name: string, public ThumbnailUrl: string){
    }
}

function ProductListController($scope, $http: ng.IHttpService) {
    $scope.pageSize = 10;
    $scope.currentPage = 0;
    $scope.products = [
        new Product('Produkt 1', 'http://placehold.it/50x50&text=1'),
        new Product('Produkt 2', 'http://placehold.it/50x50&text=2'),
        ];
}