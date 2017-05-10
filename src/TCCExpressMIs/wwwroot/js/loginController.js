app.controller('loginController', function ($scope, $localStorage, $state, $stateParams, $rootScope, LoginService) {
    //$route.current.templateUrl = '/property/' + $routeParams.name + ".html";
    //alert($route.current.templateUrl);
    //$scope.path3 = $location.path();
    $rootScope.bodyStyle = 'background: url(img/backgrounds/' + $stateParams.name + '.jpg) no-repeat center center fixed;-webkit-background-size: cover;-moz-background-size: cover;-o-background-size: cover;background-size: cover';

    $scope.communityName = $stateParams.name;

    var cName = $stateParams.name;

    //$scope.url = $state.href('login', {}, { absolute: true });

    //LoginService.CheckURL(cName).then(function (d) {
    //    if (d) {
    //        console.log(d);
    //    }
    //});

})
.factory('LoginService', function ($http) {
    var fac = {};

    fac.CheckURL = function (d) {
        return $http({
            url: '/api/loginCheck',
            method: 'POST',
            data: JSON.stringify(d),
            headers: { 'content-type': 'application/json' }
        });
    };
    return fac;
});