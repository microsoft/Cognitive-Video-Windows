// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.ProjectOxford.Video.Contract
{
    /// <summary>
    /// Represents an ordered pair of integer x- and y-coordinates that defines a point in motion.
    /// </summary>
    public class MotionPoint
    {
        /// <summary>
        /// Gets or sets the x-coordinate of this Point.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the y-coordinate of this Point.
        /// </summary>
        public double Y { get; set; }
    }
}
