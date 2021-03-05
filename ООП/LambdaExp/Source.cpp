#include <iostream>
using namespace std;

void Factorial()
{
	int limit;
	cin >> limit;
	int factorial = 1;
	int i = 1;
	if (limit < 0)
	{
		factorial = 0;
		cout << "factorial = " << factorial << endl;
	}
	for (int i = 1; i < limit; i++)
	{
		factorial *= i + 1;
	}

	cout << "factorial = " << factorial << endl;
}

int main()
{
	Factorial();
}