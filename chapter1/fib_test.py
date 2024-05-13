from fib import *

expected = [
    (1,1),
    (3,2),
    (4,3),
    (5,5),
    (6,8),
    (10, 55),
    (50,12586269025),
]

def test_fib1()->None:
    for (n, r) in expected:
        if n <= 10:
            assert fib1(n) == r
