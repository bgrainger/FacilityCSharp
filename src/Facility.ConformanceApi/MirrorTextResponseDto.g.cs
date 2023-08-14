// <auto-generated>
// DO NOT EDIT: generated by fsdgencsharp
// </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using Facility.Core;
using Facility.Core.MessagePack;

namespace Facility.ConformanceApi
{
	/// <summary>
	/// Response for MirrorText.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	[MessagePack.MessagePackObject]
	public sealed partial class MirrorTextResponseDto : ServiceDto<MirrorTextResponseDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public MirrorTextResponseDto()
		{
		}

		[MessagePack.Key("content")]
		public string? Content { get; set; }

		[MessagePack.Key("type")]
		public string? Type { get; set; }

		/// <summary>
		/// The JSON serializer.
		/// </summary>
		protected override JsonServiceSerializer JsonSerializer => SystemTextJsonServiceSerializer.Instance;

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(MirrorTextResponseDto? other)
		{
			return other != null &&
				Content == other.Content &&
				Type == other.Type;
		}
	}
}
