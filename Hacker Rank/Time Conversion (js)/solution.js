const s = "01:40:03PM";

function timeConversion(s) {
  let [hours, minutes, seconds] = s.replace(/[A-Z]/gi, "").split(":");
  let turn = /[A-Z]/gi.exec(s);
  return `${
    turn[0] === "A" && hours === "12"
      ? "00"
      : turn[0] === "A"
      ? hours
      : turn[0] === "P" && hours === "12"
      ? hours
      : parseInt(hours) + 12
  }:${minutes}:${seconds}`;
}

const result = timeConversion(s);

console.log(result);
