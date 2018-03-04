var stolarus2App = angular.module('stolarus2App', []);

stolarus2App.controller('ProductsController', ProductsController);

//var configFunction = function ($routeProvider) {
//    $routeProvider.
//        when('/products', {
//            templateUrl: 'templates/products'
//        })
//        .when('/routeTwo/:donuts', {
//            templateUrl: function (params) { return '/routesDemo/two?donuts=' + params.donuts; }
//        })
//        .when('/routeThree', {
//            templateUrl: 'templates/three'
//        });
//}
//configFunction.$inject = ['$routeProvider'];

//stolarus2App.config(configFunction);