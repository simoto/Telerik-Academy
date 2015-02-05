var snake = (function () {
    var CANVAS = document.getElementById('snakeField');
    var BLOCK_SIZE = 10;
    var CANVAS_WIDTH = CANVAS.clientWidth;
    var CANVAS_HEIGHT = CANVAS.clientHeight;
    var CONTEXT = CANVAS.getContext('2d');
    var NUMBER_OF_APPLES = 1;
    var gameLoopControl;

    var startGame = function () {
        CONTEXT.clearRect(0, 0, CANVAS_WIDTH, CANVAS_HEIGHT);
        var currentSnake = new Snake(6, 40, 20);
        var snakeBody = currentSnake.getSnakeBody();
        keyboardControlWorm(currentSnake);
        var gameElements = [];
        gameElements['snake'] = currentSnake;
        gameElements['apples'] = [];
        for (var i = 0; i < NUMBER_OF_APPLES; i++) {
            gameElements['apples'].push(generateApple());
        }
        clearInterval(gameLoopControl);
        gameLoopControl = setInterval(function () {
            clearBoard();
            drawElements([currentSnake.head], 'green');
            drawElements(snakeBody, 'black');
            drawElements(gameElements['apples'], 'red');
            currentSnake.move();
            detectCollision(gameElements);
        }, 100);
    }

    var endGame = function () {
        clearInterval(gameLoopControl);     
    }



    var clearBoard = function () {
        CONTEXT.clearRect(0, 0, CANVAS_WIDTH, CANVAS_HEIGHT);
    }

    var generateApple = function () {
        var appleXPosition = Math.round((Math.random() * CANVAS_WIDTH - BLOCK_SIZE) / BLOCK_SIZE) * BLOCK_SIZE;
        var appleYPosition = Math.round((Math.random() * CANVAS_HEIGHT - BLOCK_SIZE) / BLOCK_SIZE) * BLOCK_SIZE;
        return new gameBlock(appleXPosition, appleYPosition);
    }

    var gameBlock = function (xPosition, yPosition) {
        if (xPosition % BLOCK_SIZE !== 0 || yPosition % BLOCK_SIZE !== 0) {
            throw new Error("The block coordinates must be within the canvas grid!");
        }

        this.xPosition = xPosition;
        this.yPosition = yPosition;
    }

    var Snake = function (startLength, startX, startY) {
        this.head = new gameBlock(startX, startY);
        snakeBody = new Array(startLength - 1);
        for (var i = 0; i < startLength - 1; i++) {
            snakeBody[i] = new gameBlock(startX - BLOCK_SIZE * (i + 1), startY);
        }

        this.getSnakeBody = function () {
            return snakeBody;
        }

        this.direction = {
            x: 1,
            y: 0
        }

        this.move = function () {
            snakeBody.splice(snakeBody.length - 1, 1);
            snakeBody.unshift(new gameBlock(this.head.xPosition, this.head.yPosition));
            this.head.xPosition += this.direction.x * BLOCK_SIZE;
            this.head.yPosition += this.direction.y * BLOCK_SIZE;
        }
    }

    var drawElements = function (elements, color) {
        CONTEXT.fillStyle = color;
        for (var i = 0; i < elements.length; i++) {
            CONTEXT.fillRect(elements[i].xPosition, elements[i].yPosition, BLOCK_SIZE, BLOCK_SIZE);
        }
    }

    var detectCollision = function (gameElements) {
        var snakeHead = gameElements['snake'].head;
        var snakeBody = gameElements['snake'].getSnakeBody();
        var apples = gameElements['apples'];
        var hitVerticalWall = (snakeHead.xPosition < 0 || snakeHead.xPosition > CANVAS_WIDTH);
        var hitHorizontalWall = (snakeHead.yPosition < 0 || snakeHead.yPosition > CANVAS_HEIGHT);
        if (hitVerticalWall || hitHorizontalWall) {
            endGame();
            return;
        }

        for (var i = 0; i < snakeBody.length; i++) {
            if (snakeHead.xPosition === snakeBody[i].xPosition && snakeHead.yPosition === snakeBody[i].yPosition) {
                endGame();
                return;
            }
        }

        for (var i = 0; i < apples.length; i++) {
            if (apples[i].xPosition === snakeHead.xPosition && apples[i].yPosition === snakeHead.yPosition) {
                var newTailX = snakeBody[snakeBody.length - 1].xPosition * 2 - snakeBody[snakeBody.length - 2].xPosition;
                var newTailY = snakeBody[snakeBody.length - 1].yPosition * 2 - snakeBody[snakeBody.length - 2].yPosition;
                snakeBody.push(new gameBlock(newTailX, newTailY));
                apples.splice(i, 1);
                apples.push(generateApple());
            }
        }
    }

    var keyboardControlWorm = function (snake) {
        document.onkeydown = function (event) {
            event = event || window.event;
            switch (event.keyCode) {
                // left
                case 37:
                    if (snake.direction.x != 1 && snake.direction.y != 0) {
                        snake.direction.x = -1;
                        snake.direction.y = 0;
                    }
                    break;
                    // up
                case 38:
                    if (snake.direction.x != 0 && snake.direction.y != 1) {
                        snake.direction.x = 0;
                        snake.direction.y = -1;
                    }
                    break;
                    // right
                case 39:
                    if (snake.direction.x != -1 && snake.direction.y != 0) {
                        snake.direction.x = 1;
                        snake.direction.y = 0;
                    }
                    break;
                    // down
                case 40:
                    if (snake.direction.x != 0 && snake.direction.y != -1) {
                        snake.direction.x = 0;
                        snake.direction.y = 1;
                    }
                    break;
            }
        }
    }

    return {
        startGame: startGame,
    }
})();