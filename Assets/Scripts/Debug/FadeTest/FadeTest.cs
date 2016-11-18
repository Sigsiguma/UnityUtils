using UnityEngine;
using System.Collections;

namespace debug.fadetest
{
    public class FadeTest : MonoBehaviour
    {
        private void Start()
        {
            utility.fade.FadeManager.Init();
        }

        public void FadeIn()
        {
            utility.fade.Fade.FadeIn(1.0f, () => Debug.Log("fade in end"));
        }

        public void FadeOut()
        {
            utility.fade.Fade.FadeOut(1.0f, () => Debug.Log("fade out end"));
        }
    }
}
