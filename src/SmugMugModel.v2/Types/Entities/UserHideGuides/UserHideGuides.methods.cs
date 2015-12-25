// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserHideGuidesEntity : SmugMugEntity
    {
        public UserHideGuidesEntity()
        {
            //Empty constructor to enable deserialization
        }

        public UserHideGuidesEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public List<string> GetPostParameters()
        {
            return new List<string>(){ "Hide" };
        }
    }
}
