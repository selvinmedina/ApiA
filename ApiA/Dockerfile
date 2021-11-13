FROM mcr.microsoft.com/dotnet/aspnet:3.1-focal AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1-focal AS build

WORKDIR /src
COPY ["ApiA.csproj", "./"]
COPY . .
WORKDIR "/src/."
RUN dotnet build "ApiA.csproj" -c Release -o /app/build
FROM build AS publish

RUN dotnet publish "ApiA.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV SALUDO="Hola desde Docker"
ENTRYPOINT ["dotnet", "ApiA.dll"]