var domModule = (function () {
    var container = document.body;
    var buffer = [];

    function appendChild(element, selector) {
        var parent = container.querySelector(selector);
        parent.appendChild(element.cloneNode(true));
    }

    function removeChild(element, selector) {
        var currentElement = container.querySelector(element);
        var removingElement = currentElement.querySelector(selector);
        currentElement.removeChild(removingElement);
    }

    function addHandler(selector, event, func) {
        var currentElements = container.querySelectorAll(selector);
        var itemCount = currentElements.length;
        for (var i = 0; i < itemCount; i++) {
            currentElements[i].addEventListener(event, func, false);
        }
    }

    function appendToBuffer(selector, element) {
        if (buffer.length < 100) {
            var selected = container.querySelector(selector).cloneNode(true);
            selected.appendChild(element);
            buffer.push(selected);
        } else {
            console.log("The buffer is full");
        }
        
        
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer
    };
}());

var div = document.createElement("div");
//appends div to #wrapper
domModule.appendChild(div,"#wrapper"); 
//removes li:first-child from ul
domModule.removeChild("ul","li:first-child"); 
//add handler to each a element with class button
domModule.addHandler("a.button", 'click',        
                     function () { alert("Clicked");});
domModule.appendToBuffer("a:first-of-type", div.cloneNode(true));
//domModule.appendToBuffer("#main-nav ul", navItem);
