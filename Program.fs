// For more information see https://aka.ms/fsharp-console-apps

(*
    Globalmente sto programma restituisce la lista passata in argomento
    con gli elementi che restituiscono uno true dopo la chiamata di p su essi

    asserzioni non banali:
    nb: ho aggiunto una mia funzione p che restituisce true se l'elemento hd>0 altrimenti false

    assert(myFun p (1::2::3::4::[])=[1;2;3;4])
    assert(myFun p [1;2;-3;-4;5;6]=[1;2;5;6])

*)

let myFun p =
    let rec aux =
        function
        | [] -> []
        | hd :: tl ->
            let res = aux tl
            if p hd then hd :: res else res

    aux 

    
let p x = if x > 0 then true else false

assert(myFun p (1::2::3::4::[])=[1;2;3;4])
assert(myFun p [1;2;-3;-4;5;6]=[1;2;5;6])
