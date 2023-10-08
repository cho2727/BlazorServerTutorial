class CollocatedJs {
    CollocateFunction = function () {
        alert("CollocatedJs moudle loaded.")
    }
}

let instance = new CollocatedJs();

export function CollocatedJsInstance() {
    return instance;
}