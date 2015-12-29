// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class WatermarkEntity : SmugMugEntity
    {
        public WatermarkEntity()
        {
            //Empty constructor to enable deserialization
        }

        public WatermarkEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        private static readonly List<string> PatchParameters = new List<string>(){ "Name","ImageID","Dissolve","Pinned","Thumbs","SmallestSize" };


        public async Task<ImageEntity> image___ (string param1)
        {
            // /image/(*) 
            string requestUri = string.Format("{0}/image/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task<UserEntity> user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("{0}/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<UserEntity>(requestUri); 
        }
    }
}