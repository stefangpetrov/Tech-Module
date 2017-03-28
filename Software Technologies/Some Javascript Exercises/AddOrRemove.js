function AddOrRemove(arr) {

   let result = new Array();

   for(let i = 0; i < arr.length; i++){
       let tokens = arr[i].split(' ');
       let command = tokens[0];
       let number = Number(tokens[1]);

       switch (command) {
           case 'add':
               result.push(number);
               break;
           case 'remove':
               result.splice(number, 1);
               break;
       }
   }

    for(let num of result) {
        console.log(num);
    }
}

