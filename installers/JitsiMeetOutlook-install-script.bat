@ECHO OFF
::=======================
:: SETUP
::=======================
::Jitsi access
set ROOMID=default_room
set DOMAIN=domain:port
::next variables, either True or False
set REQNAME=False
set NOAUDIO=False
set NOVIDEO=False
::specify the display language (en/fr/ru)
set LANG=en
::======================
:: Plugin URL and paths
::======================
set origin=https://github.com/timetheoretical/jitsi-meet-outlook/releases/download/v0.7.0/JitsiMeetOutlook-v0.7.0-windows-anycpu.msi
set target=%ProgramFiles%\Jitsi Meet Outlook
:: if x86 version, use target=%ProgramFiles(x86)%\Jitsi Meet Outlook
:: if x64 version, use target=%ProgramFiles%\Jitsi Meet Outlook


::===============

ECHO Deleting previous version...
IF EXIST %target% (
    ECHO deleting %target%
    RMDIR "%target%" /S /Q
) ELSE ( 
    ECHO No previous installation found.
)
ECHO Downloading plugin Jitsi-Meet-Outlook...
:PowerShell
SET PSScript=%TEMP%\~tmpDlFile.ps1
IF EXIST "%PSScript%" DEL /Q /F "%PSScript%"
ECHO [Net.ServicePointManager]::SecurityProtocol = "tls12, tls11, tls">>"%PSScript%"
ECHO Invoke-WebRequest "%origin%" -OutFile "%TEMP%\jmo.msi">>"%PSScript%"
SET PowerShellDir=C:\Windows\System32\WindowsPowerShell\v1.0
CD /D "%PowerShellDir%"
Powershell -ExecutionPolicy Bypass -Command "& '%PSScript%'"
ECHO Download done.
ECHO Plugin installation...
msiexec /i "%TEMP%\jmo.msi" TARGETDIR="%target%" DOMAIN="%DOMAIN%" ROOMID="%roomid%" REQNAME="%reqname%" NOAUDIO="%noaudio%" NOVIDEO="%novideo%" LANG="%lang%" /passive
ECHO Done.
PAUSE
