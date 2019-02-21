# Getip
It's a fast kestrel server to get your public IP address

## Docker
Images to run getip in docker container

### from docker hub
```bash
docker run -p 4020:5000 jefersonsv/getip
```

### from local container
```bash
git clone https://github.com/jefersonsv/getip
cd getip/src
sudo docker build -t getip .
sudo docker run --restart=unless-stopped -d -p 4020:5000 --name getip getip
```

## How to test
```bash
curl 'http://localhost:4020'
```

## Run locally
```bash
git clone https://github.com/jefersonsv/getip
dotnet run
```

## Similar hosted services
* https://api.ipify.org
* http://checkip.dyndns.org
