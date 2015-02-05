var specialConsole = (function () {

    function writeLine(message, args) {
        if (args == undefined) {
            console.log(message);
        }
        else {
            console.log(format(message, args));         
        }     
    }

    function writeError(message, args) {
        console.error(format(message, args));
    }

    function writeWarning(message, args) {
        console.warn(format(message, args));
    }

    function format(str, argss) {
        var selfArguments = [];
        selfArguments.push(-1);

        if (typeof(argss) == 'string') {
            selfArguments.push(argss);
        }
        else {
            for (var i = 0; i < argss.length; i++) {
                selfArguments.push(argss[i]);
            }
        }       

        return str.replace(/\{(\d+)\}/g, function (match, arg) {
            return selfArguments[+arg + 1];
        })
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    };
}());