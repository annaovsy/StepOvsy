#include "FinancialManagementSystem.h"
#include <iostream>
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
	int first, second, third;
	if (productCategory > entertainmentCategory && productCategory > travelCategory)
	{
		first = productCategory;
		if (entertainmentCategory > travelCategory)
		{
			second = entertainmentCategory;
			third = travelCategory;
		}
		else
		{
			second = travelCategory;
			third = entertainmentCategory;
		}			
	}
	else if(productCategory > entertainmentCategory && productCategory > travelCategory  )

	if (productCategory > entertainmentCategory)
		productCategory = first;
	FILE* file = fopen(filename, "w"); //открываем файл
	if (!file)
		return false;
	fprintf(file, "Отчет затрат по категориям:"); 
	fprintf(file, "%s\t%d\t%.2lf\n", name.c_str(), age, averMark);

	fclose(file); //закрываем файл

	return true;
}

void DebitCard::Show()
{
	cout << "Общая сумма на карте : " << sumTotal << endl;
	cout << "Продукты : " << productCategory << endl;
	cout << "Развлечения : " << entertainmentCategory << endl;
	cout << "Путешествия : " << travelCategory << endl;
}
