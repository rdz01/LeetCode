describe('App Initiation Test', function () {
    beforeEach(angular.mock.module("leetCodeApp"));

    it('should initialize correctly', function () {
        expect(leetCodeApp).toBeDefined();
    });
});
