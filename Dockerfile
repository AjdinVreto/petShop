#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

EXPOSE 5013
ENV ASPNETCORE_URLS=http://+:5013

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY . .

FROM build AS publish
RUN dotnet publish "PetShop/PetShop.csproj" -c Release -o /app
FROM base AS final
WORKDIR /app
ADD ./PetShop/Images ./Images
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "PetShop.dll"]