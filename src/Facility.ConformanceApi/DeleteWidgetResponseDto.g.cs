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
	/// Response for DeleteWidget.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	[MessagePack.MessagePackObject]
	public sealed partial class DeleteWidgetResponseDto : ServiceDto<DeleteWidgetResponseDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public DeleteWidgetResponseDto()
		{
		}

		/// <summary>
		/// The widget was not found.
		/// </summary>
		[MessagePack.Key("notFound")]
		public bool? NotFound { get; set; }

		/// <summary>
		/// The widget no longer has the specified ETag.
		/// </summary>
		[MessagePack.Key("conflict")]
		public bool? Conflict { get; set; }

		/// <summary>
		/// The JSON serializer.
		/// </summary>
		protected override JsonServiceSerializer JsonSerializer => SystemTextJsonServiceSerializer.Instance;

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(DeleteWidgetResponseDto? other)
		{
			return other != null &&
				NotFound == other.NotFound &&
				Conflict == other.Conflict;
		}
	}
}
