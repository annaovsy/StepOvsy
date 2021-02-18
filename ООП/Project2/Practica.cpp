#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

class Increment
{
	int i;
public:
	Increment(int step) :i{ step } {}
	void operator()(int &x)
	{
		x += i;
	}
};
class Decrement
{
	int i;
public:
	Decrement(int step) :i{ step } {}
	void operator()(int& x)
	{
		x -= i;
	}
};

class Condition
{
public:
	bool operator()(int &x)
	{
		return x < 100;
	}
};


int main()
{
	vector<int>vect;
	for (int i = 0; i < 10; i++)
	{
		vect.push_back(rand());
	}
	sort(vect.begin(), vect.end());
	copy(vect.begin(), vect.end(), ostream_iterator<int>(cout, " "));
	cout << "Sort desc" << endl;

	sort(vect.begin(), vect.end(), greater<int>());
	copy(vect.begin(), vect.end(), ostream_iterator<int>(cout, " "));
	auto ptrMax = max_element(vect.begin(), vect.end());
	cout << "\nMax elem = " << *ptrMax << endl;
	auto ptrMin = min_element(vect.begin(), vect.end());
	cout << "Main elem = " << *ptrMin << endl;

	for_each(vect.begin(), vect.end(), Increment(10));
	copy(vect.begin(), vect.end(), ostream_iterator<int>(cout, " "));
	cout << endl;
	for_each(vect.begin(), vect.end(), Decrement(10));
	copy(vect.begin(), vect.end(), ostream_iterator<int>(cout, " "));
	vect.erase(remove_if(vect.begin(), vect.end(), Condition()));
	cout << "\nremove" << endl;
	copy(vect.begin(), vect.end(), ostream_iterator<int>(cout, " "));

}