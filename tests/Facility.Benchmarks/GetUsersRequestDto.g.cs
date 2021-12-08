// <auto-generated>
// DO NOT EDIT: generated by fsdgencsharp
// </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using Facility.Core;

namespace Facility.Benchmarks
{
	/// <summary>
	/// Request for GetUsers.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	[MessagePack.MessagePackObject]
	public sealed partial class GetUsersRequestDto : ServiceDto<GetUsersRequestDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public GetUsersRequestDto()
		{
		}

		[MessagePack.Key("limit")]
		public int? Limit { get; set; }

		/// <summary>
		/// Returns the DTO as JSON.
		/// </summary>
		public override string ToString() => SystemTextJsonServiceSerializer.Instance.ToJson(this);

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(GetUsersRequestDto? other)
		{
			return other != null &&
				Limit == other.Limit;
		}
	}
}
