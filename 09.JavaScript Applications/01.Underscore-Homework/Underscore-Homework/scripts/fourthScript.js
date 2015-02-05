(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('underscore.js');
    }

    var Animal = Object.create({
        init: function (type, legs) {
            this.type = type;
            this.legs = legs;
            return this;
        }
    });

    var animals = [
		Object.create(Animal).init('Lion', 4),
		Object.create(Animal).init('Frog', 4),
		Object.create(Animal).init('Kangaroo', 2),
		Object.create(Animal).init('Octopus', 5),
		Object.create(Animal).init('Horse', 4)
    ];

    //Write a function that by a given array of animals, groups them by species and sorts them by number of legs

    var grupedBySpecies = _.groupBy(animals, "type");
    console.log(grupedBySpecies);

    var sortByLegs = _.sortBy(grupedBySpecies, function (animal) { return animal.legs });
    console.log(sortByLegs);
}());