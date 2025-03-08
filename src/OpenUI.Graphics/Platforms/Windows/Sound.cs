using System;
using System.Media;
using System.Windows.Forms;

namespace OpenUI
{
    public class ISound
    {
        private SoundPlayer Player;
        public string FilePath { get; private set; }

        public ISound(string filePath)
        {
            Player = new SoundPlayer();
            LoadSound(filePath);
        }
        public void Play()
        {
            try
            {
                if (string.IsNullOrEmpty(FilePath))
                {
                    MessageBox.Show("No sound file loaded.");
                    return;
                }
                Player.Play();  // Play the sound
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
        }

        public void Stop()
        {
            try
            {
                Player.Stop();  // Stop the sound
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping sound: " + ex.Message);
            }
        }

        private void LoadAndPlay(string filePath)
        {
            try
            {
                FilePath = filePath;  // Store the file path
                player.SoundLocation = filePath;
                player.Load();  // Load the sound into memory
                player.Play();  // Play the sound
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading and playing sound: " + ex.Message);
            }
        }
    }
}