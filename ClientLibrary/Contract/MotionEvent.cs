// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.ProjectOxford.Video.Contract
{
    /// <summary>
    /// An individual event during MotionDetection action, returned in the <see cref="MotionDetectionResult"/> object.
    /// </summary>
    public class MotionEvent
    {
        /// <summary>
        /// Gets or sets id of the motion type.
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the motion type.
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the locations of the motion occurred.
        /// </summary>
        public MotionRectangle[] Locations { get; set; }

        /// <summary>
        /// Gets or sets id of the region. 
        /// </summary>
        public int RegionId { get; set; }
    }
}
