var player = "X";
var gameLoop = true;

var cell1 = document.getElementById('cell1');
var cell2 = document.getElementById('cell2');
var cell3 = document.getElementById('cell3');
var cell4 = document.getElementById('cell4');
var cell5 = document.getElementById('cell5');
var cell6 = document.getElementById('cell6');
var cell7 = document.getElementById('cell7');
var cell8 = document.getElementById('cell8');
var cell9 = document.getElementById('cell9');

function swapPlayer() {
    if (player == "X") {
        player = "O";
    }
    else {
        player = "X";
    }

    document.getElementById('player').innerHTML = player;
}


function checkRow() {
    if (cell1.innerHTML == cell2.innerHTML && cell2.innerHTML == cell3.innerHTML && cell3.innerHTML == player) {
        alert(player + " won");
        gameLoop = false;

        location.reload();
    }
    else if (cell4.innerHTML == cell5.innerHTML && cell5.innerHTML == cell6.innerHTML && cell6.innerHTML == player) {
        alert(player + " won");
        gameLoop = false;

        location.reload();
    }
    else if (cell7.innerHTML == cell8.innerHTML && cell8.innerHTML == cell9.innerHTML && cell9.innerHTML == player) {
        alert(player + " won");
        gameLoop = false;

        location.reload();
    }
} 


function checkColumn() {
    if (cell1.innerHTML == cell4.innerHTML && cell4.innerHTML == cell7.innerHTML && cell7.innerHTML == player) {
        alert(player + " won");
        gameLoop = false;

        location.reload();
    }
    else if (cell2.innerHTML == cell5.innerHTML && cell5.innerHTML == cell8.innerHTML && cell8.innerHTML == player) {
        alert(player + " won");
        gameLoop = false;

        location.reload();
    }
    else if (cell3.innerHTML == cell6.innerHTML && cell6.innerHTML == cell9.innerHTML && cell9.innerHTML == player) {
        alert(player + " won");
        gameLoop = false;

        location.reload();
    }
}


function checkDiagonal() {
    if (cell1.innerHTML == cell5.innerHTML && cell5.innerHTML == cell9.innerHTML && cell9.innerHTML == player) {
        alert(player + " won");
        gameLoop = false;

        location.reload();
    }
    else if (cell3.innerHTML == cell5.innerHTML && cell5.innerHTML == cell7.innerHTML && cell7.innerHTML == player) {
        alert(player + " won");
        gameLoop = false;

        location.reload();
    }
}


function checkDraw() {
    if (cell1.innerHTML != "" && cell2.innerHTML != "" && cell3.innerHTML != "" && cell4.innerHTML != "" && cell5.innerHTML != "" && cell6.innerHTML != "" && cell7.innerHTML != "" && cell8.innerHTML != "" && cell9.innerHTML != "" && gameLoop) {
        alert("Match Draw");

        location.reload();
    }
}


function gameResult() {
    checkRow();
    checkColumn();
    checkDiagonal();
    checkDraw();
}


function cellClicked(id) {
    if (document.getElementById(id).innerHTML != "X" && document.getElementById(id).innerHTML != "O") {
        document.getElementById(id).innerHTML = player;

        setTimeout(function () {

            gameResult();
            swapPlayer();

        }, 300);
    }
    else {
        alert("box already selected");
    }
}

