@echo off

set repo_path=C:\Work\Codes\HMI\VS\WPF_Tutorials
set file_name=App.xaml.cs
set file_path=.\Ep19_ShowDialog\WPFTutorial\%file_name%

set commit_message=Create Ep18 %file_name%

echo %file_name%
echo %file_path%
echo %commit_message%

REM cd %repo_path%

REM git add %file_path%

REM git commit -m "%commit_message%"
REM git push origin master

echo Commit and Push Complete!