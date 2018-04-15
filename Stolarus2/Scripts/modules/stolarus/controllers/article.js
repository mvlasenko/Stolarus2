var ArticleController = function ($scope, $http, $timeout) {

    var baseUrl = "/api";

    var vm = this;
    vm.Id = Math.random();
    vm.isBusy = false;

    function init() {
        getArticle();
    }

    function getArticle() {

        vm.isBusy = true;

        var url = baseUrl + "/Article";

        $http({
            method: 'GET',
            url: url
        }).then(
            function (response) {

                var article = response.data;

                console.log("Data received > " + article.length);

                vm.article = article;

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

ArticleController.$inject = ['$scope', '$http', '$timeout'];