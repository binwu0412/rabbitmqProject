#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["RabbitmqMicroservices.Banking.Api/RabbitmqMicroservices.Banking.Api.csproj", "RabbitmqMicroservices.Banking.Api/"]
RUN dotnet restore "RabbitmqMicroservices.Banking.Api/RabbitmqMicroservices.Banking.Api.csproj"
COPY . .
WORKDIR "/src/RabbitmqMicroservices.Banking.Api"
RUN dotnet build "RabbitmqMicroservices.Banking.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RabbitmqMicroservices.Banking.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RabbitmqMicroservices.Banking.Api.dll"]