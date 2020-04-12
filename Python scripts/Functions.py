from easytello import tello

t = tello.Tello()
# fly operations
def fly_square():
	for i in range(4):
		t.forward(100)
		t.cw(90)
def polygon(sides):
	for i in range(sides):
		t.forward(150)
		t.cw(360/sides)

