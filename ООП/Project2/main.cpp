#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

class compare
{
public:
	bool operator()(int x, int y)
	{
		return x > y;
	}
};

class Square
{
public:
	bool operator()(int x)
	{
		return x * x;
	}
};
class Cube
{
public:
	bool operator()(int x)
	{
		return x * x * x;
	}
};

template <class T>
class Example
{
	int x;
public:
	Example(int _x) :x{ _x } {}
	void Print()
	{
		cout << "val " << T() << endl;
	}

};

bool Condition(int x)
{
	return x < 100;
}

//int main()
//{
//	const int N = 10;
//	int mas[N] = { 111,233,134,244,6675,766,77,8888,99,100 };
//	//sort(mas, mas + N, compare());
//	sort(mas, mas + N); //сортирует по возрастанию
//	copy(mas, mas + N, ostream_iterator<int>(cout, " "));
//	cout << endl;
//	sort(mas, mas + N, greater<int>());//сортирует по убыванию
//	copy(mas, mas + N, ostream_iterator<int>(cout, " "));
//	cout << endl;
//
//	vector<int> vect;
//	vect.resize(N);
//	copy(mas, mas + N, vect.begin());
//	cout << "Vector : " << endl;
//	copy(vect.begin(), vect.end(), ostream_iterator<int>(cout, " "));
//
//	auto ptr = find_if(vect.begin(), vect.end(), Condition);
//	if (ptr != vect.end())
//	{
//		cout << "\nval = " << *ptr << endl;
//	}
//	Example<Square>ex(5);
//	ex.Print();
//	Example<Cube>ex2(3);
//	ex2.Print();
//
//}