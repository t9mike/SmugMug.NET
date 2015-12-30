// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserGuideStateEntity : SmugMugEntity
    {
        public UserGuideStateEntity()
        {
            //Empty constructor to enable deserialization
        }

        public UserGuideStateEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<GuideEntity> guide___ (string param1)
        {
            // /guide/(*) 
            string requestUri = string.Format("{0}/guide/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<GuideEntity>(requestUri); 
        }
    }
}