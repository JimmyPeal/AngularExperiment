var app = angular.module('angularjs-starter', []);

app.controller('MainController', function ($scope) {


    var img = "https://www.circuitspecialists.com/content/image/130898/200/nema23.jpg";

    $scope.message = 'Some Guy';
    var person = {
        firstname: "jim",
        lastname: "peal",
        imageSrc: img
    };

    $scope.person = person;
});