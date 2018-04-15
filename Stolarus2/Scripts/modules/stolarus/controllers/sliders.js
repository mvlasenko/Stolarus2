var SlidersController = function ($scope, $http, $timeout) {

    var baseUrl = "/api";

    var vm = this;
    vm.Id = Math.random();
    vm.isBusy = false;

    function init() {
        getSliders();
    }

    function getSliders() {

        vm.isBusy = true;

        var url = baseUrl + "/Sliders";

        $http({
            method: 'GET',
            url: url
        }).then(
            function (response) {

                var sliders = response.data;

                console.log("Data received > " + sliders.length);

                vm.sliders = sliders;

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

SlidersController.$inject = ['$scope', '$http', '$timeout'];