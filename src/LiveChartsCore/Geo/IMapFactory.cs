﻿// The MIT License(MIT)
//
// Copyright(c) 2021 Alberto Rodriguez Orozco & LiveCharts Contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Collections.Generic;
using LiveChartsCore.Drawing;
using LiveChartsCore.Measure;

namespace LiveChartsCore.Geo
{
    /// <summary>
    /// Defines a map factory.
    /// </summary>
    public interface IMapFactory<TDrawingContext>
        where TDrawingContext : DrawingContext
    {
        /// <summary>
        /// Fetches the map features.
        /// </summary>
        /// <param name="context">The map context.</param>
        IEnumerable<GeoJsonFeature> FetchFeatures(MapContext<TDrawingContext> context);

        /// <summary>
        /// Fetches the map elements.
        /// </summary>
        /// <param name="context">The map context.</param>
        IEnumerable<IMapElement> FetchMapElements(MapContext<TDrawingContext> context);

        /// <summary>
        /// Converts the given feature into a path geometry.
        /// </summary>
        /// <param name="feature">The feature.</param>
        /// <param name="context">The map context.</param>
        IEnumerable<IDrawable<TDrawingContext>> ConvertToPathShape(
            GeoJsonFeature feature, MapContext<TDrawingContext> context);

        /// <summary>
        /// Zooms the map.
        /// </summary>
        /// <param name="pivot">The pivot.</param>
        /// <param name="direction">The direction.</param>
        void Zoom(LvcPoint pivot, ZoomDirection direction);

        /// <summary>
        /// Pans the map.
        /// </summary>
        /// <param name="delta"></param>
        void Pan(LvcPoint delta);
    }
}
