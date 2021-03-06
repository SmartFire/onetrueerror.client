﻿using System;

namespace OneTrueError.Client.Uploaders
{
    /// <summary>
    ///     Event args for ReportingFailed
    /// </summary>
    public class UploadReportFailedEventArgs : EventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UploadReportFailedEventArgs" /> class.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="dto">DTO that couldn't be uploaded.</param>
        /// <exception cref="System.ArgumentNullException">exception</exception>
        public UploadReportFailedEventArgs(Exception exception, object dto)
        {
            if (exception == null) throw new ArgumentNullException("exception");
            if (dto == null) throw new ArgumentNullException("dto");

            Exception = exception;
            Dto = dto;
        }

        /// <summary>
        ///     DTO that could not be uploaded.
        /// </summary>
        public object Dto { get; private set; }

        /// <summary>
        ///     Exception generated by OTE (it can for instance be that you have configured the app key incorrectly).
        /// </summary>
        public Exception Exception { get; private set; }
    }
}