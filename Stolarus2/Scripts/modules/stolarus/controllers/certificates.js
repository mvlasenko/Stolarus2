var CertificatesController = function ($scope, $http, $timeout) {

    var baseUrl = "/api";

    var vm = this;
    vm.Id = Math.random();
    vm.isBusy = false;

    function init() {
        getCertificates();
    }

    function getCertificates() {

        vm.isBusy = true;

        var url = baseUrl + "/Certificates";

        $http({
            method: 'GET',
            url: url
        }).then(
            function (response) {

                var certificates = response.data;

                console.log("Data received > " + certificates.length);

                vm.certificates = certificates;

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

CertificatesController.$inject = ['$scope', '$http', '$timeout'];