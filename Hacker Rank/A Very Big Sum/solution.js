function aVeryBigSum(ar) {

    let result = [0];

    for (let index = 0; index < ar.length; index++) {
        result[0] += ar[index];        
    }

    return result;

}


var ar = [1000000001 , 1000000002, 1000000003, 1000000004, 1000000005];

const result = aVeryBigSum(ar);

console.log(result);