def problem2(n):
    sum = 0
    f1 = f2 = fn = 1
    while f2 < n:
        if fn % 2 == 0:
            sum += fn 
        fn = f1 + f2
        f1, f2 = f2, fn
    return sum

if __name__ == '__main__':
    print(problem2(4000000))
