////////////////////2/////////////////////
let myPromise = new Promise(function (resolve, reject)
{
    setTimeout(() => resolve(Math.random() * 100), 3000);
})

myPromise.then(result => {
    console.log("Задание 2:");
    console.log(result);
})

/////////////////////3/////////////////////////////

function genRanmNum(delay) {
    return new Promise((resolve, reject) => {
        setTimeout(() => resolve(Math.random() * 100), delay);
    })
}

const delays = [4000, 5000, 6000];
const promises = delays.map(delay => genRanmNum(delay));

Promise.all(promises)
    .then(numbers =>{
        console.log("Задание 3:");
    console.log("Generated numbers: ", numbers)
        })
    .catch(error => {
    console.log("Error: ", error);
})

///////////////////////4//////////////////////////
let pr = new Promise((res, rej) => {
    setTimeout(() => rej('ku'),7000);
})

pr
    .then(() => console.log(1))
    .catch(() => console.log(2))
    .catch(() => console.log(3))
    .then(() => console.log(4))
    .then(() => console.log(5))

/////////////////5////////////////////////

let promise5 = new Promise(function (resolve, reject) {
    setTimeout(() => resolve(21), 8000);
})

promise5.then(result => {
    console.log("Задание 5: ");
    console.log(result);
    return result * 2;
}).then(result => {
    console.log(result);
})

async function asyncPromise() {
    const promise = new Promise((resolve, reject) => {
        setTimeout(() => resolve(21), 9000);
    });
    const result1 = await promise;
    console.log("Задание 6:");
    console.log(result1);
    return result1;
}

asyncPromise().then(result => {
    result *= 2;
    console.log(result)
});