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
ECHO Remember if your path or commit message has a space in it to surround it with "quotes"
ECHO Also remember that all commands are in lowercase
echo use gsback to go back to the previous screen
ECHO use gsexit to exit GitSimplified.bat
ECHO.
ECHO.
ECHO.
ECHO.
SET /P arg2= Please enter the folder to run commands in:
IF "%arg2%"=="gsexit" GOTO END
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
ECHO.
SET /P arg1= Please enter the comand you want to run:
IF "%arg1%"=="push" GOTO PUSHMANUAL
IF "%arg1%"=="pull" GOTO PULLMANUAL
IF "%arg1%"=="init" GOTO INITMANUAL
IF "%arg1%"=="clone" GOTO CLONEMANUAL
#IF "%arg1%"=="addgitignore" GOTO ADDGITIGNORE
#IF "%arg1%"=="status" GOTO STATUS
#IF "%arg1%"=="addfiles" GOTO ADDFILES
#IF "%arg1%"=="checkout" GOTO CHECKOUT
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
GitSimplified.bat push %arg2% %pushmsg%
pause
GOTO ARG1SCREEN

:PULLMANUAL
CLS
ECHO Working directory: %arg2%
ECHO Command: %arg1%
ECHO.
GitSimplified.bat pull %arg2%
pause
GOTO ARG1SCREEN

:INITMANUAL
CLS
ECHO Working directory: %arg2%
ECHO Command: %arg1%
ECHO.
SET /P initmsg= Please enter a commit message in quotes:
IF "%initmsg%"=="gsback" GOTO ARG1SCREEN
IF "%initmsg%"=="gsexit" GOTO END
ECHO.
SET /P initurl= Please enter a URL for a remote origin:
IF "%initurl%"=="gsback" GOTO ARG1SCREEN
IF "%initurl%"=="gsexit" GOTO END
GitSimplified.bat init %arg2% %initurl% %initmsg%
pause
GOTO ARG1SCREEN

:CLONEMANUAL
CLS
ECHO Working directory: %arg2%
ECHO Command: %arg1%
ECHO.
SET /P cloneurl= Please enter the URL of the repo:
IF "%cloneurl%"=="gsback" GOTO ARG1SCREEN
IF "%cloneurl%"=="gsexit" GOTO END
SET /P clonebranch= Please enter the branch to pull (you can leave blank):
IF "%clonebranch%"=="gsback" GOTO ARG1SCREEN
IF "%clonebranch%"=="gsexit" GOTO END
IF "%clonebranch%"=="" GOTO CLONEMANUALNOBRANCH
#git clone -b %clonebranch% %cloneurl%
GitSimplified.bat clone %arg2% %cloneurl% %clonebranch%
pause
GOTO ARG1SCREEN
:CLONEMANUALNOBRANCH
GitSimplified.bat clone %arg2% %cloneurl% %clonebranch%
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