var PortfolioDetailsController = function ($scope, $http, $timeout) {

    var baseUrl = "/api";

    var vm = this;
    vm.Id = Math.random();
    vm.isBusy = false;

    function init() {
        getPortfolioDetails();
    }

    function getPortfolioDetails() {

        vm.isBusy = true;

        var url = baseUrl + "/PortfolioDetails";

        $http({
            method: 'GET',
            url: url
        }).then(
            function (response) {

                var portfoliodetails = response.data;

                console.log("Data received > " + portfoliodetails.length);

                vm.portfoliodetails = portfoliodetails;

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

PortfolioDetailsController.$inject = ['$scope', '$http', '$timeout'];