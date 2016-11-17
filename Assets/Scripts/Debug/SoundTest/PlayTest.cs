using UnityEngine;
using System.Collections;

namespace debug.soundtest
{
    public class PlayTest : MonoBehaviour
    {
        public void BGM1Play() 
        {
            utility.sound.SoundManager.BGM.Play("TestBGM");
        }

        public void BGM1Stop()
        {
            utility.sound.SoundManager.BGM.Stop("TestBGM", 1.0f);
        }

        public void BGM2Play()
        {
            utility.sound.SoundManager.BGM.Play("TestBGM2");
        }

        public void BGM2Stop() {
        }

    }
}
