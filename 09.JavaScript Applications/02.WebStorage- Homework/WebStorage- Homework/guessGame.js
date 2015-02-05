var input,
    generatedDigits = {},
    sheeps = 0,
    rams = 0,
    isRam = {},
    highScores = '',
    steps = 0,
    user = {},
    submit = document.getElementById("submit"),
    endGame = document.getElementById("endgame");

	generateFourDigits();
	checkForHighScore();
	submit.addEventListener("click", readInputField, false);
	endGame.addEventListener("click", endsTheGame, false);

function generateFourDigits() {
    generatedDigits[0] = Math.floor(Math.random() * 9) + 1;
    generatedDigits[1] = Math.floor(Math.random() * 9) + 1;
    generatedDigits[2] = Math.floor(Math.random() * 9) + 1;
    generatedDigits[3] = Math.floor(Math.random() * 9) + 1;

    while (generatedDigits[0] == 0) {
        generatedDigits[0] = Math.floor(Math.random() * 9) + 1;
    }

    console.log(generatedDigits);
}

function checkTheInput() {
    for (var i = 0; i < 4; i++) {
        if (parseInt(input[i]) === generatedDigits[i]) {
            rams += 1;
            isRam[i] = true;
        }
    }

    for (var i = 0; i < 4; i++) {
        for (var j = 0; j < 4; j++) {
            if (isRam[i]) {
                i++;
                j++;
            }
            else {
                if (generatedDigits[i] === parseInt(input[j])) {
                    sheeps += 1;
                }
            }
        }
    }

    document.getElementById("sheeps").innerHTML = "Sheeps: " + sheeps;
    document.getElementById("rams").innerHTML = "Rams: " + rams;
    console.log("Sheeps" + sheeps);
    console.log("Rams" + rams);

}

function readInputField() {
    var inputValue = document.getElementById("input").value;
    steps++;
    input = inputValue;
    input = input.trim();
    sheeps = 0;
    rams = 0;
    checkTheInput();
}

function endsTheGame() {
    var userName = prompt("Enter your name: ", "Player");
    user["username"] = userName;
    user["steps"] = steps;
    user["rams"] = rams;

    localStorage[userName] = JSON.stringify(user);

    checkForHighScore();
}

function clearLocalStorage() {
    localStorage.clear();
}

function checkForHighScore() {
    if (localStorage.length != 0) {
        for (var key in localStorage) {
            highScores += "<li>" + key + "</li>";
        }
        console.log(localStorage);
        document.getElementById("highscores").innerHTML += highScores;
    }
}