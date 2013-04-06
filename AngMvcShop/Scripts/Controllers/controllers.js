function ProductListController($scope, $http) {
    $scope.pageSize = 10;
    $scope.currentPage = 0;
    $scope.products = [];
    $http.post('/Home/GetProductsPage', {
        offset: $scope.currentPage,
        count: $scope.pageSize
    }).success(function (data) {
        return $scope.products = data;
    });
}
