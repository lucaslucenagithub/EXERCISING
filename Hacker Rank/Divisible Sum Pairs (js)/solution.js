'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

//IT WAS NECESSARY TO CHANGE 'end' to 'SIGINT' because ^D don't work for 'end' on windows, 
//but ^C works for 'SIGINT' 
process.on('SIGINT', _ => {
    inputString = inputString.replace(/\s*$/, '')
        .split('\n')
        .map(str => str.replace(/\s*$/, ''));

    main();
});

function readLine() {
    return inputString[currentLine++];
}

// Complete the divisibleSumPairs function below.
function divisibleSumPairs(n, k, ar) {
    let result = 0;
    for (let index = 0; index < ar.length; index++) {
        const element = ar[index];
        for (let index2 = index; index2 < ar.length; index2++) {
            const element2 = ar[index2+1];            
            result += (element + element2) % k == 0;
        }       
    }
    return result;
}

function main() {
    const ws = fs.createWriteStream("TESTE");

    const nk = readLine().split(' ');

    const n = parseInt(nk[0], 10);

    const k = parseInt(nk[1], 10);

    const ar = readLine().split(' ').map(arTemp => parseInt(arTemp, 10));

    let result = divisibleSumPairs(n, k, ar);

    ws.write(result + "\n");

    ws.end();
}
