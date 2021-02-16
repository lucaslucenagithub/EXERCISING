const arr = [1, 2, 3, 4, 5];

// Complete the miniMaxSum function below.
function miniMaxSum(arr) {
  var arrResult = [];

  for (let index = 0; index < arr.length; index++) {
    arrResult[index] = arr.reduce((acc, curr, i) => {
      return i !== index ? acc + curr : acc;
    }, 0);
  }

  console.log(Math.min(...arrResult), Math.max(...arrResult));
}

miniMaxSum(arr);
