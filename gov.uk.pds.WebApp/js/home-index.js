﻿// home-index.js
var homeIndexModule = angular.module("homeIndex", ['ngRoute']);

homeIndexModule.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.when("/", {
        controller: "BusinessListController",
        templateUrl: "/templates/BusinessListView.html"
    });

    $routeProvider.when("/newmessage", {
        controller: "BusinessDetailViewController",
        templateUrl: "/templates/BusinessDetailView.html"
    });

    $routeProvider.when("/message/:id", {
        controller: "singleTopicController",
        templateUrl: "/templates/singleTopicView.html"
    });

    $routeProvider.otherwise({ redirectTo: "/" });
}])

    //homeIndexModule.factory("dataService", ["$http", "$q", function ($http, $q) {

    //    var _topics = [];
    //    var _isInit = false;

    //    var _isReady = function () {
    //        return _isInit;
    //    }

    //    var _getTopics = function () {

    //        var deferred = $q.defer();

    //        $http.get("/api/v1/topics?includeReplies=true")
    //            .then(function (result) {
    //                // Successful
    //                angular.copy(result.data, _topics);
    //                _isInit = true;
    //                deferred.resolve();
    //            },
    //            function () {
    //                // Error
    //                deferred.reject();
    //            });

    //        return deferred.promise;
    //    };

    //    var _addTopic = function (newTopic) {
    //        var deferred = $q.defer();

    //        $http.post("/api/v1/topics", newTopic)
    //            .then(function (result) {
    //                // success
    //                var newlyCreatedTopic = result.data;
    //                _topics.splice(0, 0, newlyCreatedTopic);
    //                deferred.resolve(newlyCreatedTopic);
    //            },
    //            function () {
    //                // error
    //                deferred.reject();
    //            });

    //        return deferred.promise;
    //    };

    //    function _findTopic(id) {
    //        var found = null;

    //        $.each(_topics, function (i, item) {
    //            if (item.id == id) {
    //                found = item;
    //                return false;
    //            }
    //        });

    //        return found;
    //    }

    //    var _getTopicById = function (id) {
    //        var deferred = $q.defer();

    //        if (_isReady()) {
    //            var topic = _findTopic(id);
    //            if (topic) {
    //                deferred.resolve(topic);
    //            } else {
    //                deferred.reject();
    //            }
    //        } else {
    //            _getTopics()
    //                .then(function () {
    //                    // success
    //                    var topic = _findTopic(id);
    //                    if (topic) {
    //                        deferred.resolve(topic);
    //                    } else {
    //                        deferred.reject();
    //                    }
    //                },
    //                function () {
    //                    // error
    //                    deferred.reject();
    //                });
    //        }

    //        return deferred.promise;
    //    };

    //    var _saveReply = function (topic, newReply) {
    //        var deferred = $q.defer();

    //        $http.post("/api/v1/topics/" + topic.id + "/replies", newReply)
    //            .then(function (result) {
    //                // success
    //                if (topic.replies == null) topic.replies = [];
    //                topic.replies.push(result.data);
    //                deferred.resolve(result.data);
    //            },
    //            function () {
    //                // error
    //                deferred.reject();
    //            });

    //        return deferred.promise;
    //    };

    //    return {
    //        topics: _topics,
    //        getTopics: _getTopics,
    //        addTopic: _addTopic,
    //        isReady: _isReady,
    //        getTopicById: _getTopicById,
    //        saveReply: _saveReply
    //    };
    //}]);

    .controller('BusinessListController', ["$scope", "$http", //"dataService",
        function ($scope, $http, dataService) {
            // $scope.data = dataService;
            $scope.isBusy = false;

            // if (dataService.isReady() == false) {
            $scope.isBusy = true;

            //dataService.getTopics()
            //    .then(function () {
            //        // success
            //    },
            //    function () {
            //        // error
            //        alert("could not load topics");
            //    })
            //    .then(function () {
            //        $scope.isBusy = false;
            //    });
            // }
        }])

    .controller('BusinessDetailViewController', ["$scope", "$http", "$window",/// "dataService",
        function ($scope, $http, $window, dataService) {
            $scope.newTopic = {};

            $scope.save = function () {

              
            };
        }]);


var singleTopicController = ["$scope", "dataService", "$window", "$routeParams",
    function ($scope, dataService, $window, $routeParams) {
        
    }];



