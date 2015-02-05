(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('underscore.js');
    }

    var Author = Object.create({
        init: function (name, numberOfBooks) {
            this.name = name;
            this.numberOfBooks = numberOfBooks;
            return this;
        }
    });

    var authors = [
		Object.create(Author).init('Svetlin Nakov', 6),
		Object.create(Author).init('Agatha Christie', 50),
		Object.create(Author).init('Stephen King', 100),
		Object.create(Author).init('Octopus', 40),
    ];

    //By a given collection of books, find the most popular author (the author with the highest number of books)

    var mostPopularAuthor = _.max(authors, function (author) { return author.numberOfBooks });
    console.log(mostPopularAuthor);
}());