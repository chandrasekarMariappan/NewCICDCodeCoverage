		print 'chandra'	



dotnet test --logger "trx;LogFileName=TestResults.trx" ^
            --logger "xunit;LogFileName=TestResults.xml" ^
            --results-directory ./BuildReports/UnitTests ^
            /p:CollectCoverage=true ^
            /p:CoverletOutput=BuildReports\Coverage\ ^
            /p:CoverletOutputFormat=cobertura ^
            /p:Exclude="[xunit.*]*
pause