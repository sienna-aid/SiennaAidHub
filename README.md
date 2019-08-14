WINDOWS
	bash -c "ssh-keygen -t rsa && ssh-copy-id pi@xxx.xxx.xxx.xxx"
	plink -ssh -pw raspberry pi@raspberrypi
	
RASPBERRY
	curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -r linux-arm -v latest -l ~/vsdbg
	