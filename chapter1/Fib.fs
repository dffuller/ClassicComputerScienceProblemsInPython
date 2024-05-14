namespace chapter1

open System.Collections.Generic

#nowarn "40"

module fib =
    let rec fib2 (n: int) : int64 =
        match n with
        | 0
        | 1 -> int64 (n)
        | n -> fib2 (n - 1) + fib2 (n - 2)

    let memo = new Dictionary<int, int64>()
    memo.[0] <- int64 (0)
    memo.[1] <- int64 (1)


    let rec fib3 (n: int) : int64 =
        let exist, value = memo.TryGetValue n

        match exist with
        | true -> value
        | _ ->
            memo.Add(n, fib3 (n - 1) + fib3 (n - 2))
            memo.[n]

    let memo2 =
        Map[(0, 0L)
            (1, 1L)]

    let rec fibWithMap (n: int) : int64 =
        let opt = memo2.TryFind(n)

        match opt with
        | Some(value) -> value
        | None ->
            memo2.Add(n, fibWithMap (n - 1) + fibWithMap (n - 2)) |> ignore
            memo2.[n]

    let memoize f =
        let dict = Dictionary<_, _>()

        fun c ->
            let exist, value = dict.TryGetValue c

            match exist with
            | true -> value
            | _ ->
                let value = f c
                dict.Add(c, value)
                value


    let rec fib4: (int -> int64) =
        memoize (fun x -> if (x < 2) then x else fib4 (x - 1) + fib4 (x - 2))
