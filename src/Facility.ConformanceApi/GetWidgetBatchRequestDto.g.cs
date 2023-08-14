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
	/// Request for GetWidgetBatch.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	[MessagePack.MessagePackObject]
	public sealed partial class GetWidgetBatchRequestDto : ServiceDto<GetWidgetBatchRequestDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public GetWidgetBatchRequestDto()
		{
		}

		/// <summary>
		/// The IDs of the widgets to return.
		/// </summary>
		[MessagePack.Key("ids")]
		public IReadOnlyList<int>? Ids { get; set; }

		/// <summary>
		/// The JSON serializer.
		/// </summary>
		protected override JsonServiceSerializer JsonSerializer => SystemTextJsonServiceSerializer.Instance;

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(GetWidgetBatchRequestDto? other)
		{
			return other != null &&
				ServiceDataUtility.AreEquivalentFieldValues(Ids, other.Ids);
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
			if (Ids == null)
				return ServiceDataUtility.GetRequiredFieldErrorMessage("ids");

			if (Ids != null && Ids.Count > 10)
				return ServiceDataUtility.GetInvalidFieldErrorMessage("ids", "Count must be at most 10.");

			return null;
		}
	}
}
