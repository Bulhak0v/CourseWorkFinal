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
    public partial class ArtistsForm : Form
    {
        private static int buttonWidth = 210;
        private static int padding = 40;
        private ArtistService _artistService;

        public ArtistsForm()
        {
            InitializeComponent();
            ApplicationContext context = ApplicationContext.GetInstance();
            _artistService = context.ArtistService;
            InitializeArtistButtons();
        }

        private void ArtistsForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeArtistButtons()
        {
            ClearArtistButtons();
            var artists = _artistService.GetArtists();
            artists = artists.OrderBy(g => g.Name).ToList();

            int buttonHeight = 100;
            int startX = padding;
            int startY = padding;

            int buttonsPerRow = this.ClientSize.Width / (buttonWidth + padding);

            for (int i = 0; i < artists.Count; i++)
            {
                var artistButton = new Button
                {
                    Text = artists[i].Name,
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = new Point(startX + (i % buttonsPerRow) * (buttonWidth + padding), startY + (i / buttonsPerRow) * (buttonHeight + padding)),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                artistButton.Click += ArtistButton_Click;
                this.Controls.Add(artistButton);
            }

            var addButton = new Button
            {
                Text = "+",
                Size = new Size(buttonWidth, buttonHeight),
                Location = new Point(startX + (artists.Count % buttonsPerRow) * (buttonWidth + padding), startY + (artists.Count / buttonsPerRow) * (buttonHeight + padding)),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            addButton.Click += AddButton_Click;
            this.Controls.Add(addButton);
        }

        private void ClearArtistButtons()
        {
            var buttonsToRemove = this.Controls.OfType<Button>().ToList();
            foreach (var button in buttonsToRemove)
            {
                this.Controls.Remove(button);
            }
        }

        private void ArtistButton_Click(object sender, EventArgs e)
        {
            Button artistButton = sender as Button;
            if (artistButton != null)
            {
                string artistName = artistButton.Text;
                Artist infoArtist = new Artist();
                foreach (var artist in _artistService.GetArtists())
                {
                    if (artist.Name == artistName)
                    {
                        infoArtist = artist;
                    }
                }

                ArtistInfoForm artistInfoForm = new ArtistInfoForm(infoArtist);
                artistInfoForm.ArtistClosed += ArtistInfoForm_ArtistClosed;
                artistInfoForm.ShowDialog();
            }
        }

        private void ArtistInfoForm_ArtistClosed(object sender, EventArgs e)
        {
            InitializeArtistButtons();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddArtistForm addArtistForm = new AddArtistForm();
            addArtistForm.ArtistAdded += AddArtistForm_ArtistAdded;
            addArtistForm.ShowDialog();
        }

        private void AddArtistForm_ArtistAdded(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            //InitializeArtistButtons();
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoviesForm moviesForm = new MoviesForm();
            moviesForm.Show();
            Hide();
            moviesForm.FormClosed += (s, args) => this.Show();
        }

        private void studioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudiosForm studiosForm = new StudiosForm();
            studiosForm.Show();
            Hide();
            studiosForm.FormClosed += (s, args) => this.Show();
        }

        private void ArtistsForm_Resize(object sender, EventArgs e)
        {
            InitializeArtistButtons();
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
            Hide();
            aboutProgram.FormClosed += (s, args) => this.Show();
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaylistsForm playlistForm = new PlaylistsForm();
            playlistForm.Show();
            Hide();
            playlistForm.FormClosed += (s, args) => this.Show();
        }
    }
}
