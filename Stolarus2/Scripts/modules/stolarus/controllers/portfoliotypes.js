var PortfolioTypesController = function ($scope, $http, $timeout) {

    var baseUrl = "/api";

    var vm = this;
    vm.Id = Math.random();
    vm.isBusy = false;

    function init() {
        getPortfolioTypes();
    }

    function getPortfolioTypes() {

        vm.isBusy = true;

        var url = baseUrl + "/PortfolioTypes";

        $http({
            method: 'GET',
            url: url
        }).then(
            function (response) {

                var portfoliotypes = response.data;

                console.log("Data received > " + portfoliotypes.length);

                vm.portfoliotypes = portfoliotypes;

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

PortfolioTypesController.$inject = ['$scope', '$http', '$timeout'];