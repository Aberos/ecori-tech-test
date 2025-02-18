﻿namespace EcoriTechTest.Domain.Model.ValueObjects
{
    public class Image
    {
        /// <summary>
        /// The directory path of to the image.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// The file extension for the image.
        /// </summary>
        public string Extension { get; set; }
    }
}
