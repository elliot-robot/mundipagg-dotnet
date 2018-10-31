﻿using System;
using System.Net;

namespace MundiPagg.Models.Response
{
    /// <summary>
    /// Base response for all operations
    /// </summary>
    /// <typeparam name="T">Response type</typeparam>
    public class BaseResponse<T>
    {
        /// <summary>
        /// Success data - Is set when status code is 2XX
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Error data - Is set when status code is 4XX or 5XX
        /// </summary>
        public ErrorsResponse Errors { get; set; }

        /// <summary>
        /// Exception - Is set when an exception occurs
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// Http status code
        /// </summary>
        public HttpStatusCode? StatusCode { get; set; }

        /// <summary>
        /// Elapsed time to call MundiPagg Api
        /// </summary>
        public long ElapsedTime { get; set; }

        /// <summary>
        /// Raw request in json
        /// </summary>
        public string RawRequest { get; set; }

        /// <summary>
        /// Raw response in json
        /// </summary>
        public string RawResponse { get; set; }
    }
}