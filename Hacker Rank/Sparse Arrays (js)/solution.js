"use strict";

const fs = require("fs");

process.stdin.resume();
process.stdin.setEncoding("utf-8");

let inputString = "";
let currentLine = 0;

process.stdin.on("data", (inputStdin) => {
  inputString += inputStdin;
});

process.on("SIGINT", (_) => {
  inputString = inputString
    .replace(/\s*$/, "")
    .split("\n")
    .map((str) => str.replace(/\s*$/, ""));

  main();
});

function readLine() {
  return inputString[currentLine++];
}

// Complete the matchingStrings function below.
function matchingStrings(strings, queries) {
  let result = [];

  for (let query of queries) {
    let resultCounter = 0;

    for (let str of strings) {
      resultCounter += query === str;
    }

    result.push(resultCounter);
  }

  return result;
}

function main() {
  const ws = fs.createWriteStream("TESTE");

  const stringsCount = parseInt(readLine(), 10);

  let strings = [];

  for (let i = 0; i < stringsCount; i++) {
    const stringsItem = readLine();
    strings.push(stringsItem);
  }

  const queriesCount = parseInt(readLine(), 10);

  let queries = [];

  for (let i = 0; i < queriesCount; i++) {
    const queriesItem = readLine();
    queries.push(queriesItem);
  }

  let res = matchingStrings(strings, queries);

  ws.write(res.join("\n") + "\n");

  ws.end();
}
