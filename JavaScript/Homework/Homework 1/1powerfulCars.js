function convertKWtoHP(kw) {
    var hp = kw/ 0.745699872;
    return hp.toFixed(2);
}
console.log("HP = " + convertKWtoHP(75))
console.log("HP = " + convertKWtoHP(150))
console.log("HP = " + convertKWtoHP(1000))