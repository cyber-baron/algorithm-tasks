# Объединение Интервалов

[Задача с LeetCode](https://leetcode.com/problems/merge-intervals/)

## Описание задачи
Учитывая набор временных интервалов в любом порядке, объедините все перекрывающиеся интервалы в один и выведите результат, который должен иметь только взаимоисключающие интервалы. Пусть интервалы представляются в виде пар целых чисел для простоты.

## Обоснование решения
Изначально для работы с интервалами необходимо отсортировать исходный массив с промежутками. Сортировку будем делать по первому числу в интервале.
Берем начало предыдущего интервала, а окончание берем равное максимальному числу - окончание первого интервала или окончание второго и меняем последний записанный промежуток в Result. Для реализации объединения будем использовать LinkedList.