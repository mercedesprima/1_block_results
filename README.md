# 1_block_results
<b>Задача</b>

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

<i>Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

['1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []</i>

<b>Описание решения.</b>

1. Пользовательский ввод размера массива строк, а затем его элементов, из которых формируется первый массив. 

2. С использованием метода из элементов первого массива, имеющих длину не более 3-х символов, создается новый массив. 

3. Вывод на печать первоначального и нового массива при помощи универсального метода печати. 
