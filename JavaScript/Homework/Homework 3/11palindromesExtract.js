function findPalindromes(input) {
    var text = input.toLowerCase().split(/[\W+]/);
    var palindromes = false;
    var result = [];
    var length;
    text = text.filter(Boolean); //Remove empty element from array
    length = text.length;
    for (var i = 0; i < length; i++) {
        if (text[i].length == 1) {
            result.push(text[i]);
        } else {
            for (var j = 0; j < Math.floor(text[i].length / 2); j++) {
                if (text[i][j] == text[i][text[i].length - 1 - j]) {
                    palindromes = true;
                } else {
                    palindromes = false;
                    break;
                }
            }
            if (palindromes) {
                result.push(text[i]);
            }
        }
    }
    return result.join(', ');
}
console.log(findPalindromes('There is a man, his name was Bob.'));