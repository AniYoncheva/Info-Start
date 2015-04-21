function replaceSpaces(input) {
    var length = input.length;
    var result = '';
    result = input.replace(/\s/g, '');
    return result;
}
console.log(replaceSpaces("But you were living in another world tryin' to get your message through"));