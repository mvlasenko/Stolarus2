var PortfoliosController = function ($scope, $http, $timeout) {

    var baseUrl = "/api";

    var vm = this;
    vm.Id = Math.random();
    vm.isBusy = false;

    function init() {
        getPortfolios();
    }

    function getPortfolios() {

        vm.isBusy = true;

        var url = baseUrl + "/Portfolios";

        $http({
            method: 'GET',
            url: url
        }).then(
            function (response) {

                var portfolios = response.data;

                console.log("Data received > " + portfolios.length);

                vm.portfolios = portfolios;

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

PortfoliosController.$inject = ['$scope', '$http', '$timeout'];