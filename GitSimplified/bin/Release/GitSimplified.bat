@echo off
IF "%1"=="push" GOTO PUSH
IF "%1"=="pull" GOTO PULL
IF "%1"=="init" GOTO INIT
IF "%1"=="clone" GOTO CLONE
ECHO STARTED WITH NO ARGUMENTS OR AN INVALID ARGUMENT
ECHO ARGUMENTS FORMAT
ECHO ########################################################################
ECHO push directory message branch
ECHO pull directory branch
ECHO init directory URL CommitMessage branch
ECHO clone directory URL branch
ECHO ########################################################################
ECHO REMEMBER THAT IF YOUR ARGUMENT HAS A SPACE IT MUST BE SURROUNDED BY QUOTES 
pause
GOTO END


:PUSH
cd %~2
if "%4"=="" GOTO PUSHNOBRANCH
git checkout %4
:PUSHNOBRANCH
git add .
git commit -m "%~3"
git push
GOTO END

:PULL
cd %~2
if "%3"=="" GOTO PULLNOBRANCH
git checkout %3
:PULLNOBRANCH
git pull
GOTO END

:INIT
cd %~2
git init
git add .
git commit -m "%~4"
git remote add origin %3
IF "%5"=="" GOTO INITMASTER
git push -u origin %5
GOTO END
:INITMASTER
git push -u origin master
GOTO END

:CLONE
cd %~2
IF "%4"=="" GOTO CLONEMASTER
git clone -b %4 %~3
GOTO END
:CLONEMASTER
git clone %~3
GOTO END
:END
pause