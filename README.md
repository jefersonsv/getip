# Getip
It's a fast kestrel server to inform your public IP address

## Windows command line service
```bash
git clone https://github.com/jefersonsv/getip
dotnet run
```

## Docker
Images to run getip in docker container


### from local container
```bash
git clone https://github.com/jefersonsv/getip
cd getip/src
sudo docker build -t getip .
sudo docker run --restart=unless-stopped -d -p 4020:5000 --name getip getip
```

### from docker hub
```bash
docker run -p 8081:5000 jefersonsv/getip
```

## How to test
```bash
curl 'http://localhost:4020'
```

## Similar hosted services
* https://api.ipify.org
* http://checkip.dyndns.org

