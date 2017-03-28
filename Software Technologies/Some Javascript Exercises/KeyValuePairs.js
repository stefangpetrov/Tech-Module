function AddOrRemove(arr) {

    let result = {};

    for(let i = 0; i < arr.length; i++){
        let tokens = arr[i].split(' ');
        let key = tokens[0];
        let value = tokens[1];
        if(value != undefined)
            result[key] = value;

        else {
            if (result[key] == undefined) {
                console.log("None");
            }
            else
                console.log(result[key]);
        }
    }



}
