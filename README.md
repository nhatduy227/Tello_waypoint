# Tello_waypoint
A desktop app that let user create waypoint missions for Tello drone 

# Prerequisites
Install Easytello package:
https://github.com/Virodroid/easyTello/blob/d8de60ccb06d0c5bb3304e9a9c9054318f54bbda/easytello/tello.py#L33

# Documentations
Tello SDKs: <br>
https://dl-cdn.ryzerobotics.com/downloads/Tello/Tello%20SDK%202.0%20User%20Guide.pdf <br>
https://dl-cdn.ryzerobotics.com/downloads/tello/20180910/Tello%20SDK%20Documentation%20EN_1.3.pdf <br>
Data Received From Tello Read Commands: <br>
+ Battery <br>
```python
from easytello import tello 

# initialize a tello object 
tello_object = tello.Tello()
tello_object.get_battery()
```
Return the remaining battery of the drone in scale of 100%. Possible response x: 0 - 100
+ Speed <br>
```python
tello_object.get_speed()
```
Return the current speed of the drone (cm/s). Possible response x: 10 - 100
+ Flight time <br>
```python
tello_object.get_time()
```
Return the flight time of the drone in second (s)
+ Height <br>
```python
tello_object.get_height()
```
Return the height of the drone in cm. Possible response x: 0-3000
+ Temperature
```python
tello_object.get_temp()
```
Return the current temperature of the drone in Celsius (C)
+ Attitude
```python
tello_object.get_attitude()
```
Return a list of current Inertial measurement unit (IMU) attitude data: pitch, roll and yaw of the drone (x,y,z) <br>
Learn more about drone attitude ratings at: https://www.novatel.com/solutions/attitude/
+ Barometer reading
```python
tello_object.get_baro()
```
Return the barometer measurement in m
Learn more about barometer readings at: 
+ Acceleration 
```python
tello_object.get_acceleration()
```
Return a list of Inertial measurement unit (IMU) angular acceleration data (x,y,z)
+ Time of Flight (TOF)
```python
tello_object.get_tof()
```
Return the TOF in cm <br>
+ Wifi Signal to Noise Ratio (SNR)
```python
tello_object.get_wifi()
```
Return the SNR of the drone to computer connection in dB. <br>
Learn more about SNR at: https://www.packet6.com/what-is-snr-signal-to-noise-ratio/