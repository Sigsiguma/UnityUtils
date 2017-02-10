using UnityEngine;

namespace utility.others {
    public class StorageTest : MonoBehaviour {

        private void Start() {

            int a = 10;
            string b = "dj";
            float c = 5.5f;

            Storage<int>.Add("hoge", a);
            Storage<string>.Add("hoge", b);
            Storage<float>.Add("hoge", c);


            Debug.Log("int : " + Storage<int>.Get("hoge"));
            Debug.Log("string : " + Storage<string>.Get("hoge"));
            Debug.Log("float : " + Storage<float>.Get("hoge"));
        }
    }
}
