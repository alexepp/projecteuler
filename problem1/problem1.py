def problem1(n):
    return sum(i for i in range(n) if i%3==0 or i%5==0)
    
if __name__ == '__main__':
    print(problem1(1000))
