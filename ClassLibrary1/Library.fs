namespace ClassLibrary1

module Say =
    let hello name =
        printfn "Hello %s" name

module Person =
    type T = {First:string; Last:string}

        // Constructor
       let create first last =
        {First=first; Last=last}

        // standalone function
       let fullName {First=first; Last=last} =
        first + " " last