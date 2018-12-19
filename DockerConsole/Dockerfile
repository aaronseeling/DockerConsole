FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["DockerConsole/DockerConsole.csproj", "DockerConsole/"]
RUN dotnet restore "DockerConsole/DockerConsole.csproj"
COPY . .
WORKDIR "/src/DockerConsole"
RUN dotnet build "DockerConsole.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DockerConsole.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DockerConsole.dll"]