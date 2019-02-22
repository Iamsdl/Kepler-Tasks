var game = {

    options: {
        gameId: 0,//
        gameSpeed: 200,//
        foodColor: "green"
    },



    start: function () {
        if (!this.options.gameId) {
            this.options.gameId = setInterval(function () { game.snake.moveHead() }, this.options.gameSpeed);
        }
    },//
    stop: function () {
        clearInterval(this.options.gameId);
        this.options.gameId = 0;
    },//
    restart: function () {
        this.snake.removeTail();
        this.stop();
        this.food.remove();
        this.snake.head.css({
            top: 0,
            left: 0
        });
        this.snake.dir = 'R';
        this.snake.moving = 'R';
        this.snake.growTail();
        this.spawnFood();
    },//not that kind of restart
    keyPressed: function (event) {
        switch (event.which) {
            case 97:
                this.snake.dir = 'L';
                break;
            case 100:
                this.snake.dir = 'R';
                break;
            case 115:
                this.snake.dir = 'D';
                break;
            case 119:
                this.snake.dir = 'U';
                break;
            case 114:
                this.restart();
                break;
            case 32:
                if (game.options.gameId)
                    game.stop();
                else
                    game.start();
                break;
            case 111:
                options.dialog("open");
                break;

        }
    },//
    getRandomNumber: function (a, b) {
        return Math.floor(Math.random() * (b + 1 - a) + a);
    },//

    setContainerWidth: function (value) {
        this.container.css({
            width: value + "%",
            left: (100 - value) / 2 + "%",
            right: (100 - value) / 2 + "%"
        });
    },//
    setContainerHeight: function (value) {
        this.container.css({
            height: value + "%",
            top: (100 - value) / 2 + "%",
            bottom: (100 - value) / 2 + "%"
        });
    },//
    setContainerColor: function (color)
    {
        this.container.css("backgroundColor", color);
    },
    setGameSpeed: function (value) {
        this.options.gameSpeed = value;
    },//
    setSnakeSize: function (value) {
        this.snake.options.size = value;
        this.snake.tail.css({
            height: value + "%",
            width: value + "%"
        })

        this.food.remove();
        this.spawnFood();
    },//
    setTailColor: function (color) {
        this.snake.options.tailColor = color;
        this.snake.tail.css("backgroundColor", color);
        this.snake.head.css("backgroundColor", this.snake.options.headColor);
    },
    setHeadColor: function (color) {
        this.snake.options.headColor = color;
        this.snake.head.css("backgroundColor", color);
    },

    container: $("#container"),
    food: $("#food"),//
    snake: {
        options: {
            size: 5,//%
            tailColor: "black",//
            headColor: "red",
        },

        dir: 'R',//
        moving: 'R',//

        head: $("#div0"),//
        tail: $(".tail"), //

        getTail: function () {
            this.tail = $(".tail");
        },//
        removeTail: function () {
            this.tail.not("#div0").remove();
            this.getTail();
        },

        findFood: function () {
            return (parseInt(this.head.css("top")) == parseInt(game.food.css("top")) && (parseInt(this.head.css("left")) == (parseInt(game.food.css("left")))));
        },//
        eatFood: function () {
            game.food.remove();
            game.spawnFood();
        },//
        growTail: function () {
            var x = $("<div/>", {
                "class": "tail",
                id: "div" + this.tail.length
            });
            x.css({
                top: this.tail.last().css("top"),
                left: this.tail.last().css("left"),
                width: this.options.size + "%",
                height: this.options.size + "%",
                backgroundColor: this.options.tailColor
            })
            x.appendTo(game.container);

            this.getTail();
        },//

        outOfBounds: function (top, left) {
            return (top < 0) || (top > 100 - game.snake.options.size) || (left < 0) || (left > 100 - game.snake.options.size);
        },//
        ateTail: function (top, left) {
            for (var i = this.tail.length - 1; i > 0; i--) {
                if (top == parseInt(this.tail.get(i).style.top) && (left == parseInt(this.tail.get(i).style.left))) {
                    return 1;
                }
            }
            return 0;
        },//

        moveHead: function () {
            var top = this.head.get(0).style.top, left = this.head.get(0).style.left;


            if (top == "")
                top = 0;
            if (left == "")
                left = 0;

            top = parseInt(top);
            left = parseInt(left);

            var ftop = parseInt(game.food.css("top")), fleft = parseInt(game.food.css("left"));


            if (this.dir == 'U') {
                if (this.moving != 'D') {
                    top = top - this.options.size + "%";
                    this.moving = 'U';
                }
                else {
                    top = top + this.options.size + "%";
                }
                left = left + "%";
            }
            if (this.dir == 'D') {
                if (this.moving != 'U') {
                    top = top + this.options.size + "%";
                    this.moving = 'D';
                }
                else
                    top = top - this.options.size + "%";
                left = left + "%";
            }
            if (this.dir == 'L') {
                if (this.moving != 'R') {
                    left = left - this.options.size + "%";
                    this.moving = 'L';
                }
                else
                    left = left + this.options.size + "%";
                top = top + "%"
            }
            if (this.dir == 'R') {
                if (this.moving != 'L') {
                    left = left + this.options.size + "%";
                    this.moving = 'R';
                }
                else
                    left = left - this.options.size + "%";
                top = top + "%";
            }

            this.moveTail()

            this.head.css({
                top: top,
                left: left
            })

            if (this.outOfBounds(parseInt(top), parseInt(left))) {
                game.stop();
                alert("out of bounds");
                return;
            }

            if (this.ateTail(parseInt(top), parseInt(left))) {
                game.stop();
                alert("ate tail");
                return;
            }

            if (this.findFood()) {
                this.eatFood();
                this.growTail();
            }
        },//
        moveTail: function () {
            for (var i = this.tail.length - 1; i > 0; i--) {

                this.tail.eq(i).css({
                    top: this.tail.get(i - 1).style.top,
                    left: this.tail.get(i - 1).style.left
                })
            }
        },//
    },//

    spawnFood: function () {
        this.food = $("<div/>", {
            id: "food"
        })

        var ftop = this.getRandomNumber(0, 95 / this.snake.options.size) * this.snake.options.size;
        var fleft = this.getRandomNumber(0, 95 / this.snake.options.size) * this.snake.options.size;
        this.food.css({
            backgroundColor: game.options.foodColor,
            top: ftop + "%",
            left: fleft + "%",
            width: this.snake.options.size + "%",
            height: this.snake.options.size + "%",
        })

        this.food.appendTo(this.container);

        for (var i = this.snake.tail.length - 1; i > 0; i--) {
            if ((parseInt(this.snake.tail.get(i).style.top) == ftop) && (parseInt(this.snake.tail.get(i).style.left) == fleft)) {
                this.food.remove();
                this.spawnFood();
                console.log("asd");
            }
        }
    },//
    setFoodColor: function (color) {
        this.options.foodColor = color;
        this.food.css("backgroundColor", color);
    }
}
$("#containerWidth, #containerHeight, #snakeSize").slider({
    min: 1,
    max:100
});
$("#snakeSize").slider({
    min: 1,
    max:50
});
var options = $("#options").dialog({
    autoOpen: false,
    buttons: {
        "Apply": function () {
            game.setContainerColor($("#containerColor").val());
            game.setTailColor($("#tailColor").val());
            game.setHeadColor($("#headColor").val());
            game.setFoodColor($("#foodColor").val())
            game.setContainerHeight($("#containerHeight").slider("value"));
            game.setContainerWidth($("#containerWidth").slider("value"));
            game.setSnakeSize($("#snakeSize").slider("value"));

            options.dialog("close");
        },
        "Cancel": function () {
            options.dialog("close");
        }
    }
});

game.spawnFood();
game.snake.growTail();
game.setSnakeSize(game.snake.options.size);

