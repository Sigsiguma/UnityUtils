using UnityEngine;
using System.Collections;

namespace debug.soundtest
{
    public class PlayTest : MonoBehaviour
    {

        private void Start()
        {
            utility.sound.SoundManager.Init();
        }

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

        public void BGM2Stop()
        {
            utility.sound.SoundManager.BGM.Stop("TestBGM2", 1.0f);
        }

        public void BGMPause()
        {
            utility.sound.SoundManager.BGM.PauseCategoryAll();
        }

        public void BGMUnPause()
        {
            utility.sound.SoundManager.BGM.UnPauseCategoryAll();
        }

        public void BGMStop()
        {
            utility.sound.SoundManager.BGM.StopCategoryAll();
        }

        public void SEPlay()
        {
            utility.sound.SoundManager.SE.Play("TestSE");
        }

        public void SEStop()
        {
            utility.sound.SoundManager.SE.Stop("TestSE", 1.0f);
        }

        public void SEPause()
        {
            utility.sound.SoundManager.SE.Pause("TestSE");
        }

        public void SEUnPause()
        {
            utility.sound.SoundManager.SE.UnPause("TestSE");
        }

        public void SoundPause()
        {
            utility.sound.SoundManager.PauseAll();
        }

        public void SoundUnPause()
        {
            utility.sound.SoundManager.UnPauseAll();
        }

        public void SoundStop()
        {
            utility.sound.SoundManager.StopAll();
        }

    }
}
