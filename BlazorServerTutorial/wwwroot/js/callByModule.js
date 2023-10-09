
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

export async function callProxyCSharpMethod(csharpObject) {
    alert(await csharpObject.invokeMethodAsync("ProxyMethod"));
}

export async function callReturnCSharpMethod(csharpObject) {
    alert(JSON.stringify(await csharpObject.invokeMethodAsync("ReturnCSharpObject")));
}

export function callPrimitiveParameterizedCSharpMethod(csharpObject) {
    csharpObject.invokeMethodAsync("MethodWithPrimitiveParameters", "Send Primitive Type", 100, new Date());
}

export function callReferenceParameterizedCSharpMethod(csharpObject) {
    let passingObject = {
        name: "Send Reference Type",
        age: 200,
        birthDate: new Date()
    };

    csharpObject.invokeMethodAsync("MethodWithReferenceParameters", passingObject);
}