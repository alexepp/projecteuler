#include <iostream>

unsigned int problem2(unsigned int n)
{
	unsigned int sum = 0;
	unsigned int f1 = 1, f2 = 1, fn = 1;
	while (f2 < n)
	{
		if (fn % 2 == 0)
			sum += fn;
		fn = f1 + f2;
		f1 = f2;
		f2 = fn;
	}
	return sum;
}

int main()
{
	std::cout << problem2(4000000) << std::endl;
	return 0;
}