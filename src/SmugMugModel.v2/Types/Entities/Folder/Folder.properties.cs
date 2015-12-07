// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class FolderEntity : SmugMugEntity
    {
        public bool AutoRename {get; set;}
        public DateTime DateAdded {get; set;}
        public DateTime DateModified {get; set;}
        public string Description {get; set;}
        public string HighlightImageUri {get; set;}
        public bool IsEmpty {get; set;}
        public string Keywords {get; set;}
        public string Name {get; set;}
        public string NodeID {get; set;}
        public string Password {get; set;}
        public string PasswordHint {get; set;}
        public PrivacyEnum Privacy {get; set;}
        public string ResponseLevel {get; set;}
        public SecurityTypeEnum SecurityType {get; set;}
        public SmugSearchableEnum SmugSearchable {get; set;}
        public SortDirectionEnum SortDirection {get; set;}
        public SortMethodEnum SortMethod {get; set;}
        public string Uri {get; set;}
        public string UriDescription {get; set;}
        public string UrlName {get; set;}
        public string UrlPath {get; set;}
        public string WebUri {get; set;}
        public WorldSearchableEnum WorldSearchable {get; set;}

    }
}
