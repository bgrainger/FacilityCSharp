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
	/// Request for CheckQuery.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	[MessagePack.MessagePackObject]
	public sealed partial class CheckQueryRequestDto : ServiceDto<CheckQueryRequestDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public CheckQueryRequestDto()
		{
		}

		[MessagePack.Key("string")]
		public string? String { get; set; }

		[MessagePack.Key("boolean")]
		public bool? Boolean { get; set; }

		[MessagePack.Key("double")]
		public double? Double { get; set; }

		[MessagePack.Key("int32")]
		public int? Int32 { get; set; }

		[MessagePack.Key("int64")]
		public long? Int64 { get; set; }

		[MessagePack.Key("decimal")]
		public decimal? Decimal { get; set; }

		[MessagePack.Key("enum")]
		public Answer? Enum { get; set; }

		[MessagePack.Key("datetime")]
		public DateTime? Datetime { get; set; }

		/// <summary>
		/// The JSON serializer.
		/// </summary>
		protected override JsonServiceSerializer JsonSerializer => SystemTextJsonServiceSerializer.Instance;

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(CheckQueryRequestDto? other)
		{
			return other != null &&
				String == other.String &&
				Boolean == other.Boolean &&
				Double.Equals(other.Double) &&
				Int32 == other.Int32 &&
				Int64 == other.Int64 &&
				Decimal == other.Decimal &&
				Enum == other.Enum &&
				ServiceDataUtility.AreEquivalentDateTimes(Datetime, other.Datetime);
		}

		/// <summary>
		/// Validates the DTO.
		/// </summary>
		public override bool Validate(out string? errorMessage)
		{
			errorMessage = GetValidationErrorMessage();
			return errorMessage == null;
		}

		private string? GetValidationErrorMessage()
		{
			if (Enum != null && !Enum.Value.IsDefined())
				return ServiceDataUtility.GetInvalidFieldErrorMessage("enum", "Must be an expected enum value.");

			return null;
		}
	}
}
