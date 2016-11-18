﻿using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

/*
 * 使い方 (!!UniRxが必須です。)
 * タイマーを使用したい場所にて、
 * var stop_watch_ =  new utility.stopwatch.StopWatchRx();
 * でタイマーを作成して下さい
 * 
 *  60秒カウントした後、Actionを呼ぶ
 *  stop_watch_.CountDownStart(60, Action);
 */
namespace utility.stopwatch
{
    public class StopWatchRx
    {

        private ReactiveProperty<int> curret_time_ = new ReactiveProperty<int>();

        public ReadOnlyReactiveProperty<int> CurrentTime_ { get { return curret_time_.ToReadOnlyReactiveProperty<int>(); } }

        private bool is_pause = false;
        private bool is_play = false;

        public void CountDownStart(int start_time, System.Action onFinish = null)
        {

            if (is_play)
            {
                Debug.LogWarning("Coroutine is already start!");
                return;
            }

            is_play = true;

            Observable.FromCoroutine<int>(observer => CountDownCoroutine(observer, start_time))
                      .TakeWhile(_ => curret_time_.Value > 0 && is_play)
                      .Subscribe(_ => is_play = true, () =>
                      {
                          if (onFinish != null)
                          {
                              onFinish();
                          }
                          is_play = false;
                      });
        }

        public void Temp()
        {
            curret_time_ = null;
            is_play = false;
        }

        public void Pause()
        {

            if (is_pause)
            {
                Debug.LogWarning("Timer is already pause!");
                return;
            }

            if (!is_play)
            {
                Debug.LogWarning("Timer is not play!");
                return;
            }

            is_pause = true;
        }

        public void Resume()
        {

            if (!is_pause)
            {
                Debug.LogWarning("Timer is not pause!");
                return;
            }

            if (!is_play)
            {
                Debug.LogWarning("Timer is not play!");
                return;
            }

            is_pause = false;
        }

        private IEnumerator CountDownCoroutine(IObserver<int> observer, int start_time)
        {

            curret_time_.Value = start_time;

            while (curret_time_.Value > 0)
            {

                if (!is_pause)
                {
                    observer.OnNext(--curret_time_.Value);
                }

                yield return new WaitForSeconds(1);
            }

            observer.OnCompleted();
        }


    }
}
