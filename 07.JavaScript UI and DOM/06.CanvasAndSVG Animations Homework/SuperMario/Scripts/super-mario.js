/// <reference path="_references.js" />

window.onload = function () {
    "use strict";


    var stage = new Kinetic.Stage({
        container: 'container',
        width: 1000,
        height: 600
    });

    var layer = new Kinetic.Layer();

    var imageObj = new Image();

    imageObj.onload = function () {
        var superMario = new Kinetic.Sprite({
            x: 450,
            y: 530,
            image: imageObj,
            animation: 'idle',
            animations: {
                idle: [
                  // x, y, width, height (2 frames)
                  370, 280, 20, 30,
                  90, 280, 25, 30
                ],
                moveLeft: [
                  // x, y, width, height (3 frames)
                  170, 240, 20, 30,
                130, 240, 25, 30,
                90, 240, 25, 30
                  
                ],
                moveRight: [
                  // x, y, width, height (3 frames)
                   210, 240, 25, 30,
                  250, 240, 25, 30,
                  290, 240, 25, 30
                ]
            },
            frameRate: 5,
            frameIndex: 0
        });

        // add the shape to the layer
        layer.add(superMario);

        // add the layer to the stage
        stage.add(layer);

        // start sprite animation
        superMario.start();

        var frameCount = 0;

        superMario.on('frameIndexChange', function (evt) {
            if (superMario.animation() === 'moveLeft' && ++frameCount > 3) { 
                superMario.animation('idle'); // restore original animation
                superMario.scaleX(1); // restore original animation
                frameCount = 0;
            }

            if(superMario.animation() === 'moveRight' && ++frameCount > 3) {
                superMario.animation('idle'); // restore original animation
            superMario.scaleX(1); // restore original animation
            frameCount = 0;
                }
        });

        function onKeyDown(evt) {
            switch (evt.keyCode) {
                case 37: // left arrow
                    superMario.attrs.animation = "moveLeft";
                    superMario.setX(superMario.attrs.x -= 5);
                    
                    break;
                case 39: // right arrow
                    superMario.attrs.animation = "moveRight";
                    superMario.setX(superMario.attrs.x += 5);
                   // superMario.scaleX(-1); // this scale reverses the mario
                    
                    break;
            }
        }

        window.addEventListener('keydown', onKeyDown);
    };

    imageObj.src = "../images/smb3_mario_sheet.png";

    var paper = new Raphael(0, 0, 1000, 600);

    paper.image("../images/super_mario_world_wallpaper-wide.jpg", 0, 0, 1000, 600);
}