from Tello import Tello 
from TelloUI import TelloUI 


def main():
    drone = Tello('', 8889)  
    vplayer = TelloUI(drone)
    vplayer.root.mainloop() 


if __name__ == '__main__':
    main()