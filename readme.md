## 2. Асинхронный подсчет пробелов
написать программу, которая асинхронно считывает все файлы типа txt из заданного каталога и считает в нем пробелы: 
a) считали файл полностью асинхронно и потом посчитали пробелы; 
б) считали файл построчно и для каждой строчки считаем пробелы. 
В этой задаче необходимо вывести время, затраченное на работу каждого из способов и количество пробелов в каждом файле. 

<figure>
   <p align="center">
      <img src="https://github.com/dr-number/larionov_semestr_7_lab_2-read_files_calc_spaces/blob/main/for_read_me/1.png">
      <p align="center">Чтение 3 txt файлов по 3 раза</p>
   </p>
   <table>
  <thead>
    <tr>
      <th>Файл</th>
      <th>Размер (байт)</th>
      <th>Кол-во пробелов</th>
      <th>Метод</th>
      <th>Время (ms)</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td rowspan="3">soviet_computers.txt</td>
      <td rowspan="3">12824</td>
      <td rowspan="3">882</td>
      <td  rowspan="3">Считали файл полностью асинхронно и потом посчитали пробелы.</td>
      <td>6,7719</td>
    </tr>
    <tr>
      <td>6,7719</td>
    </tr>
    <tr>
      <td>6,7719</td>
    </tr>
    <tr>
      <td rowspan="3">soviet_computers.txt</td>
      <td rowspan="3">12824</td>
      <td rowspan="3">882</td>
      <td  rowspan="3">Считали файл полностью асинхронно и потом посчитали пробелы.</td>
      <td>6,7719</td>
    </tr>
    <tr>
      <td>6,7719</td>
    </tr>
    <tr>
      <td>6,7719</td>
    </tr>
    <tr>
      <td rowspan="3">soviet_computers.txt</td>
      <td rowspan="3">12824</td>
      <td rowspan="3">882</td>
      <td  rowspan="3">Считали файл полностью асинхронно и потом посчитали пробелы.</td>
      <td>6,7719</td>
    </tr>
    <tr>
      <td>6,7719</td>
    </tr>
    <tr>
      <td>6,7719</td>
    </tr>
  </tbody>
</table>
</figure>