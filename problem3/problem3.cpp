#include <iostream>

bool is_prime(long long n)
{
	unsigned int i = 3;
	if (n % 2 == 0)
		return false;
	while (i*i < n)
	{
		if (n % i == 0)
			return false;
		i += 2;
	}
	return true;
}

unsigned int problem3(long long n)
{
	unsigned int largest_factor = 0;
	long long i = 3;
	while (i*i < n)
	{
		if (n % i == 0 && is_prime(i))
			largest_factor = i;
		i += 2;
	}
	return largest_factor;
}

int main()
{
	std::cout << problem3(600851475143) << std::endl;
	return 0;
}