function createChessboard() {
    const chessboard = document.getElementById('chessboard');

    for (let row = 0; row < 8; row++) {
        for (let col = 0; col < 8; col++) {
            const square = document.createElement('div');
            square.classList.add('square', (row + col) % 2 === 0 ? 'white' : 'black');
            square.textContent = `${String.fromCharCode(65 + col)}${8 - row}`;
            chessboard.appendChild(square);
        }
    }
}

createChessboard();