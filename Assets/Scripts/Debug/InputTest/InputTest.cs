using UnityEngine;
using UniRx;
using utility.input;

public class InputTest : MonoBehaviour {

    private void Start() {
        var test = gameObject.AddComponent<ObservableLongPointerDownTrigger>();
        test.OnLongPointerDownAsObservable()
            .Subscribe(_ => Debug.Log("長押しされた！！！"));
    }
}
