using UnityEngine;

namespace utility.others {
    public class StorageTest : MonoBehaviour {

        private void Start() {

            int a = 10;
            string b = "dj";
            float c = 5.5f;
            Test d = new Test(10, 10.6f);

            Storage<int>.Add("hoge", a);
            Storage<string>.Add("hoge", b);
            Storage<float>.Add("hoge", c);
            Storage<Test>.Add("hoge", d);


            Debug.Log("int : " + Storage<int>.Get("hoge"));
            Debug.Log("string : " + Storage<string>.Get("hoge"));
            Debug.Log("float : " + Storage<float>.Get("hoge"));
            Debug.Log("Test : " + Storage<Test>.Get("hoge").foo_);
        }

        private struct Test {
            public int hoge_;
            public float foo_;

            public Test(int hoge, float foo) {
                hoge_ = hoge;
                foo_ = foo;
            }
        };
    }
}
