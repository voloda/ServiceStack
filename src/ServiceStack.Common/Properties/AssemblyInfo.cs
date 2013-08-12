using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ServiceStack.Common")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("ServiceStack")]
[assembly: AssemblyProduct("ServiceStack.Common")]
[assembly: AssemblyCopyright("Copyright © ServiceStack 2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3871f659-64fb-4dfb-a49f-17dc2f8a47e2")]

[assembly: AssemblyVersion("1.0.0.0")]

// CCB Custom
[assembly: ContractNamespace("http://schemas.servicestack.net/types",
 ClrNamespace = "ServiceStack.Common.ServiceClient.Web")]

[assembly: ContractNamespace("http://schemas.servicestack.net/types",
 ClrNamespace = "ServiceStack.Common.ServiceModel")]

[assembly: InternalsVisibleTo("ServiceStack.Common.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001003f23e2eca53e8d4587bba1c1f87883058481e167985dc886b414b17d1c1f4d1c614b2802f5a414f1e03dcbd4410c1b4b177f7691b3f570ab75e0c46e59773ef4d443c8c36d14e157c50328eba2c71df56220d34a11f83a5820fb60fbdbf71eec4fa91035bbab369517f6809d3ee9ea47dc0e5b1e1731e32e0a5d96dabadb37c8")]
