using UnityEngine;

namespace utility.stopwatch {
    public class TimerTest : MonoBehaviour {

        private StopWatchRx stop_watch_;
        private StopWatch stop_watch_2;

        private void Awake() {
            stop_watch_ = new StopWatchRx();
            stop_watch_2 = new StopWatch(this);
        }

        private void Start() {
            stop_watch_.CountDownStart(10, () => Debug.Log("Complete"));
            stop_watch_2.CountDownStart(10, () => Debug.Log("finish"));
        }

        private void Update() {

            Debug.Log(stop_watch_.CurrentTime_.Value);
            Debug.LogWarning(stop_watch_2.CurrentTime_);
        }

    }
}
