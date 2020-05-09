# Tellow Waypoint
Goal: We aim to create an app that let user create waypoint missions for Tello drone 

# Control Tello
You can control the drone by connecting through Wi-Fi UDP Port. There are 3 channels, each with a different UDP port (See Tello SDKs ([Version 2.0](https://dl-cdn.ryzerobotics.com/downloads/Tello/Tello%20SDK%202.0%20User%20Guide.pdf) or [Version 1.3.0.0](https://dl-cdn.ryzerobotics.com/downloads/tello/20180910/Tello%20SDK%20Documentation%20EN_1.3.pdf) ) for more information):
<br><br>Command Channel:<br>
- Tello IP: 192.168.10.1 UDP PORT:8889 <<- ->> PC/Mac/Mobile

State channel:<br>
- Tello IP: 192.168.10.1 ->> PC/Mac/Mobile UDP Server: 0.0.0.0 UDP PORT:8890

Stream channel<br>
- Tello IP: 192.168.10.1 ->> PC/Mac/Mobile UDP Server: 0.0.0.0 UDP PORT:11111

### Three basic command types.
Control Commands (xxx)
- "ok": executed successfully
- “error” / an informative result code: if unsuccessful

Read Commands (xxx?)
- current value of the sub-parameter(s).

Set Command (xxx a) will attempt to set a new sub-parameter value(s)
- “ok”: executed successfully
- “error”/ or an informative result code: if unsuccessful

### Tello State
“pitch:%d;roll:%d;yaw:%d;vgx:%d;vgy%d;vgz:%d;templ:%d;temph:%d;tof:%d;h:%d;bat:%d;baro:%.2f; time:%d;agx:%.2f;agy:%.2f;agz:%.2f;\r\n”

There's no x, y, z position coordinates. This [paper]() mentions about using yaw and speed to caculate (x, y, z) coordinates. 

## Projects that have been done on controlling and swarming Tello: 
- [easyTello](https://github.com/damiafuentes/DJITelloPy): drone communication 
- [DJITelloPy](https://github.com/Virodroid/easyTello): drone communication, swarming

We can send commands, read drone's status, and receive video streams by using Python library [socket](https://docs.python.org/3/library/socket.html) for low level networking interface and [threading](https://docs.python.org/3/library/threading.html) for higher-level threading interface.

## Indoor Waypoint
In this [thread](<br>https://forum.dji.com/forum.php?mod=viewthread&tid=210540), someone has an interesting comment on indoor waypoint:

"...the only usual way any GPS drone have to navigate in the horizontal plane is by means of GPS fix. Height control on the other hand can be achieved both with barometric & VPS sensors.

Even though if it existed some software that you could "parameter program" a track ... like "thrust level X" in "compass direction Y" "during Z seconds" the drone needs hardware to measure the success of each of those commands ... then even more complicated that each of these commands should be self generated out from a map.

So for this to work you at least need a software able to out from a map format generate drone instructions ... & then most probably additional hardware in the drone to interpret the instructions to thrust, direction & time plus something to verify that the instructions have been fulfilled..." 


## Drone Swarm
This [thread](https://tellopilots.com/threads/tello-drone-swarm.288/) suggesting using additional usb wifi adapter for drone swarming. Someone in the thread suggests using 5 wifi usb adapters to do swarm on 5 tello drones. 





