// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Threading;
using System.Threading.Tasks;
using Facility.Core;
using Facility.Core.Http;

namespace Facility.ConformanceApi.Http
{
	/// <summary>
	/// API for a Facility test server.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class HttpClientConformanceApi : HttpClientService, IConformanceApi
	{
		/// <summary>
		/// Creates the service.
		/// </summary>
		public HttpClientConformanceApi(HttpClientServiceSettings settings = null)
			: base(settings, defaultBaseUri: null)
		{
		}

		/// <summary>
		/// Gets API information.
		/// </summary>
		public Task<ServiceResult<GetApiInfoResponseDto>> GetApiInfoAsync(GetApiInfoRequestDto request, CancellationToken cancellationToken)
		{
			return TrySendRequestAsync(ConformanceApiHttpMapping.GetApiInfoMapping, request, cancellationToken);
		}

		/// <summary>
		/// Creates a new widget.
		/// </summary>
		public Task<ServiceResult<CreateWidgetResponseDto>> CreateWidgetAsync(CreateWidgetRequestDto request, CancellationToken cancellationToken)
		{
			return TrySendRequestAsync(ConformanceApiHttpMapping.CreateWidgetMapping, request, cancellationToken);
		}

		/// <summary>
		/// Gets the specified widget.
		/// </summary>
		public Task<ServiceResult<GetWidgetResponseDto>> GetWidgetAsync(GetWidgetRequestDto request, CancellationToken cancellationToken)
		{
			return TrySendRequestAsync(ConformanceApiHttpMapping.GetWidgetMapping, request, cancellationToken);
		}

		/// <summary>
		/// Deletes the specified widget.
		/// </summary>
		public Task<ServiceResult<DeleteWidgetResponseDto>> DeleteWidgetAsync(DeleteWidgetRequestDto request, CancellationToken cancellationToken)
		{
			return TrySendRequestAsync(ConformanceApiHttpMapping.DeleteWidgetMapping, request, cancellationToken);
		}

		public Task<ServiceResult<MirrorFieldsResponseDto>> MirrorFieldsAsync(MirrorFieldsRequestDto request, CancellationToken cancellationToken)
		{
			return TrySendRequestAsync(ConformanceApiHttpMapping.MirrorFieldsMapping, request, cancellationToken);
		}

		public Task<ServiceResult<CheckQueryResponseDto>> CheckQueryAsync(CheckQueryRequestDto request, CancellationToken cancellationToken)
		{
			return TrySendRequestAsync(ConformanceApiHttpMapping.CheckQueryMapping, request, cancellationToken);
		}

		public Task<ServiceResult<CheckPathResponseDto>> CheckPathAsync(CheckPathRequestDto request, CancellationToken cancellationToken)
		{
			return TrySendRequestAsync(ConformanceApiHttpMapping.CheckPathMapping, request, cancellationToken);
		}

		public Task<ServiceResult<MirrorHeadersResponseDto>> MirrorHeadersAsync(MirrorHeadersRequestDto request, CancellationToken cancellationToken)
		{
			return TrySendRequestAsync(ConformanceApiHttpMapping.MirrorHeadersMapping, request, cancellationToken);
		}
	}
}
