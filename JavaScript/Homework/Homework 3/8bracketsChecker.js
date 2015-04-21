function checkBrackets(value) {
    var countOfBrackets = 0;
    var correct = true;

    for(var i = 0; i < value.length; i+=1) {
        if (value[i] === '(') {
            countOfBrackets += 1;
        }
        else if (value[i] ===  ')') {
            if(countOfBrackets === 0) {
                correct = false;
                break;
            }

            else {
                countOfBrackets -= 1;
            }
        }
    }
    return (correct && countOfBrackets === 0) ? 'correct' : 'incorrect';
}
console.log(checkBrackets('( ( a + b ) / 5 – d )'));
console.log(checkBrackets(') ( a + b ) )'));
console.log(checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));