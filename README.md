# Задача:
**Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.**
**Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.**
**При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами**

*Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]*

*[“1234”, “1567”, “-2”, “computer science”] → [“-2”]*

*[“Russia”, “Denmark”, “Kazan”] → []*

### Текстовое описание решения задачи: ###
1. Задаем 2 массива. Первый массив задан на старте, второй массив задан пустой, но размерностью как у первого.
2. Создаем метод, в котором проверяется длина строк первого массива по условию задачи 
3. Если длина строки arr[i] меньше или равна 3, то в arr2[count] записывается это значение.
5. После этого значение count увеличивается на 1, и возвращается в цикл for, где снова выполняется этот цикл, пока не выполнится условие.
4. Полученные данные записываются во второй массив.
3. Выводим второй массив на экран.

![Блок-схема задачи][id]

[id]: https://i.ibb.co/PNRybYr/image.jpg
