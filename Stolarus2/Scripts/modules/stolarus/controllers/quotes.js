var QuotesController = function ($scope, $http, $timeout) {

    var baseUrl = "/api";

    var vm = this;
    vm.Id = Math.random();
    vm.isBusy = false;

    function init() {
        getQuotes();
    }

    function getQuotes() {

        vm.isBusy = true;

        var url = baseUrl + "/Quotes";

        $http({
            method: 'GET',
            url: url
        }).then(
            function (response) {

                var quotes = response.data;

                console.log("Data received > " + quotes.length);

                vm.quotes = quotes;

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

QuotesController.$inject = ['$scope', '$http', '$timeout'];