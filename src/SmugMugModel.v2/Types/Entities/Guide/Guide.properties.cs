// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class GuideEntity : SmugMugEntity
    {
        public string CreationDate {get; set;}
        public string GuideID {get; set;}
        public string Uri {get; set;}
        public string UriDescription {get; set;}

    }
}
