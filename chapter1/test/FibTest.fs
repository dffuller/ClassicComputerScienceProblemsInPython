namespace chapter1

open NUnit.Framework
open fib

[<TestFixture>]
type TestClass() =

    [<Test>]
    member this.TestFib2_1() = Assert.AreEqual(fib2 (0), 0L) |> ignore

    [<Test>]
    member this.TestFib3_1() = Assert.AreEqual(fib3 (0), 0L) |> ignore

    [<Test>]
    member this.TestFib3_2() = Assert.AreEqual(fib3 (6), 8L) |> ignore

    [<Test>]
    member this.TestFib3_3() =
        Assert.AreEqual(fib3 (50), 12586269025L) |> ignore

    [<Test>]
    member this.TestFib4_1() = Assert.AreEqual(fib4 (0), 0L) |> ignore

    [<Test>]
    member this.TestFib4_2() = Assert.AreEqual(fib4 (6), 8L) |> ignore

    [<Test>]
    member this.TestFib4_3() =
        Assert.AreEqual(fib4 (20), 6765L) |> ignore

    [<Test>]
    member this.TestFib4_4() =
        Assert.AreEqual(fib4 (50), 12586269025L) |> ignore


(*
expected = [
    (1, 1),
    (3, 2),
    (4, 3),
    (5, 5),
    (6, 8),
    (10, 55),
    (20, 6765),
    (50, 12586269025),
]
*)
