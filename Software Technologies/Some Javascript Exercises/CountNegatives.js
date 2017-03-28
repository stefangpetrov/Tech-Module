function Negatives(arr) {
    let num1 = Number(arr[0]);
    let num2 = Number(arr[1]);
    let num3 = Number(arr[2]);

    negativescount = 0;

    if(num1 < 0)
        negativescount++;
    if(num2 < 0)
        negativescount++;
    if(num3 < 0)
        negativescount++;

    if(negativescount % 2 == 1)
        console.log('Negative');
    else
        console.log('Positive');
}