# Tellow Waypoint
Goal: We aim to create an app that let users manually control and create flightplans for Tello drone 

# Control Tello using C# App
- C# app is a mininal control hub that let you control Tello using your keyboard and get real time 2D trajectory of the drone.
- To use C# app navigate to the C# app folder and run Tello_GUI.sln on your Visual Studio, then run Basic_GUI.

# Indoor Waypoints
Positioning data collected from tello is estimated using Multimotion Visual Odemetry (MVO) and parsed using a C# library called TelloLib. 
- Learn more about [MVO](http://www.robots.ox.ac.uk/~mobile/Papers/2018IROS_judd.pdf)
- Learn more about [TelloLib](https://github.com/Kragrathea/TelloLib)

Positioning data of past runs is saved under the XML-positioning directory.

# Key Points about MVO data collected from TelloLib
**Mvo data is recorded in meters and the drone's mvo data will shoot to random number after it taking off.**  <br />
**When booting up the drone, it will reset the yaw angle to 0 with respect to its front facing camera.** <br />
![alt text](https://github.com/nhatduy227/Tello_waypoint/blob/feat/update-readme/assets/tellodrone.jpg) <br />
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

# Drone Swarm
For Drone Swarming, we need to have Tello EDUs. Tello EDU has different mode, which are IP mode and Wifi mode.
To archive drone swarming, we need to:  
- Step 1: Set Tello EDUs to IP mode
- Step 2: Communicate with each tello EDU in the system to coordinate the swarm 
- Step 3: Send Flight Mission to each tello EDU

For detail execution, please visit [here](https://www.notion.so/Drone-Swarming-Guides-c62abe7cc702443e8855c52e6c4c27d4)
# Tello SDK
Learn more about Tello SDK [here](https://dl-cdn.ryzerobotics.com/downloads/Tello/Tello%20SDK%202.0%20User%20Guide.pdf)

