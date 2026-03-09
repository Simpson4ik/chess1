using System;
using System.Media; 
using System.Windows; 

namespace ChessUI
{
    public static class SoundManager
    {
        private static SoundPlayer moveSoundPlayer;
        static SoundManager()
        {
            try
            {
                moveSoundPlayer = new SoundPlayer("Assets/move.wav");
                moveSoundPlayer.Load(); 
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Помилка ініціалізації SoundManager (SoundPlayer): " + ex.Message);
                moveSoundPlayer = null;
            }
        }

        public static void PlayMoveSound()
        {
            if (GameSettings.IsSoundEnabled && moveSoundPlayer != null)
            {
                try
                {
                    moveSoundPlayer.Play();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Помилка відтворення звуку (SoundPlayer): " + ex.Message);
                }
            }
        }
    }
}