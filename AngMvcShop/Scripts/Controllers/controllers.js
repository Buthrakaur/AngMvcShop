var Product = (function () {
    function Product(Name, ThumbnailUrl) {
        this.Name = Name;
        this.ThumbnailUrl = ThumbnailUrl;
    }
    return Product;
})();
function ProductListController($scope, $http) {
    $scope.pageSize = 10;
    $scope.currentPage = 0;
    $scope.products = [
        new Product('Produkt 1', 'http://placehold.it/50x50&text=1'), 
        new Product('Produkt 2', 'http://placehold.it/50x50&text=2'), 
        
    ];
}
