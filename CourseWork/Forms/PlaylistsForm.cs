using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Model;
using CourseWork.Service;

namespace CourseWork.Forms
{
    public partial class PlaylistsForm : Form
    {
        private static int buttonWidth = 210;
        private static int padding = 40;

        private PlaylistService _playlistService;
        public PlaylistsForm()
        {
            InitializeComponent();
            ApplicationContext context = ApplicationContext.GetInstance();
            _playlistService = context.PlaylistService;
            InitializePlaylistButtons();
        }

        private void PlaylistsForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializePlaylistButtons()
        {
            ClearPlaylistButtons();
            var playlists = _playlistService.GetPlaylists();
            playlists = playlists.OrderBy(p => p.Title).ToList();

            int buttonHeight = 100;
            int startX = padding;
            int startY = padding;

            int buttonsPerRow = this.ClientSize.Width / (buttonWidth + padding);

            for (int i = 0; i < playlists.Count; i++)
            {
                var playlistButton = new Button
                {
                    Text = playlists[i].Title,
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = new Point(startX + (i % buttonsPerRow) * (buttonWidth + padding), startY + (i / buttonsPerRow) * (buttonHeight + padding)),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                playlistButton.Click += PlaylistButton_Click;
                this.Controls.Add(playlistButton);
            }

            var addButton = new Button
            {
                Text = "+",
                Size = new Size(buttonWidth, buttonHeight),
                Location = new Point(startX + (playlists.Count % buttonsPerRow) * (buttonWidth + padding), startY + (playlists.Count / buttonsPerRow) * (buttonHeight + padding)),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            addButton.Click += AddButton_Click;
            this.Controls.Add(addButton);
        }

        private void ClearPlaylistButtons()
        {
            var buttonsToRemove = this.Controls.OfType<Button>().ToList();
            foreach (var button in buttonsToRemove)
            {
                this.Controls.Remove(button);
            }
        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            Button playlistButton = sender as Button;
            if (playlistButton != null)
            {
                string playlistName = playlistButton.Text;
                Playlist infoPlaylist = _playlistService.GetPlaylists().FirstOrDefault(p => p.Title == playlistName);

                if (infoPlaylist != null)
                {
                    PlaylistInfoForm playlistInfoForm = new PlaylistInfoForm(infoPlaylist);
                    playlistInfoForm.PlaylistClosed += PlaylistInfoForm_PlaylistClosed;
                    playlistInfoForm.ShowDialog();
                }
            }
        }

        private void PlaylistInfoForm_PlaylistClosed(object? sender, EventArgs e)
        {
            ClearPlaylistButtons();
            InitializePlaylistButtons();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPlaylistForm addPlaylistForm = new AddPlaylistForm();
            addPlaylistForm.PlaylistAdded += AddPlaylistForm_PlaylistAdded;
            addPlaylistForm.ShowDialog();
        }

        private void AddPlaylistForm_PlaylistAdded(object sender, EventArgs e)
        {
            InitializePlaylistButtons();
        }

        private void PlaylistsForm_Resize(object sender, EventArgs e)
        {
            InitializePlaylistButtons();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenresForm genresForm = new GenresForm();
            genresForm.Show();
            Hide();
            genresForm.FormClosed += (s, args) => this.Show();

        }

        private void movieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MoviesForm moviesForm = new MoviesForm();
            moviesForm.Show();
            Hide();
            moviesForm.FormClosed += (s, args) => this.Show();
        }

        private void studioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StudiosForm studiosForm = new StudiosForm();
            studiosForm.Show();
            Hide();
            studiosForm.FormClosed += (s, args) => this.Show();
        }

        private void artistToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ArtistsForm artistsForm = new ArtistsForm();
            artistsForm.Show();
            Hide();
            artistsForm.FormClosed += (s, args) => this.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
            Hide();
            aboutProgram.FormClosed += (s, args) => this.Show();
        }
    }
}
