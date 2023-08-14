// <auto-generated>
// DO NOT EDIT: generated by fsdgencsharp
// </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using Facility.Core;
using Facility.Core.MessagePack;

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

		[MessagePack.Key(0)]
		public int? Limit { get; set; }

		/// <summary>
		/// The JSON serializer.
		/// </summary>
		protected override JsonServiceSerializer JsonSerializer => SystemTextJsonServiceSerializer.Instance;

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
