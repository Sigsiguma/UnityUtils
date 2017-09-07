using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace network {
    public class APITest : APIInterface {

        public override byte[] PackRequest(RequestBase request) {
            var req = request as APITestRequest;
            return PackRequest<APITestRequest>(req);
        }

        public override ResponseBase UnPackResponse(byte[] data) {
            return UnPackResponse<APITestResponse>(data);
        }

    }

    [MessagePack.MessagePackObject]
    public class APITestRequest : RequestBase {
        [MessagePack.Key(1)]
        public int request = 0;
    }

    [MessagePack.MessagePackObject]
    public class APITestResponse : ResponseBase {
        [MessagePack.Key(1)]
        public int response = 0;
    }
}
