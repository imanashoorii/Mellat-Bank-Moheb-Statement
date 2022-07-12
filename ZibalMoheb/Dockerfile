FROM mcr.microsoft.com/dotnet/sdk:6.0-windowsservercore-ltsc2019

SHELL ["powershell"]

RUN powershell Add-WindowsFeature NET-Framework-45-ASPNET

EXPOSE 8080

WORKDIR /app
ADD ./bin/Debug .
COPY ./certs/ ./certs/

RUN Import-PfxCertificate -FilePath C:\app\certs\zibal.pfx -CertStoreLocation Cert:\LocalMachine\My
RUN Import-Certificate -FilePath C:\app\certs\mellatmoheb.ir.cer -CertStoreLocation Cert:\LocalMachine\TrustedPeople
RUN ["tzutil", "/s", "Iran Standard Time"]

ENV ASPNETCORE_ENVIRONMENT="Development"
RUN dir
ENTRYPOINT ["ZibalMoheb.exe"]