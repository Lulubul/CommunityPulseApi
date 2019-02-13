FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["CommunityPulse/CommunityPulse.csproj", "CommunityPulse/"]
RUN dotnet restore "CommunityPulse/CommunityPulse.csproj"
COPY . .
WORKDIR "/src/CommunityPulse"
RUN dotnet build "CommunityPulse.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CommunityPulse.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CommunityPulse.dll"]