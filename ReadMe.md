1. Изначально создан пользовательский ввод строчного типа. 
2. слудующим этапом было создание массива из часто встречающихся разделителей, по типу "." "," " " " \t".
3. Далее произвел, собственно, само разделение, изначального строчного элемента, с записью в массив(mainmass).
4. Создал конечный массив в котором будет храниться ответ нашего задания.
5. переменная temp необходима для того, что бы программа записывала в наш массив ответы по порядку.
6. Сам алгоритм - пробегаемся по нашему главному массиву, при помощи цика for. У каждого элемента проверяем условие, если длина элемета с i-тым индексом, меньше или равна 3, то
записываем его в наш массив с ответами. Добавляем к переменной temp +1, что бы следующий ответ записался в массив на следующее место. 
7. При помощи цикла foreach проходим по массиву с ответами и выводим в консоль.
конец.