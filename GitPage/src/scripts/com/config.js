leetCodeApp.config(function($translateProvider, $translatePartialLoaderProvider) {
    $translatePartialLoaderProvider.addPart('menu');
    $translateProvider.useLoader('$translatePartialLoader', {
        urlTemplate: 'translations/{lang}/{part}.json'
    });
    $translateProvider.preferredLanguage('zh_CN');
});
