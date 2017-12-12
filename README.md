# Getip
It's a fast kestrel server to inform your public IP address

## Windows command line service
```bash
git clone https://github.com/jefersonsv/getip
dotnet run
```

## Docker container service
```bash
git clone https://github.com/jefersonsv/getip
sudo docker build -t getip .
sudo docker run -p 5000:5000 --rm getip
```

## Similar hosted services
https://api.ipify.org
http://checkip.dyndns.org

