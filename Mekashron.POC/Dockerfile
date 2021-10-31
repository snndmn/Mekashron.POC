#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["/Mekashron.POC.csproj", "Mekashron.POC/"]
RUN dotnet restore "Mekashron.POC/Mekashron.POC.csproj"
COPY . .
WORKDIR "/src/Mekashron.POC"
RUN dotnet build "Mekashron.POC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mekashron.POC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mekashron.POC.dll"]