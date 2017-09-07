using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace network {
    public class NetworkTest : MonoBehaviour {

        private void Awake() {
            MessagePack.Resolvers.CompositeResolver.RegisterAndSetAsDefault(
                MessagePack.Resolvers.StandardResolver.Instance
            );
        }

        private void Start() {
            var httpClient = new HttpClient(this);

            var api = new APITest();

            var httpParam = new HttpParam();
            httpParam.url_ = "hoge";
            var req = new APITestRequest();
            req.common = new CommonRequest();
            req.common.userID = 1234;
            req.request = 1;
            httpParam.request = req;

            httpClient.Request(api, httpParam);
        }

    }
}
