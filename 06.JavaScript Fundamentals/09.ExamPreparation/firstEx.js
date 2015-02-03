

function Solve(args) {

    //read input data
    var countNumbers = parseInt(args[0]);
    var inputLines = new Array(countNumbers);
    var i;
    for (i = 0; i < countNumbers; i++) {
        inputLines[i] = parseInt(args[i + 1]);
    }

    //call function to count the sequences
    function countSequences(countNumbers, inputLines) {
        //declaration of counters
        var j;
        var countSequences = 0;

        for (j = 1; j < countNumbers; j++) {
            if (inputLines[j] < inputLines[j - 1]) { //check if the sequence is non-decreasing
                countSequences++;
            }
            if (j == countNumbers - 1) {
                countSequences++;
            }
        }
        return countSequences;
    }
    var endCount = countSequences(countNumbers, inputLines);
    return endCount;
}



var a = Solve([9, 1, 8, 8, 7, 6, 5, 7, 7, 6]);
console.log(a);