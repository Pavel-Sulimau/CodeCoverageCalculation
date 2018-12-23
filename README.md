# CodeCoverageCalculation

It's a cross-platform .NET Core solution with several test projects and an ability to easily generate a code coverage report on your local machine as well as inside an Azure DevOps build pipeline.

There is a `run_tests_and_generate_coverage_report.cake` script which is located in `scripts` folder and which can be used to generate code coverage reports. [Cake](https://cakebuild.net/) is a cross-platform build automation system which enables us to write build scripts in C#.  [Coverlet](https://github.com/tonerdo/coverlet) nuget package and [ReportGenerator](https://github.com/danielpalme/ReportGenerator) tool were utilized in the cake script. Also there are `run_tests_and_generate_coverage_report.sh` and `run_tests_and_generate_coverage_report.ps1` scripts which are used to run the cake script on a corresponding platform.

Use the following steps to generate a code coverage report locally on your machine:
1. Open the solution folder.
2. Go into `scripts` folder.
3. **[On Windows]** Open PowerShell window for this folder and use `.\run_tests_and_generate_coverage_report.ps1` command to execute the script. You may also need to change the user preference for the [PowerShell execution policy](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.security/set-executionpolicy?view=powershell-6). It determines which scripts, if any, must be degitally signed before they will run.
3. **[On Mac]** Open Terminal window for this folder and use`./run_tests_and_generate_coverage_report.sh` command to execute the script.
4. Navigate to the parent folder and go into `code_coverage` folder which was created by the script.
5. Open `index.htm` file and analyze the generated report.
