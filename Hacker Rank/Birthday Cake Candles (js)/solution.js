const candles = [3, 2, 1, 3];

function birthdayCakeCandles(candles) {
  const taller = Math.max(...candles);
  return candles.filter((x) => x === taller).length;
}

var result = birthdayCakeCandles(candles);

console.log(result)
