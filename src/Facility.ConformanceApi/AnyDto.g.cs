// <auto-generated>
// DO NOT EDIT: generated by fsdgencsharp
// </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;

namespace Facility.ConformanceApi
{
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class AnyDto : ServiceDto<AnyDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public AnyDto()
		{
		}

		public string? String { get; set; }

		public bool? Boolean { get; set; }

		public double? Double { get; set; }

		public int? Int32 { get; set; }

		public long? Int64 { get; set; }

		public decimal? Decimal { get; set; }

		public byte[]? Bytes { get; set; }

		public ServiceObject? Object { get; set; }

		public ServiceErrorDto? Error { get; set; }

		public AnyDto? Data { get; set; }

		public Answer? Enum { get; set; }

		public AnyArrayDto? Array { get; set; }

		public AnyMapDto? Map { get; set; }

		public AnyResultDto? Result { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(AnyDto? other)
		{
			return other != null &&
				String == other.String &&
				Boolean == other.Boolean &&
				Double == other.Double &&
				Int32 == other.Int32 &&
				Int64 == other.Int64 &&
				Decimal == other.Decimal &&
				ServiceDataUtility.AreEquivalentBytes(Bytes, other.Bytes) &&
				ServiceDataUtility.AreEquivalentObjects(Object, other.Object) &&
				ServiceDataUtility.AreEquivalentDtos(Error, other.Error) &&
				ServiceDataUtility.AreEquivalentDtos(Data, other.Data) &&
				Enum == other.Enum &&
				ServiceDataUtility.AreEquivalentDtos(Array, other.Array) &&
				ServiceDataUtility.AreEquivalentDtos(Map, other.Map) &&
				ServiceDataUtility.AreEquivalentDtos(Result, other.Result);
		}
	}
}
