var ContactsController = function ($scope, $http, $timeout) {

    var baseUrl = "/api";

    var vm = this;
    vm.Id = Math.random();
    vm.isBusy = false;

    function init() {
        getContacts();
    }

    function getContacts() {

        vm.isBusy = true;

        var url = baseUrl + "/Contacts";

        $http({
            method: 'GET',
            url: url
        }).then(
            function (response) {

                var contacts = response.data;

                console.log("Data received > " + contacts.length);

                vm.contacts = contacts;

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

ContactsController.$inject = ['$scope', '$http', '$timeout'];