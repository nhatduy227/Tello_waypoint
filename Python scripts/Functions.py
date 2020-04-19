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
		print("acceleration: {}".format(t.get_acceleration()))
		print("baro: {}".format(t.get_baro()))
		print("speed: {}".format(t.get_speed()))
		print("temperature: {}".format(t.get_temp()))
		print("tof: {}".format(t.get_tof()))
		print("wifi: {}".format(t.get_wifi()))
		print("height: {}".format(t.get_height()))

t.takeoff()
polygon(3)
t.land()