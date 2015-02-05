(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('underscore.js');
    }

    var Person = Object.create({
        init: function (fname, lname) {
            this.fname = fname;
            this.lname = lname;
            return this;
        }
    });

    var people = [
		Object.create(Person).init('Peter', 'Petrov'),
		Object.create(Person).init('Peter', 'Ivanov'),
		Object.create(Person).init('Georgi', 'Ivanov'),
		Object.create(Person).init('Aleksandur', 'Georgiev'),
        Object.create(Person).init('Georgi', 'Georgiev'),
        Object.create(Person).init('Peter', 'Georgiev')
    ];

    //By an array of people find the most common first and last name. Use underscore.
    var mostCommonFirstName = _.chain(people)
                  .countBy(function (person) { return person.fname })
                  .pairs()
                  .max(_.last)
                  .head()
                  .value();
    console.log(mostCommonFirstName);

    var mostCommonLastName = _.chain(people)
                  .countBy(function (person) { return person.lname })
                  .pairs()
                  .max(_.last)
                  .head()
                  .value();
    console.log(mostCommonLastName);
   
}());