var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Employee = (function (_super) {
    __extends(Employee, _super);
    function Employee(firstName, lastName, age, profession, salary) {
        _super.call(this, firstName, lastName, age);
        this.profession = profession;
        this.salary = salary;
    }
    Employee.prototype.greet = function () {
        return "Hi, my name is " + this.firstName + ", nice to meet you!";
    };
    return Employee;
})(Person);
//# sourceMappingURL=Employee.js.map
