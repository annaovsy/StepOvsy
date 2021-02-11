#include "FinancialManagementSystem.h"
#include <iostream>
#include <fstream>
using namespace std;

DebitCard::DebitCard(int _sumTotal):
	sumTotal(_sumTotal),
	productCategory(0),
	entertainmentCategory(0),
	travelCategory(0)
{}

void DebitCard::SetRefill()
{
	int refill;
	cout << "Введите сумму: " << endl;
	cin >> refill;
	sumTotal += refill;
	cout << "Операция выполнена успешно!" << endl;
	cout << "Общая сумма на карте : " << sumTotal << endl;
}

void DebitCard::SetExpenses()
{
	int expenses, category;	
	cout << "Введите сумму: " << endl;
	cin >> expenses;
	if (expenses >= sumTotal)
	{
		cout << "\tОперация не может быть выполнена!!!\n\tСумма снятия превышает остаток на карте!\n";
	}
	else
	{
		int min = 1000;
		int max = 0;
		cout << "Введите категорию: 1 - Продукты | 2 - Развлечения | 3 - Путешествия" << endl;
		cin >> category;
		switch (category)
		{
		case 1:
			productCategory += expenses;
			break;
		case 2:
			entertainmentCategory += expenses;
			break;
		case 3:
			travelCategory += expenses;
			break;
		default:
			break;
		}
		
		sumTotal -= expenses;
		cout << "Операция выполнена успешно!" << endl;
		cout << "Общая сумма на карте : " << sumTotal << endl;
	}	
}

bool DebitCard::ExpenseReportFile(const char* filename)
{
	string first, second, third;
	//int first, second, third;
	if (productCategory > entertainmentCategory && productCategory > travelCategory)
	{
		first = "Продукты";
		if (entertainmentCategory > travelCategory)
		{
			second = "Развлечения";
			third = "Путешествия";
		}
		else
		{
			second = "Путешествия";
			third = "Развлечения";
		}			
	}
	else if (entertainmentCategory > productCategory && entertainmentCategory > travelCategory)
	{
		first = "Развлечения";
		if (productCategory > travelCategory)
		{
			second = "Продукты";
			third = "Путешествия";
		}
		else
		{
			second = "Путешествия";
			third = "Продукты";
		}
	}
	else if (travelCategory > productCategory && travelCategory > entertainmentCategory)
	{
		first = "Путешествия";
		if (productCategory > entertainmentCategory)
		{
			second = "Продукты";
			third = "Развлечения";
		}
		else
		{
			second = "Развлечения";
			third = "Продукты";
		}
	}

	ofstream fileOut(filename, ios::out); //вывод в файл
	if (!fileOut.is_open())
		return false;
	fileOut << "Топ 3 затрат по категорям:" << endl;
	fileOut << "1. " << first<< endl;
	fileOut << "2. " << second << endl;
	fileOut << "3. " << third << endl;
	fileOut.close();
	return true;
}

void DebitCard::Show()
{
	cout << "Общая сумма на карте : " << sumTotal << endl;
	cout << "Продукты : " << productCategory << endl;
	cout << "Развлечения : " << entertainmentCategory << endl;
	cout << "Путешествия : " << travelCategory << endl;
}
