function CreateNumber(numberArr) {
    if (numberArr.length != 10)
        return "Превышено кол-во цифр";
    for (var _i = 0, numberArr_1 = numberArr; _i < numberArr_1.length; _i++) {
        var number = numberArr_1[_i];
        if (number > 9 || number < 0) {
            return "Допустимы лишь цифры";
        }
    }
    return '(' + numberArr[0] + numberArr[1] + numberArr[2] + ') ' + numberArr[3] + numberArr[4] + numberArr[5] + '-'
        + numberArr[6] + numberArr[7] + numberArr[8] + numberArr[9];
}
var phone;
phone = CreateNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]);
console.log(phone);
// 2
var Challenge = /** @class */ (function () {
    function Challenge() {
    }
    Challenge.solution = function (number) {
        if (number < 0)
            return 0;
        else {
            var sum = 0;
            for (var i = 1; i < number; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    sum += i;
                }
            }
            return sum;
        }
    };
    return Challenge;
}());
console.log(Challenge.solution(10));
// 3
function swapArr(arr, k) {
    if (k == 0)
        return arr;
    if (arr.length == 0)
        return null;
    if (k > arr.length)
        k = k % arr.length;
    var newArr = [];
    for (var i = 0; i < k; i++)
        newArr[i] = arr[arr.length - (k - i)];
    for (var i = 0; i < arr.length - k; i++)
        newArr[k + i] = arr[i];
    return newArr;
}
var arr = [1, 2, 3, 4, 5, 6, 7];
console.log(arr);
console.log(swapArr(arr, 10));
// 4
function GetMedian(arrnum1, arrnum2) {
    if (arrnum1 == null && arrnum2 == null)
        return null;
    if (arrnum1 == null)
        arrnum1 = [];
    if (arrnum2 == null)
        arrnum2 = [];
    if (arrnum1.length == 0 && arrnum2.length == 0)
        return null;
    var arr = arrnum1.concat(arrnum2).sort(function (a, b) { return a - b; });
    if (arr.length % 2 == 0)
        return (arr[(arr.length / 2) - 1] + arr[arr.length / 2]) / 2;
    else
        return (arr[((arr.length - 1) / 2)]);
}
console.log(GetMedian([], []));
console.log(GetMedian([1, 20], [3, 4]));
