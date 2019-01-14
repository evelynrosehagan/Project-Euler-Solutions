def ser(array):
	
	for i in range(79,-1,-1):
		for j in range(79,-1,-1):
			if i < 79 and j < 79:
				v1 = array[i+1][j]
				v2 = array[i][j+1]
				if v1 > v2:
					v1 = v2
				array[i][j] = array[i][j] + v1
			elif i < 79 and j == 79:
				array[i][j] = array[i][j] + array[i+1][j]
			elif i == 79 and j < 79:
				array[i][j] = array[i][j] + array[i][j+1]
	return array[0][0]
file = open("p081_matrix.txt", "r")
my_list = []
for line in file:	
	line = "".join(line.split())
	my_list.append(line.split(','))

int_list = []
for i in range (0,80,1):
	int_list.append([])
	for j in range(0,80,1):
		int_list[i].append(int(my_list[i][j]))
value = ser(int_list)
print (value)