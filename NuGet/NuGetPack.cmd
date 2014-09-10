SET NUGET=..\src\.nuget\nuget
%NUGET% pack ServiceStack\servicestack.nuspec -symbols -Version "3.9.%BUILD_NUMBER%"

%NUGET% pack ServiceStack.Common\servicestack.common.nuspec -symbols -Version "3.9.%BUILD_NUMBER%"
