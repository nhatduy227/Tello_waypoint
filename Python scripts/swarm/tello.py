from tello_controller import TelloController

class Tello:
    """ Single Tello object
    """
    def __init__(self, ip_addr):
        self.ip_addr = ip_addr
        self.tello_controller = TelloController

    def __str__(self):
        return f'Tello@{self.ip_addr}'
        
    def send_command(self, command):
        self.tello_controller.send_command(command, self.ip_addr)

    



