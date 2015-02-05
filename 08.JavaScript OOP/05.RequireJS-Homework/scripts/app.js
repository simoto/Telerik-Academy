/// <reference path="libs/jquery.js" />
/// <reference path="libs/handlebars-v1.3.0.js" />
(function () {
  require.config({
    paths: {
      "jquery": "libs/jquery",
	  "handlebars": "libs/handlebars-v1.3.0",
	  "comboBox": "scriptfiles/combo-box",
	  "template": "scriptfiles/template"
    }
});

require(["jquery", "template", "comboBox"], function ($) {
    var people = [
		{ id: 1, name: "Doncho Minkov", age: 18, avatarUrl: "images/doncho.png" }, 
		{ id: 2, name: "Nikolay Kostov", age: 19, avatarUrl: "images/NikolayKostov.jpg" },
		{ id: 3, name: "Ivo Kenov", age: 18, avatarUrl: "images/ivailo.jpeg"}];

		$("#mainDiv").template(people);
        $("#mainDiv").comboBox();
  });
}());
