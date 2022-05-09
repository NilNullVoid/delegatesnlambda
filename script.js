let Welcome = hello => console.log(`Welcome friend ${hello}`);

let AddTwoNums = (n1, n2) => console.log(n1 + n2);

let AddArray = arrayToAdd => {
    let total = 0;
    for (let i = 0; i < arrayToAdd.length; i++) {
        total += arrayToAdd[i];
    }
    console.log(total);
}

let ComputePower = (b, e) => {
    let total = b;
    for (let i = 0; i < e - 1; i++) {
        total *= b;
    }
    console.log(total);
}

let fib = (n) => {
    let firstnumber = 0, secondnumber = 1, result = 0;
    if (n == 0) {
        Console.WriteLine(0);
        return;
    }

    if (n == 1) {
        Console.WriteLine(1);
        return;
    }

    for (let i = 2; i <= n; i++) {
        result = firstnumber + secondnumber;
        firstnumber = secondnumber;
        secondnumber = result;
    }

    console.log(result);
}

Welcome("John");
AddTwoNums(15, 16);
let test = [5, 7, 3, 2, 9];
AddArray(test);
ComputePower(3, 2);
fib(10);