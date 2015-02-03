function Solve(params) {
    var answer = 0;
    // Your code here...
    var currentCommand;
    var splittedCommands;
    var obj = {};
    //(def func 10)
    //(def newFunc (+  func 2))
    //(def sumFunc (+ func func newFunc 0 0 0))
    //(* sumFunc 2)
    var currentLine = 0;
    for (var i = 0; i < params.length; i++) {


        currentLine++;
        currentCommand = params[i].replace("(", " ").replace(")", " ");
        splittedCommands = clean(currentCommand.trim().split(" "));
        if (splittedCommands.join(' ').indexOf("(") != -1) {
            var paca = splittedCommands.join(" ");
            var subResult = 0;
            var subCommand = paca.substr(paca.indexOf("("));
            subCommand = clean(subCommand.replace("(", " ").replace(")", " ").trim().split(" "));
            subResult += executeCommand(subCommand);
            var firstCommand = clean(paca.substring(0, paca.indexOf("(")).split(" "));
            if (typeof answer != "number") {
                answer = "Division by zero! At Line:" + currentLine;
                break;
            }
            answer = executeCommand(firstCommand, subResult);

        }
        else {
            if (typeof answer != "number") {
                answer = "Division by zero! At Line:" + currentLine;
                break;
            }
            answer = executeCommand(splittedCommands);
        }



    }

    function clean(deleteValue) {
        for (var i = 0; i < deleteValue.length; i++) {
            if (deleteValue[i] == "") {
                deleteValue.splice(i, 1);
                i--;
            }
        }
        return deleteValue;
    }

    function sum(str) {
        var arr = clean(str.split(" "));
        var sumResult = 0;
        for (var i = 0; i < arr.length; i++) {

            if (isNaN(parseInt(arr[i]))) {
                sumResult += obj[arr[i]];
            }
            else {
                sumResult += parseInt(arr[i]);
            }
        }

        return sumResult;
    }

    function difference(str) {
        var arr = clean(str.split(" "));
        var diffResult;
        if (isNaN(parseInt(arr[0]))) {
            diffResult = obj[arr[0]];
        }
        else {
            diffResult = parseInt(arr[0]);
        }

        if (diffResult < 0 && arr.length == 1) {
            diffResult *= -1;
        }
        else {
            for (var i = 1; i < arr.length; i++) {

                if (isNaN(parseInt(arr[i]))) {
                    diffResult -= obj[arr[i]];
                }
                else {
                    diffResult -= parseInt(arr[i]);
                }
            }
        }


        return diffResult;
    }

    function multiple(str) {
        var arr = clean(str.split(" "));
        var multipleResult = 1;
        if (multipleResult < 0 && arr.length == 1) {
            multipleResult *= -1;
        }
        else {
            for (var i = 0; i < arr.length; i++) {

                if (isNaN(parseInt(arr[i]))) {
                    multipleResult *= obj[arr[i]];
                }
                else {
                    multipleResult *= parseInt(arr[i]);
                }
            }
        }

        return multipleResult;
    }

    function divide(str) {
        var arr = clean(str.split(" "));
        var divideResult;
        if (isNaN(parseInt(arr[0]))) {
            divideResult = obj[arr[0]];
        }
        else {
            divideResult = parseInt(arr[0]);
        }
        if (divideResult < 0 && arr.length == 1) {
            divideResult *= -1;
        }
        else {
            for (var i = 1; i < arr.length; i++) {

                if (isNaN(parseInt(arr[i]))) {
                    divideResult /= obj[arr[i]];
                    divideResult |= 0;
                }
                else {
                    if (parseInt(arr[i]) == "0") {
                        return "Division by Zero! At Line:" + currentLine;
                        break;
                    }
                    divideResult /= parseInt(arr[i]);
                    divideResult |= 0;
                }
            }
        }

        return divideResult;
    }

    function executeCommand(giveArr, secondComm) {
        var currArr = giveArr;

        answer = 0;

        switch (currArr[0]) {
            case "def":
                if (secondComm == undefined) {
                    obj[currArr[1]] = parseInt(currArr[2])
                } else {
                    obj[currArr[1]] = secondComm;
                }; break;
            case "+": answer += sum(currArr.join(" ").replace("+", " ").trim()); break;
            case "-": answer += difference(currArr.join(" ").replace("-", " ").trim()); break;
            case "*": answer += multiple(currArr.join(" ").replace("*", " ").trim()); break;
            case "/": answer += divide(currArr.join(" ").replace("/", " ").trim()); break;
            default: break;

        }

        if (typeof answer != "number") {
            return "Division by Zero! At Line:" + currentLine;
        }

        return answer;
    }

    console.log(answer);
    return answer;
}

Solve(["(def     go6o    (/ -7 1 1 1 1) )",
"(def asd (/ 0 5))",
"(def func2 asd  )",
"(           +        4          2      func2)"]);
