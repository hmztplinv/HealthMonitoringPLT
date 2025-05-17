FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["VitalService/VitalService.csproj", "VitalService/"]
COPY ["SharedKernel/SharedKernel.csproj", "SharedKernel/"]
RUN dotnet restore "VitalService/VitalService.csproj"
COPY . .
WORKDIR "/src/VitalService"
RUN dotnet build "VitalService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VitalService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VitalService.dll"]
