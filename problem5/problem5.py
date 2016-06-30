def test(n):
	for i in range(2, 21):
		if n % i != 0:
			return False
	return True

def problem5():
    n = 1
    while not test(n):
        n += 1
    return n
    
if __name__ == '__main__':
    print(problem5())