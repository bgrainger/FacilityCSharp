// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using Facility.Core;
using Facility.Core.Http;
using Newtonsoft.Json.Linq;

#pragma warning disable 612, 618 // member is obsolete

namespace Facility.ConformanceApi.Http
{
	/// <summary>
	/// API for a Facility test server.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public static partial class ConformanceApiHttpMapping
	{
		/// <summary>
		/// Gets API information.
		/// </summary>
		public static readonly HttpMethodMapping<GetApiInfoRequestDto, GetApiInfoResponseDto> GetApiInfoMapping =
			new HttpMethodMapping<GetApiInfoRequestDto, GetApiInfoResponseDto>.Builder
			{
				HttpMethod = HttpMethod.Get,
				Path = "/",
				ResponseMappings =
				{
					new HttpResponseMapping<GetApiInfoResponseDto>.Builder
					{
						StatusCode = (HttpStatusCode) 200,
						ResponseBodyType = typeof(GetApiInfoResponseDto),
					}.Build(),
				},
			}.Build();

		/// <summary>
		/// Creates a new widget.
		/// </summary>
		public static readonly HttpMethodMapping<CreateWidgetRequestDto, CreateWidgetResponseDto> CreateWidgetMapping =
			new HttpMethodMapping<CreateWidgetRequestDto, CreateWidgetResponseDto>.Builder
			{
				HttpMethod = HttpMethod.Post,
				Path = "/widgets",
				ValidateRequest = request =>
				{
					if (request.Widget == null)
						return ServiceResult.Failure(ServiceErrors.CreateRequestFieldRequired("widget"));
					return ServiceResult.Success();
				},
				RequestBodyType = typeof(WidgetDto),
				GetRequestBody = request => request.Widget,
				CreateRequest = body => new CreateWidgetRequestDto { Widget = (WidgetDto) body },
				ResponseMappings =
				{
					new HttpResponseMapping<CreateWidgetResponseDto>.Builder
					{
						StatusCode = (HttpStatusCode) 201,
						ResponseBodyType = typeof(WidgetDto),
						MatchesResponse = response => response.Widget != null,
						GetResponseBody = response => response.Widget,
						CreateResponse = body => new CreateWidgetResponseDto { Widget = (WidgetDto) body },
					}.Build(),
				},
				GetResponseHeaders = response =>
					new Dictionary<string, string>
					{
						{ "Location", response.Url },
						{ "eTag", response.ETag },
					},
				SetResponseHeaders = (response, headers) =>
				{
					string headerUrl;
					headers.TryGetValue("Location", out headerUrl);
					response.Url = headerUrl;
					string headerETag;
					headers.TryGetValue("eTag", out headerETag);
					response.ETag = headerETag;
					return response;
				},
			}.Build();

		/// <summary>
		/// Gets the specified widget.
		/// </summary>
		public static readonly HttpMethodMapping<GetWidgetRequestDto, GetWidgetResponseDto> GetWidgetMapping =
			new HttpMethodMapping<GetWidgetRequestDto, GetWidgetResponseDto>.Builder
			{
				HttpMethod = HttpMethod.Get,
				Path = "/widgets/{id}",
				ValidateRequest = request =>
				{
					if (request.Id == null)
						return ServiceResult.Failure(ServiceErrors.CreateRequestFieldRequired("id"));
					return ServiceResult.Success();
				},
				GetUriParameters = request =>
					new Dictionary<string, string>
					{
						{ "id", request.Id == null ? null : request.Id.Value.ToString(CultureInfo.InvariantCulture) },
					},
				SetUriParameters = (request, parameters) =>
				{
					string queryParameterId;
					parameters.TryGetValue("id", out queryParameterId);
					request.Id = ServiceDataUtility.TryParseInt32(queryParameterId);
					return request;
				},
				GetRequestHeaders = request =>
					new Dictionary<string, string>
					{
						{ "If-None-Match", request.IfNotETag },
					},
				SetRequestHeaders = (request, headers) =>
				{
					string headerIfNotETag;
					headers.TryGetValue("If-None-Match", out headerIfNotETag);
					request.IfNotETag = headerIfNotETag;
					return request;
				},
				ResponseMappings =
				{
					new HttpResponseMapping<GetWidgetResponseDto>.Builder
					{
						StatusCode = (HttpStatusCode) 200,
						ResponseBodyType = typeof(WidgetDto),
						MatchesResponse = response => response.Widget != null,
						GetResponseBody = response => response.Widget,
						CreateResponse = body => new GetWidgetResponseDto { Widget = (WidgetDto) body },
					}.Build(),
					new HttpResponseMapping<GetWidgetResponseDto>.Builder
					{
						StatusCode = (HttpStatusCode) 304,
						MatchesResponse = response => response.NotModified.GetValueOrDefault(),
						CreateResponse = body => new GetWidgetResponseDto { NotModified = true },
					}.Build(),
				},
				GetResponseHeaders = response =>
					new Dictionary<string, string>
					{
						{ "eTag", response.ETag },
					},
				SetResponseHeaders = (response, headers) =>
				{
					string headerETag;
					headers.TryGetValue("eTag", out headerETag);
					response.ETag = headerETag;
					return response;
				},
			}.Build();

		/// <summary>
		/// Deletes the specified widget.
		/// </summary>
		public static readonly HttpMethodMapping<DeleteWidgetRequestDto, DeleteWidgetResponseDto> DeleteWidgetMapping =
			new HttpMethodMapping<DeleteWidgetRequestDto, DeleteWidgetResponseDto>.Builder
			{
				HttpMethod = HttpMethod.Delete,
				Path = "/widgets/{id}",
				ValidateRequest = request =>
				{
					if (request.Id == null)
						return ServiceResult.Failure(ServiceErrors.CreateRequestFieldRequired("id"));
					return ServiceResult.Success();
				},
				GetUriParameters = request =>
					new Dictionary<string, string>
					{
						{ "id", request.Id == null ? null : request.Id.Value.ToString(CultureInfo.InvariantCulture) },
					},
				SetUriParameters = (request, parameters) =>
				{
					string queryParameterId;
					parameters.TryGetValue("id", out queryParameterId);
					request.Id = ServiceDataUtility.TryParseInt32(queryParameterId);
					return request;
				},
				GetRequestHeaders = request =>
					new Dictionary<string, string>
					{
						{ "If-Match", request.IfETag },
					},
				SetRequestHeaders = (request, headers) =>
				{
					string headerIfETag;
					headers.TryGetValue("If-Match", out headerIfETag);
					request.IfETag = headerIfETag;
					return request;
				},
				ResponseMappings =
				{
					new HttpResponseMapping<DeleteWidgetResponseDto>.Builder
					{
						StatusCode = (HttpStatusCode) 204,
					}.Build(),
					new HttpResponseMapping<DeleteWidgetResponseDto>.Builder
					{
						StatusCode = (HttpStatusCode) 404,
						MatchesResponse = response => response.NotFound.GetValueOrDefault(),
						CreateResponse = body => new DeleteWidgetResponseDto { NotFound = true },
					}.Build(),
					new HttpResponseMapping<DeleteWidgetResponseDto>.Builder
					{
						StatusCode = (HttpStatusCode) 409,
						MatchesResponse = response => response.Conflict.GetValueOrDefault(),
						CreateResponse = body => new DeleteWidgetResponseDto { Conflict = true },
					}.Build(),
				},
			}.Build();

		public static readonly HttpMethodMapping<MirrorFieldsRequestDto, MirrorFieldsResponseDto> MirrorFieldsMapping =
			new HttpMethodMapping<MirrorFieldsRequestDto, MirrorFieldsResponseDto>.Builder
			{
				HttpMethod = HttpMethod.Post,
				Path = "/mirrorFields",
				RequestBodyType = typeof(MirrorFieldsRequestDto),
				ResponseMappings =
				{
					new HttpResponseMapping<MirrorFieldsResponseDto>.Builder
					{
						StatusCode = (HttpStatusCode) 200,
						ResponseBodyType = typeof(MirrorFieldsResponseDto),
					}.Build(),
				},
			}.Build();

		public static readonly HttpMethodMapping<CheckQueryRequestDto, CheckQueryResponseDto> CheckQueryMapping =
			new HttpMethodMapping<CheckQueryRequestDto, CheckQueryResponseDto>.Builder
			{
				HttpMethod = HttpMethod.Get,
				Path = "/checkQuery",
				GetUriParameters = request =>
					new Dictionary<string, string>
					{
						{ "string", request.String },
						{ "boolean", request.Boolean == null ? null : request.Boolean.Value.ToString() },
						{ "double", request.Double == null ? null : request.Double.Value.ToString(CultureInfo.InvariantCulture) },
						{ "int32", request.Int32 == null ? null : request.Int32.Value.ToString(CultureInfo.InvariantCulture) },
						{ "int64", request.Int64 == null ? null : request.Int64.Value.ToString(CultureInfo.InvariantCulture) },
						{ "decimal", request.Decimal == null ? null : request.Decimal.Value.ToString(CultureInfo.InvariantCulture) },
						{ "enum", request.Enum == null ? null : request.Enum.Value.ToString() },
					},
				SetUriParameters = (request, parameters) =>
				{
					string queryParameterString;
					parameters.TryGetValue("string", out queryParameterString);
					request.String = queryParameterString;
					string queryParameterBoolean;
					parameters.TryGetValue("boolean", out queryParameterBoolean);
					request.Boolean = ServiceDataUtility.TryParseBoolean(queryParameterBoolean);
					string queryParameterDouble;
					parameters.TryGetValue("double", out queryParameterDouble);
					request.Double = ServiceDataUtility.TryParseDouble(queryParameterDouble);
					string queryParameterInt32;
					parameters.TryGetValue("int32", out queryParameterInt32);
					request.Int32 = ServiceDataUtility.TryParseInt32(queryParameterInt32);
					string queryParameterInt64;
					parameters.TryGetValue("int64", out queryParameterInt64);
					request.Int64 = ServiceDataUtility.TryParseInt64(queryParameterInt64);
					string queryParameterDecimal;
					parameters.TryGetValue("decimal", out queryParameterDecimal);
					request.Decimal = ServiceDataUtility.TryParseDecimal(queryParameterDecimal);
					string queryParameterEnum;
					parameters.TryGetValue("enum", out queryParameterEnum);
					request.Enum = queryParameterEnum == null ? default(Answer?) : new Answer(queryParameterEnum);
					return request;
				},
				ResponseMappings =
				{
					new HttpResponseMapping<CheckQueryResponseDto>.Builder
					{
						StatusCode = (HttpStatusCode) 200,
					}.Build(),
				},
			}.Build();

		public static readonly HttpMethodMapping<CheckPathRequestDto, CheckPathResponseDto> CheckPathMapping =
			new HttpMethodMapping<CheckPathRequestDto, CheckPathResponseDto>.Builder
			{
				HttpMethod = HttpMethod.Get,
				Path = "/mirror/{string}/{boolean}/{double}/{int32}/{int64}/{decimal}/{enum}",
				ValidateRequest = request =>
				{
					if (string.IsNullOrEmpty(request.String))
						return ServiceResult.Failure(ServiceErrors.CreateRequestFieldRequired("string"));
					if (request.Boolean == null)
						return ServiceResult.Failure(ServiceErrors.CreateRequestFieldRequired("boolean"));
					if (request.Double == null)
						return ServiceResult.Failure(ServiceErrors.CreateRequestFieldRequired("double"));
					if (request.Int32 == null)
						return ServiceResult.Failure(ServiceErrors.CreateRequestFieldRequired("int32"));
					if (request.Int64 == null)
						return ServiceResult.Failure(ServiceErrors.CreateRequestFieldRequired("int64"));
					if (request.Decimal == null)
						return ServiceResult.Failure(ServiceErrors.CreateRequestFieldRequired("decimal"));
					if (request.Enum == null)
						return ServiceResult.Failure(ServiceErrors.CreateRequestFieldRequired("enum"));
					return ServiceResult.Success();
				},
				GetUriParameters = request =>
					new Dictionary<string, string>
					{
						{ "string", request.String },
						{ "boolean", request.Boolean == null ? null : request.Boolean.Value.ToString() },
						{ "double", request.Double == null ? null : request.Double.Value.ToString(CultureInfo.InvariantCulture) },
						{ "int32", request.Int32 == null ? null : request.Int32.Value.ToString(CultureInfo.InvariantCulture) },
						{ "int64", request.Int64 == null ? null : request.Int64.Value.ToString(CultureInfo.InvariantCulture) },
						{ "decimal", request.Decimal == null ? null : request.Decimal.Value.ToString(CultureInfo.InvariantCulture) },
						{ "enum", request.Enum == null ? null : request.Enum.Value.ToString() },
					},
				SetUriParameters = (request, parameters) =>
				{
					string queryParameterString;
					parameters.TryGetValue("string", out queryParameterString);
					request.String = queryParameterString;
					string queryParameterBoolean;
					parameters.TryGetValue("boolean", out queryParameterBoolean);
					request.Boolean = ServiceDataUtility.TryParseBoolean(queryParameterBoolean);
					string queryParameterDouble;
					parameters.TryGetValue("double", out queryParameterDouble);
					request.Double = ServiceDataUtility.TryParseDouble(queryParameterDouble);
					string queryParameterInt32;
					parameters.TryGetValue("int32", out queryParameterInt32);
					request.Int32 = ServiceDataUtility.TryParseInt32(queryParameterInt32);
					string queryParameterInt64;
					parameters.TryGetValue("int64", out queryParameterInt64);
					request.Int64 = ServiceDataUtility.TryParseInt64(queryParameterInt64);
					string queryParameterDecimal;
					parameters.TryGetValue("decimal", out queryParameterDecimal);
					request.Decimal = ServiceDataUtility.TryParseDecimal(queryParameterDecimal);
					string queryParameterEnum;
					parameters.TryGetValue("enum", out queryParameterEnum);
					request.Enum = queryParameterEnum == null ? default(Answer?) : new Answer(queryParameterEnum);
					return request;
				},
				ResponseMappings =
				{
					new HttpResponseMapping<CheckPathResponseDto>.Builder
					{
						StatusCode = (HttpStatusCode) 200,
					}.Build(),
				},
			}.Build();

		public static readonly HttpMethodMapping<MirrorHeadersRequestDto, MirrorHeadersResponseDto> MirrorHeadersMapping =
			new HttpMethodMapping<MirrorHeadersRequestDto, MirrorHeadersResponseDto>.Builder
			{
				HttpMethod = HttpMethod.Get,
				Path = "/mirrorHeaders",
				GetRequestHeaders = request =>
					new Dictionary<string, string>
					{
						{ "string", request.String },
						{ "boolean", request.Boolean == null ? null : request.Boolean.Value.ToString() },
						{ "double", request.Double == null ? null : request.Double.Value.ToString(CultureInfo.InvariantCulture) },
						{ "int32", request.Int32 == null ? null : request.Int32.Value.ToString(CultureInfo.InvariantCulture) },
						{ "int64", request.Int64 == null ? null : request.Int64.Value.ToString(CultureInfo.InvariantCulture) },
						{ "decimal", request.Decimal == null ? null : request.Decimal.Value.ToString(CultureInfo.InvariantCulture) },
						{ "enum", request.Enum == null ? null : request.Enum.Value.ToString() },
					},
				SetRequestHeaders = (request, headers) =>
				{
					string headerString;
					headers.TryGetValue("string", out headerString);
					request.String = headerString;
					string headerBoolean;
					headers.TryGetValue("boolean", out headerBoolean);
					request.Boolean = ServiceDataUtility.TryParseBoolean(headerBoolean);
					string headerDouble;
					headers.TryGetValue("double", out headerDouble);
					request.Double = ServiceDataUtility.TryParseDouble(headerDouble);
					string headerInt32;
					headers.TryGetValue("int32", out headerInt32);
					request.Int32 = ServiceDataUtility.TryParseInt32(headerInt32);
					string headerInt64;
					headers.TryGetValue("int64", out headerInt64);
					request.Int64 = ServiceDataUtility.TryParseInt64(headerInt64);
					string headerDecimal;
					headers.TryGetValue("decimal", out headerDecimal);
					request.Decimal = ServiceDataUtility.TryParseDecimal(headerDecimal);
					string headerEnum;
					headers.TryGetValue("enum", out headerEnum);
					request.Enum = headerEnum == null ? default(Answer?) : new Answer(headerEnum);
					return request;
				},
				ResponseMappings =
				{
					new HttpResponseMapping<MirrorHeadersResponseDto>.Builder
					{
						StatusCode = (HttpStatusCode) 200,
					}.Build(),
				},
				GetResponseHeaders = response =>
					new Dictionary<string, string>
					{
						{ "string", response.String },
						{ "boolean", response.Boolean == null ? null : response.Boolean.Value.ToString() },
						{ "double", response.Double == null ? null : response.Double.Value.ToString(CultureInfo.InvariantCulture) },
						{ "int32", response.Int32 == null ? null : response.Int32.Value.ToString(CultureInfo.InvariantCulture) },
						{ "int64", response.Int64 == null ? null : response.Int64.Value.ToString(CultureInfo.InvariantCulture) },
						{ "decimal", response.Decimal == null ? null : response.Decimal.Value.ToString(CultureInfo.InvariantCulture) },
						{ "enum", response.Enum == null ? null : response.Enum.Value.ToString() },
					},
				SetResponseHeaders = (response, headers) =>
				{
					string headerString;
					headers.TryGetValue("string", out headerString);
					response.String = headerString;
					string headerBoolean;
					headers.TryGetValue("boolean", out headerBoolean);
					response.Boolean = ServiceDataUtility.TryParseBoolean(headerBoolean);
					string headerDouble;
					headers.TryGetValue("double", out headerDouble);
					response.Double = ServiceDataUtility.TryParseDouble(headerDouble);
					string headerInt32;
					headers.TryGetValue("int32", out headerInt32);
					response.Int32 = ServiceDataUtility.TryParseInt32(headerInt32);
					string headerInt64;
					headers.TryGetValue("int64", out headerInt64);
					response.Int64 = ServiceDataUtility.TryParseInt64(headerInt64);
					string headerDecimal;
					headers.TryGetValue("decimal", out headerDecimal);
					response.Decimal = ServiceDataUtility.TryParseDecimal(headerDecimal);
					string headerEnum;
					headers.TryGetValue("enum", out headerEnum);
					response.Enum = headerEnum == null ? default(Answer?) : new Answer(headerEnum);
					return response;
				},
			}.Build();
	}
}
