// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.ProjectOxford.Video.Contract
{
    /// <summary>
    /// Describes the width, height, and location of a rectangle.
    /// </summary>
    public class MotionRectangle
    {
        /// <summary>
        /// Gets or sets the x-axis value of the left side of the rectangle.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the y-axis value of the top side of the rectangle.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Gets or sets the width of the rectangle.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the rectangle.
        /// </summary>
        public double Height { get; set; }
    }
}
