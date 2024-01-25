# WorkForAll

# Database Project (!!!Only for MS SqlServer!!!)
1) Right click on database => Tasks => Extract Data-tire... (you will create *.dacpac file).
2) You can choose where to save the dacpac file and then click Next.
3) Create an "SQL Server Database Project" in VS.
4) Right click on the references => select an option 'Add database reference' => 
	select an option => "Data-tire program (.dacpac)" => browse... => select .dacpac file from the 1st step
5) Under "Database location" select "different database, different server" => OK.
6) Right click on your sql project and select the option "Import" => "Data-tire program (*.dacpac)..." =>
	browse... => select the .dacpac file from the 1st step
7) Select "Import settings" you need => click "Start" => "Finish".

#Scaffolding
1)dotnet tool install --global dotnet-ef
2)Install packages:
-------------------
	NuGet\Install-Package Microsoft.EntityFrameworkCore -Version 7.0.15
	NuGet\Install-Package Microsoft.EntityFrameworkCore.Design -Version 7.0.15
	NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 7.0.15
3)cmd || pmc => C:\Users\user\Downloads\GitHubProjects\Patterns\Patterns.BusinessObjects>dotnet ef dbcontext scaffold "Data Source=server_name\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=True;Trust Server Certificate=True;Command Timeout=0" Microsoft.EntityFrameworkCore.SqlServer --context-dir Data --output-dir  Models\Company
Welcome!