function createArray(){
    var array = new Array(20);
    for (var i = 0; i < array.length-1; i++){
            array[i] = i*5;
    }
    console.log(array.join(', '))
}
createArray()