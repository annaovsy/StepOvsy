#include <iostream>
#include <string>
#include <map>
using namespace std;

class Word
{
	string str;
public:
	Word(string s) { str = s; }
	string getWord() { return str; }
	bool operator<(const Word& ob) const
	{
		return str < ob.str;
	}
};

class Opposite
{
	string str;
public:
	Opposite(string s) { str = s; }
	string getWord() { return str; }
	bool operator<(const Opposite& ob)
	{
		return str < ob.str;
	}
};
//
//int main()
//{
//	setlocale(LC_ALL, "rus");
//
//	map<char, int>dictionary;
//	for (int i = 0; i < 10; i++)
//	{
//		//dictionary.insert(pair<char, int>('A' + i, i));
//		dictionary.insert(make_pair('A' + i, i));
//	}
//	char ch;
//	cout << "Enter key = ";
//	cin >> ch;
//	map<char, int>::iterator ptr;
//	ptr = dictionary.find(ch);
//	if (ptr != dictionary.end())
//	{
//		cout << "Value = " << ptr->second << endl;
//	}
//	else
//	{
//		cout << "Not found" << endl;
//	}
//
//	map<Word, Opposite> dict;
//	dict.insert(make_pair(Word("Yes"), Opposite("No")));
//	dict.insert(make_pair(Word("Right"), Opposite("Left")));
//	dict.insert(make_pair(Word("Upp"), Opposite("Down")));
//
//	cout << "Введите слово" << endl;
//	string str;
//	cin >> str;
//	auto ptrClass = dict.find(Word(str));
//	if (ptrClass == dict.end())
//	{
//		cout << "Нет такого элемента" << endl;
//	}
//	else
//	{
//		cout << "Антоним : " << ptrClass->second.getWord() << endl;
//	}
//}
