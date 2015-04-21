function findNthDigit(arr) {
    var index = arr[0];
    var num = arr[1];
    num = num.toString();
    num = num.replace(/([,.])/g, "");
    var result = num[num.length - index];
    if (num.length < index) {
        return 'The number doesn’t have 6 digits';
    } else {
        return result;
    }
}
console.log(findNthDigit([1, 6]));
console.log(findNthDigit([2, -55]));
console.log(findNthDigit([6, 923456]));
console.log(findNthDigit([3, 1451.78]));
console.log(findNthDigit([6, 888.88]));