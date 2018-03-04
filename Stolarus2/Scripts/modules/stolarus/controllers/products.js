var ProductsController = function ($scope, $http, $timeout) {

    var baseUrl = "/api";

    var vm = this;
    vm.Id = Math.random();
    vm.isBusy = false;

    function init() {
        getProducts();
    }

    function getProducts() {

        vm.isBusy = true;

        var url = baseUrl + "/Products";

        $http({
            method: 'GET',
            url: url
        }).then(
            function (response) {

                var products = response.data;

                console.log("Data received > " + products.length);

                vm.products = products;

                vm.isBusy = false;

                $timeout(function () {
                    $scope.$broadcast('data-received', vm.Id);
                }, 0);

            },
            function (error) {

                console.log(error, 'error');

            });

        console.log("Request sent to > " + url);
    }

    init();
}

ProductsController.$inject = ['$scope', '$http', '$timeout'];