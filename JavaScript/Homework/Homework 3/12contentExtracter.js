function extractContent(input) {
    var pattern = /<[^>]*>/g;
    var result = '';
    result = input.replace(pattern, '');
    return result;
}
console.log(extractContent("<p>Hello</p><a href='http://w3c.org'>W3C</a>"));