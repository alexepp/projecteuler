def problem6(n):
	s1 = sum(i for i in range(n+1))**2
	s2 = sum(i**2 for i in range(n+1))
	return s1 - s2
    
if __name__ == '__main__':
    print(problem6(100))