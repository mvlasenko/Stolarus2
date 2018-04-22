var stolarus2App = angular.module('stolarus2App', []);

stolarus2App.controller('ArticleController', ArticleController);
stolarus2App.controller('CertificatesController', CertificatesController);
stolarus2App.controller('ContactsController', ContactsController);
stolarus2App.controller('PortfolioDetailsController', PortfolioDetailsController);
stolarus2App.controller('PortfoliosController', PortfoliosController);
stolarus2App.controller('PortfolioTypesController', PortfolioTypesController);
stolarus2App.controller('ProductCategoriesController', ProductCategoriesController);
stolarus2App.controller('ProductsController', ProductsController);
stolarus2App.controller('QuotesController', QuotesController);
stolarus2App.controller('SlidersController', SlidersController);


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