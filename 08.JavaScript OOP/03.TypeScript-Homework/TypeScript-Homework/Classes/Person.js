var Person = (function () {
    function Person(firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    Person.prototype.greet = function () {
        return "Hi, my name is " + this.firstName + ", nice to meet you!";
    };
    return Person;
})();
//# sourceMappingURL=Person.js.map
