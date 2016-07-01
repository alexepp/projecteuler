def is_palindrome(x):
	s = str(x)
	n = 1 if len(s) % 2 == 0 else 0
	if s[:int(len(s)/2)] == s[-1:int(len(s)/2)-n:-1]:
		return True
	else:
		return False
        
def problem4(n):
    return max(set([i*j for i in range(n) for j in range(n) if is_palindrome(i*j)]))
    
if __name__ == '__main__':
    print(problem4(999))