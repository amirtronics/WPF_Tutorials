set repo_path=C:\Work\Codes\HMI\VS\WPF_Tutorials
set file_name=NormalWindow.xaml.cs
set file_path=.\Ep19_ShowDialog\WPFTutorial\View\%file_name%

set commit_message=Create Ep19 View %file_name%

echo %file_name%
echo %file_path%
echo %commit_message%

cd %repo_path%

git add %file_path%

git commit -m "%commit_message%"
git push

echo Commit and Push Complete!