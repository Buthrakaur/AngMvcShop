/// <reference path="../typings/angularjs/angular.d.ts" />
/// <reference path="../typings/angularjs/angular-resource.d.ts" />

interface Product{
    Name: string;
    ThumbnailUrl: string;
}

function ProductListController($scope, $http: ng.IHttpService) {
    $scope.pageSize = 10;
    $scope.currentPage = 0;
    $scope.products = [];
    $http.post('/Home/GetProductsPage', { offset: $scope.currentPage, count: $scope.pageSize })
        .success(data => $scope.products = <Product[]>data);
}