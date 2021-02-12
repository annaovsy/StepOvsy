#include <iostream>
#include <vector>
#include <algorithm>
#include "STLlist.h"
using namespace std;

class Demo
{
	double d;
public:
	Demo(double _d) { d = _d; };
	void SetD(double _d)
	{
		d = _d;
	}
	double GetD()const { return d; }

	Demo& operator =(const Demo& temp)
	{
		this->d = temp.d;
		return *this;
	}
	bool operator<(const Demo& temp)
	{
		return d < temp.d;
	}
};

void ShowDemoVect(const vector<Demo>& vect)
{
	cout << "ShowDemoVect" << endl;
	vector<Demo>::const_iterator ptr = vect.begin();
	while (ptr != vect.end()) //end - итератор следующий за последним
	{
		cout << ptr->GetD() << " ";
		++ptr;
	}
	cout << endl;
}

void ShowVector(const vector<int>& vect) //вывод вектора поэлементно
{
	cout << "ShowVector" << endl;
	vector<int>::const_iterator ptrVect = vect.begin(); //возвращает итератор на первый элемент
				//если константный итератор не можем изменить значение
	while (ptrVect != vect.end()) //end - итератор следующий за последним
	{
		cout << *ptrVect << " ";
		++ptrVect;
	}
	cout << endl;
}

void Change(vector<int> &vect) //если передаем не по ссылке, то ничего не помен€етс€!!!
{
	cout << "Change" << endl;
	vect.resize(10);
	vector<int>::iterator ptrVect = vect.begin();
	for (int i = 0; i < vect.size(); i++)
		vect[i] = 555;
}

int main()
{
	////vector - массив
	//vector<int> vect;  //объ€вили вектор дл€ целых чисел
	//vector<double> dVect(5);  //вектор на 5 элементов
	//vector<char> cVect(5, 'x');

	//cout << "vect.size() = " << vect.size() << endl;
	//cout <<"dVect.size() = "<< dVect.size() << endl;
	//for (int i = 0; i < 10; i++)
	//{
	//	vect.push_back(i + 1);  //добавление элемента
	//}
	//cout << "vect.size() = " << vect.size() << endl;
	//for (int i = 0; i < vect.size(); i++)
	//	cout<< vect[i] << " "; //выводит все элементы
	//cout << endl;
	//vect.resize(100); //мен€ет размер вектора
	//cout << "resize vect.size() = " << vect.size() << endl;
	//for (int i = 0; i < vect.size(); i++)
	//	vect[i] = i + 1; //заполнение элементов
	//ShowVector(vect); //100 элементов
	//Change(vect);     //мен€ем размер на 10
	//ShowVector(vect); //10 элементов
	//vector<int>::iterator ptr = vect.begin();
	//ptr += 2;
	//vect.insert(ptr,10, 777); //вставл€ет 777 вместо 3го элемента 10 раз
	//ShowVector(vect);

	//vector<int>::iterator ptr2 = vect.begin();
	//ptr2 += 2;
	//vect.erase(ptr2+3, vect.end()); //удал€ет с 5 элемента до конца
	//reverse(vect.begin(), vect.end()); //переворачивает 

	//ShowVector(vect);
	//sort(vect.begin(), vect.end()); //сортирует от начала до конца, мен€ет элементы местами
	//ShowVector(vect);

	//vector <Demo> testV;
	//for (int i = 0; i < 10; i++)
	//{
	//	Demo temp(rand());
	//	testV.push_back(temp);
	//}
	//ShowDemoVect(testV);
	//sort(testV.begin(), testV.end());
	//ShowDemoVect(testV);
	 
	TestList();

}