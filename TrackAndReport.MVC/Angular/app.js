/// <reference path="source/angular.min.js" />
(function () {
    'use strict';

    angular.module('app', []).constant('API_ENDPOINT', {
        url: 'http://localhost:12345/api',
    })
})();