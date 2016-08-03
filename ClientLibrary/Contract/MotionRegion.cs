// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.ProjectOxford.Video.Contract
{
    /// <summary>
    /// A global object defining a region that will be monitored for motion.  Returned as part of the <see cref="MotionDetectionResult"/> object.
    /// </summary>
    public class MotionRegion
    {
        /// <summary>
        /// Gets or sets id of the region.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets type of region.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets points of the region shape
        /// </summary>
        public MotionPoint[] Points { get; set; }
    }
}
