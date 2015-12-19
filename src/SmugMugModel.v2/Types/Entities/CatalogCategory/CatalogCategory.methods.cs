// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogCategoryEntity : SmugMugEntity
    {
        public CatalogCategoryEntity()
        {
            //Empty constructor to enable deserialization
        }

        public CatalogCategoryEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public CatalogSubCategoryEntity[] catalogcategory____subcategories (string param1)
        {
            // /catalog/category/(*)!subcategories 
            return default(CatalogSubCategoryEntity[]); 
        }
    }
}
