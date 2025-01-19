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
			<td>1,6916</td>
		</tr>
		<tr>
			<td>2</td>
			<td>50,5527</td>
			<td>1,8484</td>
		</tr>
		<tr>
			<td>3</td>
			<td>8,2252</td>
			<td>6,2327</td>
		</tr>
		<tr>
			<td rowspan="3">4</td>
			<td rowspan="3">soviet_computers.txt</td>
			<td rowspan="3">14462</td>
			<td rowspan="3">1046</td>
			<td>4</td>
			<td></td>
			<td></td>
		</tr>
		<tr>
			<td>5</td>
			<td></td>
			<td></td>
		</tr>
		<tr>
			<td>6</td>
			<td></td>
			<td></td>
		</tr>
		<tr>
			<td rowspan="3">3</td>
			<td rowspan="3">space.txt</td>
			<td rowspan="3">6559</td>
			<td rowspan="3">450</td>
			<td>1</td>
			<td>4,8626</td>
			<td>0,5267</td>
		</tr>
		<tr>
			<td>2</td>
			<td>5,5041</td>
			<td>0,5062</td>
		</tr>
		<tr>
			<td>3</td>
			<td>0,5618</td>
			<td>0,7756</td>
		</tr>
		<tr>
			<td rowspan="3">1</td>
			<td rowspan="3">simulation_theory.txt</td>
			<td rowspan="3">12824</td>
			<td rowspan="3">882</td>
			<td>1</td>
			<td>75,7022</td>
			<td>1,6916</td>
		</tr>
		<tr>
			<td>2</td>
			<td>50,5527</td>
			<td>1,8484</td>
		</tr>
		<tr>
			<td>3</td>
			<td>8,2252</td>
			<td>6,2327</td>
		</tr>
		<tr>
			<td rowspan="3">2</td>
			<td rowspan="3">soviet_computers.txt</td>
			<td rowspan="3">14462</td>
			<td rowspan="3">1046</td>
			<td>1</td>
			<td>6,1167</td>
			<td>0,7181</td>
		</tr>
		<tr>
			<td>2</td>
			<td>6,9144</td>
			<td>0,6825</td>
		</tr>
		<tr>
			<td>3</td>
			<td>0,5335</td>
			<td>0,6945</td>
		</tr>
		<tr>
			<td rowspan="3">3</td>
			<td rowspan="3">space.txt</td>
			<td rowspan="3">6559</td>
			<td rowspan="3">450</td>
			<td>1</td>
			<td>4,8626</td>
			<td>0,5267</td>
		</tr>
		<tr>
			<td>2</td>
			<td>5,5041</td>
			<td>0,5062</td>
		</tr>
		<tr>
			<td>3</td>
			<td>0,5618</td>
			<td>0,7756</td>
		</tr>
	</tbody>
</table>
</figure> 

<figure>
   <p align="center">
      <img src="https://github.com/dr-number/larionov_semestr_7_lab_2-read_files_calc_spaces/blob/main/for_read_me/2.png">
      <p align="center">Если txt файлы отсутствуют</p>
   </p>
</figure>