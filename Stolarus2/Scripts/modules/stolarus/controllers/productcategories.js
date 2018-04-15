var ProductCategoriesController = function ($scope, $http, $timeout) {

    var baseUrl = "/api";

    var vm = this;
    vm.Id = Math.random();
    vm.isBusy = false;

    function init() {
        getProductCategories();
    }

    function getProductCategories() {

        vm.isBusy = true;

        var url = baseUrl + "/ProductCategories";

        $http({
            method: 'GET',
            url: url
        }).then(
            function (response) {

                var productcategories = response.data;

                console.log("Data received > " + productcategories.length);

                vm.productcategories = productcategories;

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

ProductCategoriesController.$inject = ['$scope', '$http', '$timeout'];