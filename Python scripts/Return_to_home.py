from easytello import tello

t = tello.Tello()

t.takeoff()
attitude_list = []
for i in range(3):
    t.forward(100)
    attitude = t.get_attitude()
    t.cw(90)
    attitude_list.append(attitude)
first_point = attitude_list[0]
t.go(first_point[0],first_point[1],first_point[2],30)
t.land()