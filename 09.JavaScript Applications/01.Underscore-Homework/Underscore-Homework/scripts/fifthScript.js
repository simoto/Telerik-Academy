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
		Object.create(Animal).init('Octopus', 6),
		Object.create(Animal).init('Horse', 4)
    ];

    //By a given array of animals, find the total number of legs

    var totalLegs = 0;

    _.each(animals, function (animal) { totalLegs += animal.legs });
    console.log(totalLegs);
}());