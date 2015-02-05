(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('underscore.js');
    }

    var Student = Object.create({
        init: function (fname, lname, age, mark) {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            this.mark = mark;
            return this;
        },
        toString: function () {
            return this.fname + ' ' + this.lname;
        }
    });

    var people = [
		Object.create(Student).init('Doncho', 'Minkov', 45, 140),
		Object.create(Student).init('Nikolay', 'Kostov', 34, 130),
		Object.create(Student).init('Aneliya', 'Stoyanova', 18, 160),
		Object.create(Student).init('Ivaylo', 'Kenov', 87, 200),
		Object.create(Student).init('Todor', 'Stoyanov', 56, 95)
    ];

    // Write function that finds the first name and last name of all students with age between 18 and 24. 
    var sortByMark = _.sortBy(people, function (person) {
        return person.mark;
    }).reverse();

    var highestMark = _.first(sortByMark);
    console.log(highestMark);
}());