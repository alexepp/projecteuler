def is_prime(n):
    i = 3
    if n % 2 == 0:
        return False
    while i*i < n:
        if n % i == 0:
            return False
        i += 2
    return True
            
def problem3(n):
    largest_factor = 0
    i = 3
    while i*i < n:
        if n % i == 0 and is_prime(i):
            largest_factor = i
        i += 2
    return largest_factor

if __name__ == '__main__':
    print(problem3(600851475143))
