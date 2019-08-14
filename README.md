WINDOWS
	bash -c "ssh-keygen -t rsa && ssh-copy-id pi@xxx.xxx.xxx.xxx"
	plink -ssh -pw raspberry pi@raspberrypi
	
RASPBERRY
	curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -r linux-arm -v latest -l ~/vsdbg
	
SSL: 
http://richstokoe.com/2017/12/10/running-asp-net-core-raspbian-linux-raspberry-pi-https/

MONGO:
https://raspberrypi.stackexchange.com/questions/67918/unable-to-install-mongodb-3-4-on-pi-3 
https://docs.mongodb.com/ecosystem/drivers/driver-compatibility-reference/#c-net-driver-compatibility
https://hub.docker.com/r/andresvidal/rpi3-mongodb3/
https://github.com/andresvidal/rpi3-mongodb3/blob/master/Dockerfile

-> sudo ./usr/bin/mongod

! user/gruppe muss root sein im service und im /usr/bin, systemctl mit sudo 