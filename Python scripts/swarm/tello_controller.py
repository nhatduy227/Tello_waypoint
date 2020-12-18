import socket
import threading

class TelloController:
    """ Control Tello
    """
    def __init__(self):
        self.local_ip = None
        self.local_port = 8889
        self.socket = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        self.socket.bind((self.local_ip, self.local_port))

        self.receive_thread = threading.Thread(target=self._receive_thread)
        self.receive_thread.daemon = True
        self.receive_thread.start()

        self.tello_ip_list = []
        self.tello_list = []
        self.log = ''

        self.TIMEOUT = 20.0
        self.last_response_index = {}
        self.str_cmd_index = {}


    def send_command(self, cmd, ip):
        """ Send command to IP_addr
        :return: response
        """
        # convert to unicode
        cmd_1 = ord(cmd[0])
        cmd_2 = ord(cmd[1])
        
        if cmd_1 == 0x52 and cmd_2 == 0x65:
            is_sending_multi_cmd = True
        else:
            is_sending_multi_cmd = False
        
        if is_sending_multi_cmd:
            self.str_cmd_index[ip] = self.str_cmd_index[ip] + 1
            for num in range(1, 5):
                str_cmd_index_h = self.str_cmd_index[ip] / 128 + 1
                str_cmd_index_l = self.str_cmd_index[ip] % 128
                if str_cmd_index_l == 0:
                    str_cmd_index_l = str_cmd_index_l + 2
                cmd_sof 
        else:
            pass


        while not self.log[ip][-1]:
            pass


    def _receive_thread(self):
        """
        """
