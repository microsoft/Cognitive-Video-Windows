// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.ProjectOxford.Video.Contract
{
    /// <summary>
    /// Represents a polygon in motion.
    /// </summary>
    public class MotionPolygon
    {
        /// <summary>
        /// Gets or sets a collection that contains the vertex points of the polygon.
        /// </summary>
        /// <remarks>
        /// A polygon should contain at least 3 points.
        /// </remarks>
        public MotionPoint[] Points { get; set; }
    }
}
