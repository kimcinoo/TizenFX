/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Tizen.Multimedia.Util
{
    /// <summary>
    /// Specifies image formats for <see cref="ImageDecoder"/>, <see cref="ImageEncoder"/> and <see cref="ImageUtil"/>.
    /// </summary>
    /// <since_tizen> 4 </since_tizen>
    public enum ImageFormat
    {
        /// <summary>
        /// The Joint Photographic Experts Group format.
        /// </summary>
        Jpeg,
        /// <summary>
        /// The Portable Network Graphics format.
        /// </summary>
        Png,
        /// <summary>
        /// The Graphics Interchange Format.
        /// </summary>
        Gif,
        /// <summary>
        /// The Bitmap format.
        /// </summary>
        Bmp,
        /// <summary>
        /// The WebP format.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        WebP,
        /// <summary>
        /// The HEIF format.
        /// </summary>
        /// <remarks>ImageUtil supports Heif decoder only.</remarks>
        /// <since_tizen> 9 </since_tizen>
        Heif
    }
}
