#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MemorialArchiver/Server/MemorialArchiver.Server.csproj", "MemorialArchiver/Server/"]
COPY ["MemorialArchiver/Shared/MemorialArchiver.Shared.csproj", "MemorialArchiver/Shared/"]
COPY ["MemorialArchiver/Client/MemorialArchiver.Client.csproj", "MemorialArchiver/Client/"]
RUN dotnet restore "MemorialArchiver/Server/MemorialArchiver.Server.csproj"
COPY . .
WORKDIR "/src/MemorialArchiver/Server"
RUN dotnet build "MemorialArchiver.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MemorialArchiver.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MemorialArchiver.Server.dll"]