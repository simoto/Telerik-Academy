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

    function isfNameBeforeLast(person) {
        if (person.fname.toLowerCase() < person.lname.toLowerCase()) {
            return true;
        } else {
            return false;
        }
    }

    function descendingOrder(person1, person2) {
        return person2.toString() - person1.toString();
    }
    //all students whose first name is before its last name alphabetically. 
    var studentsAlphabetically = _.filter(people, isfNameBeforeLast);
    console.log(studentsAlphabetically);

    //Print the students in descending order by full name.
    var sortedByDescending = _.sortBy(studentsAlphabetically, function (person) {
        return person.toString();
    }).reverse();
    console.log(sortedByDescending);


}());