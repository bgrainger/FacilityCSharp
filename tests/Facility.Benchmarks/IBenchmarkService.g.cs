// <auto-generated>
// DO NOT EDIT: generated by fsdgencsharp
// </auto-generated>
#nullable enable
using System;
using System.Threading;
using System.Threading.Tasks;
using Facility.Core;

namespace Facility.Benchmarks
{
	/// <summary>
	/// Common service elements.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public partial interface IBenchmarkService
	{
		Task<ServiceResult<GetUsersResponseDto>> GetUsersAsync(GetUsersRequestDto request, CancellationToken cancellationToken = default);
	}
}