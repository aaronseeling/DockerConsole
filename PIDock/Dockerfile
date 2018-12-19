FROM microsoft/dotnet:2.1-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY PIDock/PIDock.csproj PIDock/
RUN dotnet restore PIDock/PIDock.csproj
COPY . .
WORKDIR /src/PIDock
RUN dotnet build PIDock.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish PIDock.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PIDock.dll"]
