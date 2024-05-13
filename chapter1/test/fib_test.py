from fib import fib2, fib3, fib4

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


def test_fib2() -> None:
    for n, r in expected:
        if n <= 20:
            assert fib2(n) == r


def test_fib3() -> None:
    for n, r in expected:
        assert fib3(n) == r


def test_fib4() -> None:
    for n, r in expected:
        assert fib4(n) == r
