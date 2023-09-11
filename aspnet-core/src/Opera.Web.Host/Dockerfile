FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Opera.Web.Host/Opera.Web.Host.csproj", "src/Opera.Web.Host/"]
COPY ["src/Opera.Web.Core/Opera.Web.Core.csproj", "src/Opera.Web.Core/"]
COPY ["src/Opera.Application/Opera.Application.csproj", "src/Opera.Application/"]
COPY ["src/Opera.Core/Opera.Core.csproj", "src/Opera.Core/"]
COPY ["src/Opera.EntityFrameworkCore/Opera.EntityFrameworkCore.csproj", "src/Opera.EntityFrameworkCore/"]
WORKDIR "/src/src/Opera.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Opera.Web.Host", "src/Opera.Web.Host"]
COPY ["src/Opera.Web.Core", "src/Opera.Web.Core"]
COPY ["src/Opera.Application", "src/Opera.Application"]
COPY ["src/Opera.Core", "src/Opera.Core"]
COPY ["src/Opera.EntityFrameworkCore", "src/Opera.EntityFrameworkCore"]
WORKDIR "/src/src/Opera.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Opera.Web.Host.dll"]
