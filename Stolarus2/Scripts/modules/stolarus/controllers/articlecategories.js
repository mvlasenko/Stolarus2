var ArticleCategoriesController = function ($scope, $http, $timeout) {

    var baseUrl = "/api";

    var vm = this;
    vm.Id = Math.random();
    vm.isBusy = false;

    function init() {
        getArticleCategories();
    }

    function getArticleCategories() {

        vm.isBusy = true;

        var url = baseUrl + "/ArticleCategories";

        $http({
            method: 'GET',
            url: url
        }).then(
            function (response) {

                var articlecategories = response.data;

                console.log("Data received > " + articlecategories.length);

                vm.articlecategories = articlecategories;

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

ArticleCategoriesController.$inject = ['$scope', '$http', '$timeout'];