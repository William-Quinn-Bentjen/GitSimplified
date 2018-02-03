@echo off
:START
CLS
ECHO ########################################################################
ECHO.
ECHO  #####           #####                                                  
ECHO #     # # ##### #     # # #    # #####  #      # ###### # ###### #####  
ECHO #       #   #   #       # ##  ## #    # #      # #      # #      #    # 
ECHO #  #### #   #    #####  # # ## # #    # #      # #####  # #####  #    # 
ECHO #     # #   #         # # #    # #####  #      # #      # #      #    # 
ECHO #     # #   #   #     # # #    # #      #      # #      # #      #    # 
ECHO  #####  #   #    #####  # #    # #      ###### # #      # ###### #####  
ECHO.
ECHO ########################################################################
ECHO Remember if your path or commit message has a space in it to surround it with two ""double quotes""
ECHO Also remember that all commands are in lowercase
echo use gsback to go back to the previous screen
ECHO use gsexit to exit GitSimplified.bat
ECHO.
ECHO.
ECHO.
ECHO.
SET /P arg2= Please enter the folder to run commands in:
IF "%arg2%"=="gsexit" GOTO END
IF exist "%arg2%" GOTO CDARG2
GOTO START
:CDARG2
cd "%arg2%"
GOTO ARG1SCREEN
:ARG1SCREEN
CLS
ECHO Working directory: %arg2%
ECHO.
ECHO AVLALIBLE COMMANDS
ECHO.
ECHO push           - pushes to GitHub
ECHO pull           - pulls from GitHub
ECHO clone          - clones from GitHub
ECHO init           - initalizes and pushes to GitHub
ECHO addgitignore   - creates a .gitignore file in  working directory 
ECHO checkout       - used to check out diffrent branch
ECHO.
ECHO these commands are for pushing (dont use these unless you know what you're doing
ECHO status         - see the status of files that haven't been commited
ECHO addfiles       - adds files for a commit
ECHO.
SET /P arg1= Please enter the comand you want to run:
IF "%arg1%"=="push" GOTO PUSHMANUAL
IF "%arg1%"=="pull" GOTO PULLMANUAL
IF "%arg1%"=="init" GOTO INITMANUAL
IF "%arg1%"=="clone" GOTO CLONEMANUAL
IF "%arg1%"=="addgitignore" GOTO ADDGITIGNORE
IF "%arg1%"=="status" GOTO STATUS
IF "%arg1%"=="addfiles" GOTO ADDFILES
IF "%arg1%"=="checkout" GOTO CHECKOUT
IF "%arg2%"=="gsexit" GOTO END
IF "%arg1%"=="gsback" GOTO START
GOTO ARG1SCREEN
:CHECKOUT
CLS 
ECHO Working directory: %arg2%
ECHO Command: %arg1%
ECHO. 
SET /P checkoutarg= Please enter the branch name you wish to checkout:
IF "%checkout%"=="gsback" GOTO ARG1SCREEN
IF "%arg2%"=="gsexit" GOTO END
git checkout %checkout%
GOTO ARG1SCREEN

:PUSHMANUAL
CLS
ECHO Working directory: %arg2%
ECHO Command: %arg1%
ECHO.
SET /P pushmsg= Please enter a commit message in quotes:
IF "%pushmsg%"=="gsback" GOTO ARG1SCREEN
IF "%arg2%"=="gsexit" GOTO END
git add .
git commit -m "%pushmsg%"
git push
pause
GOTO ARG1SCREEN

:PULLMANUAL
CLS
ECHO Working directory: %arg2%
ECHO Command: %arg1%
ECHO.
git pull
pause
GOTO ARG1SCREEN

:INITMANUAL
CLS
ECHO Working directory: %arg2%
ECHO Command: %arg1%
ECHO.
SET /P initmsg= Please enter a commit message in quotes:
IF "%initmsg%"=="gsback" GOTO ARG1SCREEN
IF "%arg2%"=="gsexit" GOTO END
git add .
git commit -m %initmsg%
ECHO.
SET /P initurl= Please enter a URL for a remote origin:
IF "%initurl%"=="gsback" GOTO ARG1SCREEN
IF "%arg2%"=="gsexit" GOTO END
git remote add origin %initurl%
git push -u master
pause
GOTO ARG1SCREEN

:CLONEMANUAL
CLS
ECHO Working directory: %arg2%
ECHO Command: %arg1%
ECHO.
SET /P cloneurl= Please enter the URL of the repo:
IF "%cloneurl%"=="gsback" GOTO ARG1SCREEN
IF "%arg2%"=="gsexit" GOTO END
SET /P clonebranch= Please enter the branch to pull (you can leave blank):
IF "%clonebranch%"=="gsback" GOTO ARG1SCREEN
IF "%arg2%"=="gsexit" GOTO END
IF "%clonebranch%"=="" GOTO CLONEMANUALNOBRANCH
git clone -b %clonebranch% %cloneurl%
pause
GOTO ARG1SCREEN
:CLONEMANUALNOBRANCH
git clone %cloneurl%
pause
GOTO ARG1SCREEN
 
:STATUS
CLS
ECHO Working directory: %arg2%
ECHO Command: %arg1%
ECHO.
git status
pause
GOTO ARG1SCREEN

:ADDGITIGNORE
CLS
ECHO Working directory: %arg2%
ECHO Command: %arg1%
ECHO.
fsutil file createnew .gitignore 2000
pause
GOTO ARG1SCREEN

:ADDFILES
CLS
ECHO Working directory: %arg2%
ECHO Command: %arg1%
ECHO.
git add .
pause
GOTO ARG1SCREEN


:END
ECHO.
ECHO EXITING GitSimplified
pause