var products = {
    shoes: {
        Boots: [
            { id: 1, size: 40, color: "red", price: 110 },
            { id: 2, size: 41, color: "brown", price: 120 },
            { id: 3, size: 42, color: "black", price: 125 }
        ],
        Sneakers: [
            { id: 4, size: 42, color: "white", price: 140 },
            { id: 5, size: 44, color: "grey", price: 150 },
            { id: 6, size: 45, color: "green", price: 200 }
        ],
        Sandals: [
            { id: 7, size: 40, color: "yellow", price: 135 },
            { id: 8, size: 43, color: "blue", price: 145 },
            { id: 9, size: 41, color: "red", price: 115 },
            { id: 10, size: 42, color: "black", price: 125 }
        ]
    }
};
//2
var ProductIterator = /** @class */ (function () {
    function ProductIterator(item) {
        this.items = [];
        this.position = -1;
        var buff = item.shoes.Boots.concat(item.shoes.Sandals);
        this.items = buff.concat(item.shoes.Sneakers);
        this.length = item.shoes.Boots.length + item.shoes.Sneakers.length + item.shoes.Sandals.length;
    }
    ProductIterator.prototype.getByIndex = function (i) {
        if (i < 0 || i > this.length)
            return "out of the range";
        return this.items[i];
    };
    ProductIterator.prototype.next = function () {
        if (this.position + 1 > this.length)
            this.position = -1;
        this.position++;
        return this.items[this.position];
    };
    ProductIterator.prototype.valid = function () {
        return this.position + 1 < this.length;
    };
    return ProductIterator;
}());
console.log("\n~iterator~");
var iterator = new ProductIterator(products);
while (iterator.valid()) {
    console.log(iterator.next());
}
console.log("\n", iterator.getByIndex(8));
//3
function sort(start_price, end_price, color, size) {
    var result1 = products.shoes.Boots.filter(function (item) {
        return item.price > start_price &&
            item.price < end_price &&
            item.color === color &&
            item.size === size;
    });
    var result2 = products.shoes.Sneakers.filter(function (item) {
        return item.price > start_price &&
            item.price < end_price &&
            item.color === color &&
            item.size === size;
    });
    var result3 = products.shoes.Sandals.filter(function (item) {
        return item.price > start_price &&
            item.price < end_price &&
            item.color === color &&
            item.size === size;
    });
    var buff = result1.concat(result2);
    var result = buff.concat(result3);
    for (var _i = 0, result_1 = result; _i < result_1.length; _i++) {
        var item = result_1[_i];
        console.log(item.id);
    }
}
console.log("~sort~");
sort(100, 150, "black", 42);
//5
var newProducts = {
    shoes: {
        Boots: [
            { id: 1, size: 40, color: "red", price: 110, discount: 50, get end_price() { return this.price - this.price * this.discount / 100; }, set end_price(parm) { this.price = parm / (1 - this.discount / 100); } },
            { id: 1, size: 40, color: "red", price: 110, discount: 40, get end_price() { return this.price - this.price * this.discount / 100; }, set end_price(parm) { this.price = parm / (1 - this.discount / 100); } },
            { id: 2, size: 41, color: "brown", price: 120, discount: 55, get end_price() { return this.price - this.price * this.discount / 100; }, set end_price(parm) { this.price = parm / (1 - this.discount / 100); } },
            { id: 3, size: 42, color: "black", price: 125, discount: 45, get end_price() { return this.price - this.price * this.discount / 100; }, set end_price(parm) { this.price = parm / (1 - this.discount / 100); } }
        ],
        Sneakers: [
            { id: 4, size: 42, color: "white", price: 140, discount: 10, get end_price() { return this.price - this.price * this.discount / 100; }, set end_price(parm) { this.price = parm / (1 - this.discount / 100); } },
            { id: 5, size: 44, color: "grey", price: 150, discount: 20, get end_price() { return this.price - this.price * this.discount / 100; }, set end_price(parm) { this.price = parm / (1 - this.discount / 100); } },
            { id: 6, size: 45, color: "green", price: 200, discount: 30, get end_price() { return this.price - this.price * this.discount / 100; }, set end_price(parm) { this.price = parm / (1 - this.discount / 100); } }
        ],
        Sandals: [
            { id: 7, size: 40, color: "yellow", price: 135, discount: 25, get end_price() { return this.price - this.price * this.discount / 100; }, set end_price(parm) { this.price = parm / (1 - this.discount / 100); } },
            { id: 8, size: 43, color: "blue", price: 145, discount: 5, get end_price() { return this.price - this.price * this.discount / 100; }, set end_price(parm) { this.price = parm / (1 - this.discount / 100); } },
            { id: 9, size: 41, color: "red", price: 115, discount: 1, get end_price() { return this.price - this.price * this.discount / 100; }, set end_price(parm) { this.price = parm / (1 - this.discount / 100); } }
        ]
    }
};
console.log("\n~get~");
for (var _i = 0, _a = newProducts.shoes.Boots; _i < _a.length; _i++) {
    var item = _a[_i];
    console.log("end_price: ", item.end_price);
}
for (var _b = 0, _c = newProducts.shoes.Sneakers; _b < _c.length; _b++) {
    var item = _c[_b];
    console.log("end_price: ", item.end_price);
}
for (var _d = 0, _e = newProducts.shoes.Sandals; _d < _e.length; _d++) {
    var item = _e[_d];
    console.log("end_price: ", item.end_price);
}
console.log("\n~set~");
for (var _f = 0, _g = newProducts.shoes.Boots; _f < _g.length; _f++) {
    var item = _g[_f];
    item.end_price = 500;
    console.log("new end price: " + item.end_price + ", discount: " + item.discount + ", price: " + item.price);
}
