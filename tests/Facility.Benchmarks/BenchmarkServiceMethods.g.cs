// <auto-generated>
// DO NOT EDIT: generated by fsdgencsharp
// </auto-generated>
#nullable enable
using System;
using Facility.Core;

namespace Facility.Benchmarks
{
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	internal static class BenchmarkServiceMethods
	{
		public static readonly IServiceMethodInfo GetUsers =
			ServiceMethodInfo.Create<IBenchmarkService, GetUsersRequestDto, GetUsersResponseDto>(
				"getUsers", "BenchmarkService", x => x.GetUsersAsync);
	}
}