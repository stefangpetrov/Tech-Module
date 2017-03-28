function printLines(arr) {
    let lines = arr.map(String);

    for(let i = 0; i < lines.length - 1; i++)
    {
        if(lines[i] == "Stop")
            break;
        console.log(lines[i]);
    }
}