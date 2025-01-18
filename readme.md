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
	<tbody>
		<tr>
			<td rowspan="2">№ попытки</td>
			<td>Файл</td>
			<td>Размер файла (байт)</td>
			<td>Количество пробелов</td>
			<td colspan="2">Метод</td>
			<td>Время выполнения (ms)</td>
		</tr>
		<tr>
			<td rowspan="6">1</td>
			<td rowspan="6">simulation_theory.txt</td>
			<td rowspan="6">12824</td>
			<td rowspan="6">882</td>
			<td>Cчитали файл полностью асинхронно и потом посчитали пробелы.</td>
			<td>Cчитали файл построчно и для каждой строчки считаем пробелы.</td>
		</tr>
		<tr>
			<td>8,3838</td>
		</tr>
		<tr>
			<td>1,1293</td>
		</tr>
		<tr>
			<td></td>
			<td>4,2342</td>
		</tr>
		<tr>
			<td>1,4471</td>
		</tr>
		<tr>
			<td>0,688</td>
		</tr>
		<tr>
			<td rowspan="6">2</td>
			<td rowspan="6">soviet_computers.txt</td>
			<td rowspan="6">14462</td>
			<td rowspan="6">1046</td>
			<td></td>
			<td>0,6248</td>
		</tr>
		<tr>
			<td>6,4981</td>
		</tr>
		<tr>
			<td>0,6025</td>
		</tr>
		<tr>
			<td></td>
			<td></td>
		</tr>
		<tr>
			<td></td>
		</tr>
		<tr>
			<td></td>
		</tr>
		<tr>
			<td rowspan="6">3</td>
			<td rowspan="6">space.txt</td>
			<td rowspan="6">6559</td>
			<td rowspan="6">450</td>
			<td></td>
			<td></td>
		</tr>
		<tr>
			<td></td>
		</tr>
		<tr>
			<td></td>
		</tr>
		<tr> 
			<td></td>
			<td></td>
		</tr>
		<tr>
			<td></td>
		</tr>
		<tr>
			<td></td>
		</tr>
	</tbody>
</table>
</table>
</figure> 