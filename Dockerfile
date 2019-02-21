FROM microsoft/dotnet:2.0-sdk AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY ./src/*.csproj ./
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# build runtime image
# microsoft/dotnet:2.0-runtime # don't work
FROM microsoft/dotnet:2.0-sdk
WORKDIR /app
COPY --from=build-env /app/out ./

ENTRYPOINT ["dotnet", "getip.dll"]