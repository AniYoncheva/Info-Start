function findMaxSequence(input) {
    var length = input.length;
    var maxSizeSeq = 1;
    var counter = 1;
    var value = '';
    var result = [];
    if (length == 1) {
        result.push(input[0]);
    } else {
        for (var i = 1; i < length; i++) {
            if (input[i] === input[i - 1]) {
                counter += 1;
                if (counter >= maxSizeSeq) {
                    maxSizeSeq = counter;
                    value = input[i];
                }
            } else {
                counter = 1;
            }
        }
        for (var i = 0; i < maxSizeSeq; i++) {
            result[i] = value;
        }
    }
    return result;
}
console.log(findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(findMaxSequence(['happy']));
console.log(findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']));
