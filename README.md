# Tellow Waypoint
**A desktop app that let users manually control and create flightplans for Tello drone with intuitive control UI and live positioning tracking in 3D view.** <br />
Built with: 
- C# .NET framework
- OpenGL
- OpenTK

# Control Tello using C# App
- C# app is a mininal control hub that let you control Tello using your keyboard, create waypoint flight plan and get real time 3D trajectory of the drone.
- To access manual mode navigate to the C# app folder and run Tello_GUI.sln on your Visual Studio, then run Basic_GUI.
- To access waypoint mode navigate to the C# app folder and run Tello_GUI.sln on your Visual Studio, then run FlightPLan.


# Indoor Waypoints
Positioning data collected from tello is estimated using Multimotion Visual Odemetry (MVO) and parsed using a C# library called TelloLib. 
- Learn more about [MVO](http://www.robots.ox.ac.uk/~mobile/Papers/2018IROS_judd.pdf)
- Learn more about [TelloLib](https://github.com/Kragrathea/TelloLib)

# Key Points about MVO data collected from TelloLib
**Mvo data is recorded in meters and the drone's mvo data will shoot to random number after it taking off.**  <br />
**When booting up the drone, it will reset the yaw angle to 0 with respect to its front facing camera.** <br />
![alt text](https://github.com/nhatduy227/Tello_waypoint/blob/master/assets/tellodrone.jpg) <br />
**When Yaw angle is 0:** 
- Fly forward: PosX increase
- Fly backward: PosX decrease
- Fly left: PosY increase
- Fly right: PosY decrease
- Fly upward: Height increase
- Fly downward: Height decrease 
- Clockwise: Yaw angle increase toward 360 (Yaw angle will reset to 0 if go pass 360)
- Counter Clockwise: Yaw angle decrease toward 0 (Yaw angle will reset to 360 if go below 360)
Position Data won't reset on changing Yaw angle 

# Vision Positioning System (VPS)
**Tello positioning data and fly behavior is recorded and monitor using the built-in VPS. Therefore, to minimize drifting and noise data during flights, please advice precaution instructions below.** <br/>
![alt text](https://github.com/nhatduy227/Tello_waypoint/blob/master/assets/VPS.PNG)

# Drone Swarm
For Drone Swarming, we need to have Tello EDUs. Tello EDU has different mode, which are IP mode and Wifi mode.
To archive drone swarming, we need to:  
- Step 1: Set Tello EDUs to IP mode
- Step 2: Communicate with each tello EDU in the system to coordinate the swarm 
- Step 3: Send Flight Mission to each tello EDU

For detail execution, please visit [here](https://www.notion.so/Drone-Swarming-Guides-c62abe7cc702443e8855c52e6c4c27d4)
# Tello SDK
Learn more about Tello SDK [here](https://dl-cdn.ryzerobotics.com/downloads/Tello/Tello%20User%20Manual%20v1.4.pdf)
and Tello SDK 2.0 [here](https://dl-cdn.ryzerobotics.com/downloads/Tello/Tello%20SDK%202.0%20User%20Guide.pdf)

