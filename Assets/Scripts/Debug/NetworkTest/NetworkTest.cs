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
            var api = new APITest();

            var req = new APITestRequest();
            req.common = new CommonRequest();
            req.common.userID = 1234;
            req.request = 1;

            api.RequestAPI(req);
        }

    }
}
