// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    /// <summary> The GeoJsonGeometryCollectionData. </summary>
    public partial class GeoJsonGeometryCollectionData
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonGeometryCollectionData"/>. </summary>
        /// <param name="geometries">
        /// Contains a list of valid `GeoJSON` geometry objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude).
        /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPoint"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="geometries"/> is null. </exception>
        internal GeoJsonGeometryCollectionData(IEnumerable<GeoJsonGeometry> geometries)
        {
            Argument.AssertNotNull(geometries, nameof(geometries));

            Geometries = geometries.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonGeometryCollectionData"/>. </summary>
        /// <param name="geometries">
        /// Contains a list of valid `GeoJSON` geometry objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude).
        /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPoint"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
        /// </param>
        internal GeoJsonGeometryCollectionData(IReadOnlyList<GeoJsonGeometry> geometries)
        {
            Geometries = geometries;
        }

        /// <summary>
        /// Contains a list of valid `GeoJSON` geometry objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude).
        /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPoint"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
        /// </summary>
        public IReadOnlyList<GeoJsonGeometry> Geometries { get; }
    }
}
