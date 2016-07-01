def problem9(n):
    for a in range(1, n):
        for b in range(a, n):
            for c in range(b, n):
                if a**2 + b**2 == c**2 and a+b+c == n:
                    return (a, b, c)
                    
if __name__ == '__main__':
    print(problem9(1000))