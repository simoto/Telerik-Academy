function Solve(params) {
    var firstLine = params[0].split(" ");
    var answer;

    var nRows = parseInt(firstLine[0]);
    var mCols = parseInt(firstLine[1]);
    var jumps = parseInt(firstLine[2]);

    var secondLine = params[1].split(" ");
    var R = parseInt(secondLine[0]);
    var C = parseInt(secondLine[1]);
    var start = 1;
    var matrix = {};
    var visited = {};
    for (var i = 0; i < nRows; i++) {
        matrix[i] = {};
        visited[i] = {};
        for (var j = 0; j < mCols; j++) {
            matrix[i][j] = start++;
            visited[i][j] = false;
        }
    }

    var jumpArr = [];
    var sum = matrix[R][C];
    var numberOfJumps = 0;
    visited[R][C] = true;
    var isCaught = false;
    var isEscaped = false;
    while (!isCaught && !isEscaped) {
        for (var i = 2; i < 2 + jumps; i++) {
            jumpArr = (params[i].split(" "));
            R += parseInt(jumpArr[0]);
            C += parseInt(jumpArr[1]);
            numberOfJumps++;

            if (((R >= nRows) || (C >= mCols)) || (R < 0 || C < 0)) {
                isEscaped = true;
                answer = "escaped " + sum;
                break;
            }
            if (visited[R][C] == true) {
                isCaught = true;
                answer = "caught " + numberOfJumps;
                break;
            }
            sum += matrix[R][C];
            visited[R][C] = true;

        }
    }

    // console.log(answer);
    // Your code here...
    return answer;
}

Solve(['500 500 3', '0 0', '1 1', '1 2', '-1 -3']);
