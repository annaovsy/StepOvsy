#include <iostream>
using std::string;
using std::cout;
using std::cin;
using std::endl;

class MyException
{

public:
	string message;
};

double del(double a, double b)
{
	try
	{
		if (b == 0)
			throw b;	 //генерация исключения
	}
	catch (double b)
	{
		cout << "EXCEPTION from del!" << b << endl;
	}

	return a / b;
}

void testException() throw(const char*)
{
	int* ptr = 0;
	int size;
	cout << "Put size" << endl;
	cin >> size;

	if (size < 1 || size>500)
	{
		MyException ex;
		ex.message = "Error set size\n";
		throw ex;
	}

	ptr = new int[size];

	if (!ptr)
		throw "\n\nErr memory\n\n";

	int a;
	cout << "Put a:" << endl;
	cin >> a;
	if (a == 0)
		throw a;
}

int main()
{
	try
	{
		/*double d = del(10, 0);
		cout << "d = " << d << endl;*/
		testException();
	}
	catch (int a)
	{
		cout << "Error int!" << a << endl;
	}
	catch (MyException ex)
	{
		cout << ex.message << endl;
	}
}