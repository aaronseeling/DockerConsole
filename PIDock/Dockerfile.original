FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MakingPi/MakingPi.csproj", "MakingPi/"]
RUN dotnet restore "MakingPi/MakingPi.csproj"
COPY . .
WORKDIR "/src/MakingPi"
RUN dotnet build "MakingPi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MakingPi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MakingPi.dll"]