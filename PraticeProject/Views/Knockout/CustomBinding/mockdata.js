var mockdata = (function () {
    var getProducts = function () {
        var products = [];
        products.push(new Product()
            .id(1).price(599.99)
            .model('Taylor 314ce')
            .description('cool guitar')
        );
        products.push(new Product()
            .id(2).price(849.99)
            .model('Taylor 614ce')
            .description('wicked cool guitar')
        );
        products.push(new Product()
            .id(3).price(999.99)
            .model('Taylor 714ce')
            .description('even cooler guitar')
        );
        return products;
    };

    var mockdata = {
        getProducts: getProducts
    };

    return mockdata;
})();