//a javascript module:
//export function exampleFunction() {
//    alert("Hello World")
//}

//A standard JavaScript:
function exampleFunction() {
    alert("example function from gloabal.js call")
}

function staticResult() {
    return "OK";
}

function dynamicTypeResult() {
    let randomNum = Math.random() * 10;

    if (randomNum < 3) {
        return "Hello world";
    }

    if (3 < randomNum && randomNum < 6) {
        return 10;
    }

    return 1;
}