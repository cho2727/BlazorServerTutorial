
export function callWithPrimitiveParameters(data1, data2, data3) {
    alert(`Receoved: data1 ${data1} data2 ${data2} data3 ${data3}`)
}

export function callWithObjectParameters(csharpObject) {
    alert(`Receoved : name:${csharpObject.name} age:${csharpObject.age} birthDate:${csharpObject.birthDate} `)
}

export function callWithReferenceParameter(csharpObjectReference) {
    alert(`Receoved : object not null ? - ${csharpObjectReference != null}`)
    // alert(`Receoved : name:${csharpObject.name} age:${csharpObject.age} birthDate:${csharpObject.birthDate} `)
}