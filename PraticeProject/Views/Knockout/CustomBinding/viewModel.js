var vm = (function () {
    var data = mockdata.getProducts();
    var products = ko.observableArray(data);
    var displayGuitars = ko.observable(false);

    var vm = {
        displayGuitars: displayGuitars,
        products: products
    };

    return vm;
})();

ko.applyBindings(vm);