#include <iostream>

unsigned int problem1(unsigned int n)
{
	unsigned int sum = 0;
	for (int i = 0; i < n; i++)
	{
		if (i % 3 == 0 || i % 5 == 0)
		{
			sum += i;
		}
	}
	return sum;
}

int main() 
{
	std::cout << problem1(1000) << std::endl;
	return 0;
}