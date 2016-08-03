// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Microsoft.ProjectOxford.Video.Contract
{
    /// <summary>
    /// Settings for motion detection operation.
    /// </summary>
    public class MotionDetectionOperationSettings : VideoOperationSettings
    {
        internal override string MethodName => "detectmotion";

        public SensitivityLevels SensitivityLevel { get; set; } = SensitivityLevels.Medium;
        public bool DetectLightChange { get; set; } = true;
        public int FrameSamplingValue { get; set; } = 1;
        public double MergeTimeThreshold { get; set; } = 0.0;
        public MotionPolygon[] DetectionZones { get; set; }

        internal override IEnumerable<KeyValuePair<string, string>> GetQueryParameters()
        {
            yield return new KeyValuePair<string, string>("sensitivityLevel", SensitivityLevel.ToString().ToLowerInvariant());
            yield return new KeyValuePair<string, string>("detectLightChange", DetectLightChange.ToString().ToLowerInvariant());
            yield return new KeyValuePair<string, string>("frameSamplingValue", FrameSamplingValue.ToString(CultureInfo.InvariantCulture));
            yield return new KeyValuePair<string, string>("mergeTimeThreshold", MergeTimeThreshold.ToString(CultureInfo.InvariantCulture));

            if (DetectionZones != null)
            {
                yield return new KeyValuePair<string, string>(
                    "detectionZones",
                    string.Join("|",
                        DetectionZones.Select(
                            polygon => string.Join(";", polygon.Points.Select(point => $"{point.X},{point.Y}")))));
            }
        }

        public enum SensitivityLevels
        {
            High,
            Medium,
            Low
        }
    }
}
