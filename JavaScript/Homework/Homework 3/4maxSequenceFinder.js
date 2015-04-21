function findMaxSequence(input){
    var length = input.length;
    var maxSizeSeq;
    var counter = 1;
    var result = [];
    maxSizeSeq = checkLongestStack(input);
    for (var i = 0; i < length - 1; i++) {
        if (input[i] < input[i + 1] && result.length < maxSizeSeq) {
            result.push(input[i + 1]);
            if (result.length == 1) {
                result.unshift(input[i]);
            }
        } else {
            if (result.length < maxSizeSeq) {
                result = [];
            }
        }
    }
    if (result.length == 0) {
        return 'no';
    } else {
        return result;
    }
}
function checkLongestStack(array) {
    var length = array.length;
    var sequence = 1;
    for (var i = 1; i < length; i++) {
        if (array[i] > array[i - 1]) {
            counter += 1;
            if (counter > sequence) {
                sequence = counter;
            }
        } else {
            counter = 1;
        }
    }
    return sequence;
}
console.log(findMaxSequence([3, 2, 3, 4, 2, 2, 4]));
console.log(findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
console.log(findMaxSequence([3, 2, 1]));