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
	while (ptr != vect.end()) //end - �������� ��������� �� ���������
	{
		cout << ptr->GetD() << " ";
		++ptr;
	}
	cout << endl;
}

void ShowVector(const vector<int>& vect) //����� ������� �����������
{
	cout << "ShowVector" << endl;
	vector<int>::const_iterator ptrVect = vect.begin(); //���������� �������� �� ������ �������
				//���� ����������� �������� �� ����� �������� ��������
	while (ptrVect != vect.end()) //end - �������� ��������� �� ���������
	{
		cout << *ptrVect << " ";
		++ptrVect;
	}
	cout << endl;
}

void Change(vector<int> &vect) //���� �������� �� �� ������, �� ������ �� ����������!!!
{
	cout << "Change" << endl;
	vect.resize(10);
	vector<int>::iterator ptrVect = vect.begin();
	for (int i = 0; i < vect.size(); i++)
		vect[i] = 555;
}

int main()
{
	////vector - ������
	//vector<int> vect;  //�������� ������ ��� ����� �����
	//vector<double> dVect(5);  //������ �� 5 ���������
	//vector<char> cVect(5, 'x');

	//cout << "vect.size() = " << vect.size() << endl;
	//cout <<"dVect.size() = "<< dVect.size() << endl;
	//for (int i = 0; i < 10; i++)
	//{
	//	vect.push_back(i + 1);  //���������� ��������
	//}
	//cout << "vect.size() = " << vect.size() << endl;
	//for (int i = 0; i < vect.size(); i++)
	//	cout<< vect[i] << " "; //������� ��� ��������
	//cout << endl;
	//vect.resize(100); //������ ������ �������
	//cout << "resize vect.size() = " << vect.size() << endl;
	//for (int i = 0; i < vect.size(); i++)
	//	vect[i] = i + 1; //���������� ���������
	//ShowVector(vect); //100 ���������
	//Change(vect);     //������ ������ �� 10
	//ShowVector(vect); //10 ���������
	//vector<int>::iterator ptr = vect.begin();
	//ptr += 2;
	//vect.insert(ptr,10, 777); //��������� 777 ������ 3�� �������� 10 ���
	//ShowVector(vect);

	//vector<int>::iterator ptr2 = vect.begin();
	//ptr2 += 2;
	//vect.erase(ptr2+3, vect.end()); //������� � 5 �������� �� �����
	//reverse(vect.begin(), vect.end()); //�������������� 

	//ShowVector(vect);
	//sort(vect.begin(), vect.end()); //��������� �� ������ �� �����, ������ �������� �������
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