#include <iostream>
#include <vector>
#include <algorithm>
#include <ostream>
using namespace std;

//class MyLambda
//{
//public:
//	void operator()(int x)
//	{
//		cout << x << " ";
//	}
//};

struct Student
{
	string name;
	double mark;
	Student(string _name, double _mark) :name(_name), mark(_mark) {};
};

//int main()
//{
//	//vector<int> vect;
//	//for (int i = 0; i < 10; i++)
//	//{
//	//	vect.push_back(i);
//	//}
//
//	////for_each(vect.begin(), vect.end(), MyLambda());
//	//cout << endl;
//	//for_each(vect.begin(), vect.end(), [](int n) //вместо класса MyLambda лямбда выражение
//	//	{
//	//		cout << n << " ";
//	//	});
//	//cout << endl;
//	//int result = count_if(vect.begin(), vect.end(), [](int n) //лямбда выражение
//	//	{
//	//		return n % 2 == 0;
//	//	});
//	//cout << "result = " << result << endl;
//
//	//vector <double> destVect;
//	//transform(vect.begin(), vect.end(), back_inserter(destVect), [](int n)->double
//	//	{
//	//		if (n < 5)
//	//			return n + 1;
//	//		else if (n % 2 == 0)
//	//			return n / 2.0;
//	//		else
//	//			return n * n + 10.5;
//	//	});
//	//for_each(vect.begin(), vect.end(), [](int n)
//	//	{
//	//		cout << n << " ";
//	//	});
//
//	//cout << "\nEnter range:" << endl;
//	//int lowerBound, upperBound;
//	////cin >> lowerBound >> upperBound; //ввести нижнюю и верхнюю границу
//
//	//result = count_if(vect.begin(), vect.end(), [lowerBound, upperBound](int n)
//	//	{
//	//		return n >= lowerBound && n <= upperBound;
//	//	});
//
//	//cout << "result = " << result << endl;
//
//	//vector<int> test;
//	//int inIt = 100;
//	//generate_n(back_inserter(test), 10, [inIt]() mutable
//	//	{
//	//		return inIt++;
//	//	});
//	//copy(test.begin(), test.end(), ostream_iterator<int>(cout, " "));
//
//	vector<Student> student;
//	Student st1("Ivanov", 3.5);
//	Student st2("Petrov", 4.5);
//	Student st3("Sidorov", 5.5);
//	student.push_back(st1);
//	student.push_back(st2);
//	student.push_back(st3);
//
//	
//	//copy(student.begin(), student.end(), ostream_iterator<Student>(cout, " "));
//
//	auto ptr = max_element(student.begin(), student.end(), [](Student first, Student second)
//		{
//			return first.mark < second.mark;
//		}); 
//	cout << ptr->name;
//
//}