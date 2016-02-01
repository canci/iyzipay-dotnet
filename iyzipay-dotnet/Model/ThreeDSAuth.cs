﻿using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ThreeDSAuth : ConnectPayment
    {
        public static Task<ThreeDSAuth> Create(CreateThreeDSAuthRequest request, Options options)
        {
            return new RestHttpClient().Post<ThreeDSAuth>(options.BaseUrl + "/payment/iyzipos/auth3ds/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
