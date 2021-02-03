//#include <iostream>    // управление стрелочками на клавиатурe:
//#include "windows.h"   // вверх, вниз, вправо, влево
//#include "conio.h"
//#include "ctime"
//
//using namespace std;
//
//void gotoxy(int xpos, int ypos) // переход курсора в точку с координатами xpos, ypos
//{
//    COORD scrn;
//    HANDLE hOuput = GetStdHandle(STD_OUTPUT_HANDLE);
//    scrn.X = xpos; scrn.Y = ypos;
//    SetConsoleCursorPosition(hOuput, scrn);
//}
//
//class Snake
//{
//public:
//    Snake()
//    {
//        hedge = 178; calculation = line = post = 0;
//        apple = 4; point = 0; length = 3;
//        for (int& c : snake) { c = 0; }
//        for (int i = 0, e = 128; !(i == 4); i++, e++) { snake[i] = e; }
//        head = 2; tail = '*'; copyClick = 77;
//        oldClick = 75; click = 77;; position = 0;
//
//    }
//    int game()
//    {
//        poleConstruct(pole);
//        constructSnake();
//        randApple(pole);
//        while (1)
//        {
//            if (point == 50) // проверка на победу
//            {
//                praise();
//                return 0;
//            }
//            conclusionPole();
//            copyClick1 = click;
//            switch (click)
//            {
//            case 72:
//                oldClick = 80; break;
//            case 80:
//                oldClick = 72; break;
//            case 75:
//                oldClick = 77; break;
//            case 77:
//                oldClick = 75; break;
//            default:
//                break;
//            }
//            while (_kbhit()) { _getch(); } // считывание всех нажатий(для предотвращения задержки)
//            Sleep(100); // скорость змеи
//            if (_kbhit()) { _getch(); } // считывание 224 перед направлением
//            if (_kbhit()) // считывание направления
//            {
//                click = _getch();
//                if (!((click == 72) || (click == 80) || (click == 77) || (click == 75)))
//                {
//                    click = copyClick;
//                }
//                else
//                {
//                    copyClick = click;
//                }
//            }
//            if (click == oldClick) // недопустимость заднего хода
//            {
//                click = copyClick1;
//            }
//            position = snake[length]; // запись первой позиции змейки
//            switch (click) // ход
//            {
//            case 72:
//                position -= 58;
//                if (sMove(position)) { continue; }
//                break;
//            case 80:
//                position += 58;
//                if (sMove(position)) { continue; }
//                break;
//            case 75:
//                position -= 1;
//                if (sMove(position)) { continue; }
//                break;
//            case 77:
//                position += 1;
//                if (sMove(position)) { continue; }
//                break;
//            default:
//                continue;
//            }
//            if (action()) { restartGame(); continue; }
//            clearConsole();
//            return 0;
//        }
//    }
//protected:
//    Snake(const Snake&);
//    Snake& operator =(const Snake&);
//    void constructSnake() // построение змейки
//    {
//        for (int i = 0; i < length; i++)
//        {
//            pole[snake[i]] = tail;
//        }
//        pole[snake[length]] = head;
//    }
//    bool sMove(int firstPosition) // ход змеи
//    {
//        if ((pole[firstPosition] == hedge) || (pole[firstPosition] == tail)) { return 0; } // проверка на верность хода.
//        for (int i = 0; i <= length; i++) { pole[snake[i]] = ' '; } // очистка прошлой позиции в поле.
//        if (pole[firstPosition] == apple)                       // действие при находке яблока:
//        {                                                      //  прибавляется длинна,
//            length++; point++;                                      //  и в соответсвующую длинне ячейку
//            snake[length] = firstPosition;                         //  массива вставляется успешный ход.
//            constructSnake();
//            randApple(pole);
//            return 1;
//        }
//        for (int i = 0, n = 1; n <= length; i++, n++) { snake[i] = snake[n]; } // действия при простом ходе:
//        snake[length] = firstPosition;                                      //  цикл смещает змейку назад
//        constructSnake();                                                   //  на одну позицию, после цикла.
//        return 1;
//    }
//    void restartGame() // перезагрузка игры после пройгрыша(обновление на начало всех действующих переменных)
//    {
//        poleConstruct(pole);
//        for (int& c : snake) { c = '\0'; }
//        length = 3;
//        for (int i = 128, e = 0; !(i == 132); i++, e++) { snake[e] = i; }
//        oldClick = 77; copyClick = 77; click = 77; point = 0;
//        constructSnake();
//        randApple(pole);
//        gotoxy(58, 2);
//        cout << "Score =    ";
//    }
//    bool action() // дальнейшее действие при пройгрыше
//    {
//        gotoxy(10, 10);
//        cout << "game over\n";
//        gotoxy(10, 11);
//        cout << "1 To play again\n";
//        gotoxy(10, 12);
//        cout << "2 exit\n";
//        gotoxy(10, 11);
//        for (int i = 1;;)
//        {
//            if (_kbhit())
//            {
//                switch (_getch())
//                {
//                case 13:
//                    return i;
//                case 72:
//                    gotoxy(10, 11);
//                    i = 1;
//                    continue;
//                case 80:
//                    gotoxy(10, 12);
//                    i = 0;
//                    continue;
//                default:
//                    continue;
//                }
//            }
//        }
//    }
//    void conclusionPole() // вывод поля со счётом
//    {
//        gotoxy(0, 0);
//        cout << endl << pole;
//        gotoxy(58, 2);
//        cout << "Score = " << point;
//    }
//    void clearConsole() // очистка консоли
//    {
//        for (char& c : pole) { c = ' '; }
//        gotoxy(0, 0); cout << pole; gotoxy(0, 15);
//        cout << pole; gotoxy(0, 0);
//    }
//    void praise() // Победа!
//    {
//        clearConsole();
//        cout << "  _/    _/     _/_/      _/_/       _/            _/ _/_/_/  _/     _/  _/\n"
//            << "  _/  _/    _/    _/  _/    _/     _/          _ /   _/    _/_/    _/  _/\n"
//            << "   _/      _/    _/  _/    _/      _/   _/   _/     _/    _/  _/  _/  _/ \n"
//            << "  _/      _/    _/  _/    _/       _/  _/  _/      _/    _/    _/_/ \n"
//            << " _/        _/_/      _/_/           _/  _/      _/_/_/  _/      _/  _/ " << endl;
//    }
//    void poleConstruct(char target[]) // конструирует поле
//    {
//        for (char& c : pole) { c = '\0'; }
//        for (int i = 0, eb = 0, id = 0; i < 1275; i++, eb++)
//        {
//            if ((eb == 57) && (id == 0))
//            {
//                target[i] = '\n';
//                eb = 0;
//                id++;
//                continue;
//            }
//            else
//            {
//                if (eb == 58)
//                {
//                    target[i] = '\n';
//                    eb = 0;
//                    continue;
//                }
//                if ((id < 2) && ((i > 3) && (i < 57)))
//                {
//                    target[i] = hedge;
//                    continue;
//                }
//                if ((i > 4) && (i < 56))
//                {
//                    target[i] = hedge;
//                    continue;
//                }
//                if (i > 1221)
//                {
//                    target[i] = hedge;
//                    continue;
//                }
//                if ((eb == 5) || (eb == 57))
//                {
//                    target[i] = hedge;
//                    continue;
//                }
//                target[i] = ' ';
//            }
//        }
//    }
//    void randApple(char sPole[]) // рандомное появление яблока
//    {
//        while (1)
//        {
//            line = 2 + rand() % 20;
//            calculation = line * 58 - 1;
//            post = 1 + rand() % 52;
//            calculation += 5 + post;
//            if (sPole[calculation] == 32)
//            {
//                sPole[calculation] = apple;
//                break;
//            }
//        }
//    }
//    char pole[1276]; // поле
//    char hedge; // граница поля
//    char apple; // яблоко
//    int point; // очки
//    int length; // длина змеи
//    int snake[100]; // змея
//    int calculation, line, post; // вычислительные элементы randApple
//    char head; // голова
//    char tail; // хвост
//    int click; // клик
//    int copyClick, copyClick1; // копии клика(для его регуляции)
//    int oldClick; // предыду́щий клик(нужен чтобы змейка не могла ходить назад)
//    int position; // первая позиция змейки
//
//
//};
//
//int main()
//{
//    Snake s;
//    s.game();
//    cout << "Press Enter to continue..." << endl;
//    cin.ignore(10, '\n');
//    cin.get();
//    return 0;
//}
