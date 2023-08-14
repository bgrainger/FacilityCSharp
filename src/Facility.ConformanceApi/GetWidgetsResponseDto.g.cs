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
	/// Response for GetWidgets.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	[MessagePack.MessagePackObject]
	public sealed partial class GetWidgetsResponseDto : ServiceDto<GetWidgetsResponseDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public GetWidgetsResponseDto()
		{
		}

		/// <summary>
		/// The widgets.
		/// </summary>
		[MessagePack.Key("widgets")]
		public IReadOnlyList<WidgetDto>? Widgets { get; set; }

		/// <summary>
		/// The JSON serializer.
		/// </summary>
		protected override JsonServiceSerializer JsonSerializer => SystemTextJsonServiceSerializer.Instance;

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(GetWidgetsResponseDto? other)
		{
			return other != null &&
				ServiceDataUtility.AreEquivalentFieldValues(Widgets, other.Widgets);
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
			string? errorMessage;
			if (!ServiceDataUtility.ValidateFieldValue(Widgets, "widgets", out errorMessage))
				return errorMessage!;

			return null;
		}
	}
}
