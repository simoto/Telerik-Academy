(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('underscore.js');
    }

    var Student = Object.create({
        init: function (fname, lname, age) {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            return this;
        },
        toString: function () {
            return this.fname + ' ' + this.lname;
        }
    });

    var people = [
		Object.create(Student).init('Doncho', 'Minkov', 45),
		Object.create(Student).init('Nikolay', 'Kostov', 34),
		Object.create(Student).init('Aneliya', 'Stoyanova', 18),
		Object.create(Student).init('Ivaylo', 'Kenov', 87),
		Object.create(Student).init('Todor', 'Stoyanov', 56)
    ];

   // Write function that finds the first name and last name of all students with age between 18 and 24. 
    var betweenAge = _.filter(people, function (person) {        
        if (person.age >= 18 && person.age <= 24) {
            return true;
        }        
        return false;
    })

    console.log(betweenAge);
}());