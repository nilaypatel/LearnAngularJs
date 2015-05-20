(function () {
    var app = angular.module("store");
    app.controller("ProductController", function () {
        this.products = products;
    });

    var products = [
        {
            id: 1,
            name: "Product 1",
            price: 1.25,
            description: "Product 1 Description"
        },
        {
            id: 2,
            name: "Product 2",
            price: 1.50,
            description: "Product 2 Description"
        }
    ];
})();