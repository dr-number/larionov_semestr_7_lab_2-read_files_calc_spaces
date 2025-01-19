## 2. Асинхронный подсчет пробелов
написать программу, которая асинхронно считывает все файлы типа txt из заданного каталога и считает в нем пробелы: 
a) считали файл полностью асинхронно и потом посчитали пробелы; 
б) считали файл построчно и для каждой строчки считаем пробелы. 
В этой задаче необходимо вывести время, затраченное на работу каждого из способов и количество пробелов в каждом файле. 

<figure>
   <p align="center">
      <img src="https://github.com/dr-number/larionov_semestr_7_lab_2-read_files_calc_spaces/blob/main/for_read_me/1.png">
      <p align="center">Чтение 3 txt файлов больших размеров по 3 раза</p>
   </p>
   <p align="center">
      <img src="https://github.com/dr-number/larionov_semestr_7_lab_2-read_files_calc_spaces/blob/main/for_read_me/3.png">
      <p align="center">Чтение 3 txt файлов меньшмх размеров по 3 раза</p>
   </p>
  <table>
	<thead>
		<tr>
			<td rowspan="2">№</td>
			<td rowspan="2">файл</td>
			<td rowspan="2">размер файла (байт)</td>
			<td rowspan="2">Количество пробелов</td>
			<td rowspan="2">№ попытки</td>
			<td colspan="2">Время исполнения метода</td>
		</tr>
		<tr> 
			<td>Cчитали файл полностью асинхронно и потом посчитали пробелы</td>
			<td>Cчитали файл построчно и для каждой строчки считаем пробелы</td>
		</tr>
        </thead>
<tbody>
		<tr>
			<td rowspan="3">1</td>
			<td rowspan="3">simulation_theory.txt</td>
			<td rowspan="3">12824</td>
			<td rowspan="3">882</td> 
			<td>1</td>
			<td>75,7022</td> 
			<td><b>1,6916</b></td>
		</tr>
		<tr>
			<td>2</td>
			<td>50,5527</td>
			<td><b>1,8484</b></td>
		</tr>
		<tr>
			<td>3</td>
			<td>8,2252</td>
			<td><b>6,2327</b></td>
		</tr>
		<tr>
			<td rowspan="3">2</td>
			<td rowspan="3">soviet_computers.txt</td>
			<td rowspan="3">14462</td>
			<td rowspan="3">1046</td>
			<td>1</td>
			<td>6,1167</td>
			<td><b>0,7181</b></td>
		</tr>
		<tr>
			<td>2</td>
			<td>6,9144</td>
			<td><b>0,6825</b></td>
		</tr>
		<tr>
			<td>3</td>
			<td><b>0,5335</b></td>
			<td>0,6945</td>
		</tr>
		<tr>
			<td rowspan="3">3</td>
			<td rowspan="3">space.txt</td>
			<td rowspan="3">6559</td>
			<td rowspan="3">450</td>
			<td>1</td>
			<td>4,8626</td>
			<td><b>0,5267</b></td>
		</tr>
		<tr>
			<td>2</td>
			<td>5,5041</td>
			<td><b>0,5062</b></td>
		</tr>
		<tr>
			<td>3</td>
			<td><b>0,5618</b></td>
			<td>0,7756</td>
		</tr>
		<tr>
			<td rowspan="3">4</td>
			<td rowspan="3">C#.txt</td>
			<td rowspan="3">1721</td>
			<td rowspan="3">135</td>
			<td>1</td>
			<td>7,7607</td>
			<td><b>3,1749</b></td>
		</tr>
		<tr>
			<td>2</td>
			<td>24,9742</td>
			<td><b>0,3944</b></td>
		</tr>
		<tr>
			<td>3</td>
			<td>1,6103</td>
			<td><b>1,4506</b></td>
		</tr>
		<tr>
			<td rowspan="3">5</td>
			<td rowspan="3">kotlin.txt</td>
			<td rowspan="3">1361</td>
			<td rowspan="3">96</td>
			<td>1</td>
			<td><b>0,3124</b></td>
			<td>0,3567</td>
		</tr>
		<tr>
			<td>2</td>
			<td><b>0,2843</b></td>
			<td>0,3535</td>
		</tr>
		<tr>
			<td>3</td>
			<td><b>0,3062</b></td>
			<td>0,3715</td>
		</tr>
		<tr>
			<td rowspan="3">6</td>
			<td rowspan="3">python.txt</td>
			<td rowspan="3">1772</td>
			<td rowspan="3">125</td>
			<td>1</td>
			<td><b>0,3019</b></td>
			<td>0,5347</td>
		</tr>
		<tr>
			<td>2</td>
			<td><b>0,2828</b></td>
			<td>0,6337</td>
		</tr>
		<tr>
			<td>3</td>
			<td><b>0,2597</b></td>
			<td>0,3651</td>
		</tr>
	</tbody>
</table>
</figure> 

На больших 3 файлах от 450 до 1046 байт включительно 9 проверок (3x3) показали что в 7 из 9 случаев метод "Cчитали файл построчно и для каждой строчки считаем пробелы" отрабатывает быстрее.
<br>
На меньших 3 файлах от 96 до 135 байт включительно 9 проверок (3x3) показали что в 6 из 9 случаев метод "Cчитали файл полностью асинхронно и потом посчитали пробелы" отрабатывает быстрее.
<br>
<br>
**Вывод: алгоритм "Cчитали файл построчно и для каждой строчки считаем пробелы" отрабатывает быстрее для больших файлов, алгоритм "Cчитали файл полностью асинхронно и потом посчитали пробелы" отрабатывает быстрее для меньших файлов**

<figure>
   <p align="center">
      <img src="https://github.com/dr-number/larionov_semestr_7_lab_2-read_files_calc_spaces/blob/main/for_read_me/2.png">
      <p align="center">Если txt файлы отсутствуют</p>
   </p>
</figure>
