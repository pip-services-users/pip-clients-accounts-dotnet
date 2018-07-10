# Build stage
FROM microsoft/aspnetcore-build:2 AS build

# set working directory
WORKDIR /app

# Restore
COPY Source/Interface/Interface.csproj ./Source/Interface/
RUN dotnet restore Source/Interface/Interface.csproj
COPY Source/Client/Client.csproj ./Source/Client/
RUN dotnet restore Source/Client/Client.csproj
COPY Test/Test.csproj ./Test/
RUN dotnet restore Test/Test.csproj

# Copy src
COPY . .
