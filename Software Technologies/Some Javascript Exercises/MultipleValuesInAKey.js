function AddOrRemove(arr) {

    let result = {};

    for(let i = 0; i < arr.length - 1; i++){
        let tokens = arr[i].split(' ');
        let key = tokens[0];
        let value = tokens[1];
        if(result[key]) {
            result[key].push(value);
        } else {
            result[key] = [value];
        }

    }

    let key = arr[arr.length - 1];

    console.log(result[key] ? result[key].join('\n') : "None");

}
