var app = angular.module('moveinScheduler', ['ngStorage', 'ui.router'])
    .config(function ($stateProvider, $urlRouterProvider, $locationProvider) {

        //$locationProvider.html5Mode({
        //    enabled: true,
        //    requireBase: false
        //});

        $locationProvider.html5Mode(true);

        $urlRouterProvider.otherwise('/');
        $locationProvider.hashPrefix('');

        $stateProvider
            .state('index', {
                url: '/',
                templateUrl: 'index.html',
                controller: 'loginController'
            })
            .state('login', {
                url: '/login/:name',
                templateUrl: 'views/login.html',
                controller: 'loginController'
            });

    });