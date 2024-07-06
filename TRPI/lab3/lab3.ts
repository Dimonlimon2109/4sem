function CreateNumber(numberArr:number[]):string
{
    if(numberArr.length != 10)
        return "Превышено кол-во цифр";
    for (const number of numberArr) {
        if (number > 9 || number < 0) {
            return "Допустимы лишь цифры";
        }
    }
    return '(' + numberArr[0] + numberArr[1] + numberArr[2] + ') ' + numberArr[3] + numberArr[4] + numberArr[5] + '-'
        + numberArr[6] + numberArr[7] + numberArr[8] + numberArr[9];
}

let phone : string;
phone = CreateNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]);
console.log(phone);

// 2
class Challenge {
    static solution(number: number):number {
        if(number < 0)
            return 0;
        else
        {
            let sum:number = 0;

            for(let i = 1; i < number; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
console.log(Challenge.solution(10));

// 3
function swapArr(arr:number[], k:number) :number[] | null
{
    if(k == 0)
        return arr;
    if(arr.length == 0)
        return null;
    if(k > arr.length)
        k = k % arr.length;
    let newArr:number[] = [];
    for(let i = 0; i < k; i++)
        newArr[i] = arr[arr.length - (k - i)];

    for(let i = 0; i < arr.length - k; i++)
        newArr[k + i] = arr[i];

    return newArr;
}

let arr : number[] = [1, 2, 3, 4, 5, 6, 7];
console.log(arr);
console.log(swapArr(arr, 10));

// 4
function GetMedian(arrnum1:number[], arrnum2:number[]) : number | null
{
    if(arrnum1 == null && arrnum2 == null)
        return null;
    if(arrnum1 == null)
        arrnum1 = [];
    if(arrnum2 == null)
        arrnum2 = [];
    if(arrnum1.length == 0 && arrnum2.length == 0)
        return null;

    let arr = arrnum1.concat(arrnum2).sort((a,b) => a - b);
    if(arr.length % 2 == 0)
        return (arr[(arr.length / 2)-1] + arr[arr.length / 2]) / 2;
    else


        return (arr[((arr.length -1) / 2)]);
}
console.log(GetMedian([],[]));
console.log(GetMedian([1, 20], [3, 4]));