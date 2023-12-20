@echo off
setlocal enabledelayedexpansion

set repo_path=C:\Work\Codes\HMI\VS\WPF_Tutorials\Styles
set file_names=ButtonStyles.xaml TextBoxStyles.xaml

for %%F in (%file_names%) do (
    
    set file_path=.\Ep20_ReusableResources\WPFTutorial\Styles\%%F
    set commit_message=Create Ep20 %%F

    cd %repo_path%
    echo !file_path!
    git add !file_path!

    git commit -m "!commit_message!"
    git push

    echo Commit and Push Complete!
)