var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Driver = (function (_super) {
    __extends(Driver, _super);
    function Driver(firstName, lastName, age, car) {
        _super.call(this, firstName, lastName, age);
        this.car = car;
    }
    Driver.prototype.greet = function () {
        return "Hi, I am driver and my name is " + this.firstName + ", nice to meet you!";
    };
    return Driver;
})(Person);
//# sourceMappingURL=Driver.js.map
