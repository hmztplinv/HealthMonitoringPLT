FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["OrganizationService/OrganizationService.csproj", "OrganizationService/"]
COPY ["SharedKernel/SharedKernel.csproj", "SharedKernel/"]
RUN dotnet restore "OrganizationService/OrganizationService.csproj"
COPY . .
WORKDIR "/src/OrganizationService"
RUN dotnet build "OrganizationService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OrganizationService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OrganizationService.dll"]
