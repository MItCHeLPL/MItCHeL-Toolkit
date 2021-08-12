# Setting up Linux service

## Create the service file
```
sudo touch /etc/systemd/system/[service-name].service
```

## Edit the service file
```
sudo nano /etc/systemd/system/[service-name].service
```

## Input service layout:
```
[Unit]
Description=[service-description]
After=syslog.target
After=network.target
After=memcached.service redis.service

[Service]
Type=simple
User=[your-user-name]
Group=[your-group-name]
WorkingDirectory=[path-to-your-project-files]
ExecStart=[execute-command]
Restart=always
Environment=USER=[your-user-name] HOME=/home/[your-user-name]

[Install]
WantedBy=multi-user.target
```

### For example
```
[Unit]
Description=My script
After=syslog.target
After=network.target
After=memcached.service redis.service

[Service]
Type=simple
User=pi
Group=pi
WorkingDirectory=/home/pi/MyScript
ExecStart=/usr/bin/bash script.sh
Restart=always
Environment=USER=pi HOME=/home/pi

[Install]
WantedBy=multi-user.target
```

### Press `Ctrl+X`, than press `Y` and `Enter` to save file

## Enable the service (this will cause it to start on boot)
```
sudo systemctl enable [service-name]
```

## Managing service
### Start the service so it starts running now
```
sudo service [service-name] start
```

## If you make a change to your script, restart the service so the changes are picked up
```
sudo service [service-name] restart
```

## If you want to stop service
```
sudo service [service-name] stop
```

## If you want to see service status
```
sudo service [service-name] status
```

## Useful links
* [GitHub - "DiscordBotPi service"](https://github.com/gngrninja/blog/tree/master/DiscordBotPi/service)
* [medium - "Creating a Linux service with systemd"](https://medium.com/@benmorel/creating-a-linux-service-with-systemd-611b5c8b91d6)
