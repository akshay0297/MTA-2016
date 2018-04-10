@echo off
rem A batch file for TestError.exe
rem which captures the app's return value.
rem the follwoing line executes the TestError.exe and captures the return from the method
rem On the Windows operating system, an application’s return value is stored within a system
rem environment variable named %ERRORLEVEL%.

TestError
@if "%ERRORLEVEL%" == "0" goto success
:fail
echo This application has failed!
echo return value = %ERRORLEVEL%
goto end
:success
echo This application has succeeded!
echo return value = %ERRORLEVEL%
goto end
:end
echo All Done.
