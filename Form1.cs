using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;

namespace Project_03_Media_Player_C_Sharp_28_06_24
{
    public partial class Form1 : Form
    {

        private WaveOutEvent waveOutEvent;      // Audio playback object
        private AudioFileReader audioFileReader; // Object for reading audio files
        private Timer timer;                    // Timer to update the song slider with the playback position
        private Timer marqueeTimer;             // Timer for scrolling the song title text
        private string fullTitle;               // Full title of the currently playing song
        private int marqueeIndex = 0;           // Index to track marquee scrolling position
        private string connectionString = @"Server=CY_B0T\SQLEXPRESS07;Database=Project_03_DB;Trusted_Connection=True;";  // Linking local database

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();           // Set up the playback progress timer
            InitializeMarqueeTimer();    // Set up the marquee text scrolling timer
            LoadPlaylistData();              // Set up playlist
        }

        // Initialize the timer that tracks playback progress for the song slider
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;        // 1-second interval for playback position updates
            timer.Tick += Timer_Tick;     // Associate the Tick event with Timer_Tick handler
        }

        // Initialize the marquee timer used for scrolling long song titles
        private void InitializeMarqueeTimer()
        {
            marqueeTimer = new Timer();
            marqueeTimer.Interval = 100;       // Set scrolling speed (200ms intervals)
            marqueeTimer.Tick += MarqueeTimer_Tick; // Associate the Tick event with MarqueeTimer_Tick handler
        }

        // Event handler for the "Now Playing" button to display the Now Playing page
        private void btnNowPlaying_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnNowPlaying);      // Move indicator to this button
            bunifuPages1.SetPage(0);           // Switch to Now Playing page
        }

        // Event handler for the Playlist button to switch to the Playlist page
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnAlbum);
            bunifuPages1.SetPage(1);           // Switch to Playlist page
        }

        // Event handler for the Album button to switch to the Album page
        private void btnAlbum_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnPlaylist);
            bunifuPages1.SetPage(2);           // Switch to Album page
        }

        // Move the indicator under the selected button
        private void MoveIndicator(Control button)
        {
            indicator.Top = button.Top;        // Align indicator's top to button's top
            indicator.Height = button.Height;  // Set indicator's height to button's height
            indicator.BringToFront();          // Bring indicator to the front layer
        }

        // Close button event handler to exit the application
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();                // Close the application
        }

        // Placeholder event handler for Previous button
        private void btnPrev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Previous song functionality not implemented.");
        }

        // Event handler for the Play button
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                waveOutEvent.Play();            // Start playback
                timer.Start();                  // Start the playback progress timer
            }
            else
            {
                MessageBox.Show("No song loaded. Use Add button to load a song.");
            }
        }

        // Event handler for the Pause button to pause playback
        private void btnPause_Click(object sender, EventArgs e)
        {
            waveOutEvent?.Pause();             // Pause the playback if it exists
            timer.Stop();                      // Stop updating the playback position
        }

        // Placeholder event handler for the Next button
        private void btnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Next song functionality not implemented.");
        }

        // Update the song slider with the current playback position every tick
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                songSlider.Value = (int)audioFileReader.CurrentTime.TotalSeconds; // Update slider to current time
            }
        }

        // Scroll event to seek to a specific position within the song
        private void songSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            if (audioFileReader != null)
            {
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(e.Value); // Update playback position
            }
        }

        // Scroll event for adjusting volume based on slider position
        private void soundSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            if (waveOutEvent != null)
            {
                waveOutEvent.Volume = e.Value / 100f; // Set volume from 0 to 1
            }
        }

        // Method to play a selected song file and set up song title marquee if necessary
        private void PlaySong(string filePath)
        {
            if (File.Exists(filePath))
            {
                // Dispose previous audio components if they exist
                audioFileReader?.Dispose();
                waveOutEvent?.Dispose();

                // Initialize audio playback components
                audioFileReader = new AudioFileReader(filePath);
                waveOutEvent = new WaveOutEvent();
                waveOutEvent.Init(audioFileReader);
                waveOutEvent.Play();

                // Set slider's maximum to the song's total duration
                songSlider.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;

                // Set and display the song title
                fullTitle = Path.GetFileNameWithoutExtension(filePath);
                songTitleLabel.Text = fullTitle;

                // Check if marquee scrolling is needed
                if (TextRenderer.MeasureText(fullTitle, songTitleLabel.Font).Width > songTitleLabel.Width)
                {
                    marqueeIndex = 0;            // Reset marquee position
                    marqueeTimer.Start();        // Start marquee scrolling
                }
                else
                {
                    marqueeTimer.Stop();         // Stop marquee if title fits
                }

                timer.Start();                  // Start the playback progress timer
            }
            else
            {
                MessageBox.Show("File not found: " + filePath);
            }
        }

        // Timer tick event for scrolling the song title if it is too long to fit
        private void MarqueeTimer_Tick(object sender, EventArgs e)
        {
            if (fullTitle.Length > 0)
            {
                // Increment index for the marquee effect
                marqueeIndex++;
                if (marqueeIndex >= fullTitle.Length)
                {
                    marqueeIndex = 0;          // Reset to the start to loop the text
                }

                // Update label text with a wrap-around effect
                songTitleLabel.Text = fullTitle.Substring(marqueeIndex) + " " + fullTitle.Substring(0, marqueeIndex);
            }
        }

        // Event handler for the Add Song button to select and play a song
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "MP3 Files|*.mp3|All Files|*.*" // Filter for mp3 and all files
            };

            // Load and play the selected song
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                PlaySong(filePath);           // Play the selected song directly
            }
        }


        // Playlist and SQL functionalities


        public void LoadPlaylistData()
        {
            // Query to retrieve song names from your playlist table
            string query = "SELECT SongName, SongPath FROM Playlist";  // Assuming SongPath stores the file path for each song

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    playlistTable.Controls.Clear(); // Clear any existing rows
                    playlistTable.RowCount = 0;
                    playlistTable.RowStyles.Clear(); // Clear row styles to reset layout

                    while (reader.Read())
                    {
                        // Read the SongName and SongPath values from the database
                        string songName = reader["SongName"].ToString();
                        string filePath = reader["SongPath"].ToString();  // Assuming there's a SongPath column

                        // Debugging output for song name and file path
                        Console.WriteLine($"Loaded Song: {songName}, Path: {filePath}");

                        // Create a new label for each song name
                        Label songLabel = new Label
                        {
                            Text = songName,
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleLeft,
                            Font = new Font("Arial", 10, FontStyle.Regular),
                            AutoSize = false,
                            MinimumSize = new Size(200, 30),
                            Margin = new Padding(5),
                            AutoEllipsis = true
                        };

                        // Add click event to play song
                        songLabel.Click += (sender, e) => PlaylistPlaySong(filePath);

                        // Add the label to a new row in the TableLayoutPanel
                        playlistTable.RowCount++;
                        playlistTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        playlistTable.Controls.Add(songLabel, 0, playlistTable.RowCount - 1);
                    }

                    playlistTable.AutoScroll = true;
                    playlistTable.ResumeLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading playlist: " + ex.Message);
                }
            }
        }

        // Method to play a selected song file
        private void PlaylistPlaySong(string filePath)
        {
            // Log the exact path being checked
            Console.WriteLine("Attempting to play file at: " + filePath);

            // Check if the file exists at the given path
            if (File.Exists(filePath))
            {
                // Proceed with playing the song if file exists
                audioFileReader?.Dispose();
                waveOutEvent?.Dispose();

                audioFileReader = new AudioFileReader(filePath);
                waveOutEvent = new WaveOutEvent();
                waveOutEvent.Init(audioFileReader);
                waveOutEvent.Play();

                // Set the slider's maximum duration
                songSlider.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;

                fullTitle = Path.GetFileNameWithoutExtension(filePath);
                songTitleLabel.Text = fullTitle;

                // Marquee and playback progress setup
                if (TextRenderer.MeasureText(fullTitle, songTitleLabel.Font).Width > songTitleLabel.Width)
                {
                    marqueeIndex = 0;
                    marqueeTimer.Start();
                }
                else
                {
                    marqueeTimer.Stop();
                }

                timer.Start();
            }
            else
            {
                // Log the issue if the file is not found
                MessageBox.Show("File not found: " + filePath);
            }
        }






        private void playlistTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
