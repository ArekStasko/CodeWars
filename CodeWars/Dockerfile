FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CodeWars/CodeWars.csproj", "CodeWars/"]
RUN dotnet restore "CodeWars/CodeWars.csproj"
COPY . .
WORKDIR "/src/CodeWars"
RUN dotnet build "CodeWars.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CodeWars.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeWars.dll"]
