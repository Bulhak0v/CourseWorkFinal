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
    public partial class GenresForm : Form
    {
        private static int buttonWidth = 210;
        private static int padding = 40;

        private GenreService _genreService;
        public GenresForm()
        {
            InitializeComponent();
            ApplicationContext context = ApplicationContext.GetInstance();
            _genreService = context.GenreService;
            InitializeGenreButtons();
        }

        private void GenresForm_Load(object sender, EventArgs e)
        {
            //InitializeGenreButtons();
        }

        private void InitializeGenreButtons()
        {
            ClearGenreButtons();
            var genres = _genreService.GetGenres();
            genres = genres.OrderBy(g => g.Name).ToList();

            int buttonHeight = 100;
            int startX = padding;
            int startY = padding;


            //int availableWidth = this.ClientSize.Width - (buttonsPerRow + 1) * padding; // Врахування відступів між кнопками
            //int buttonWidth = availableWidth / buttonsPerRow;

            //Обчислення кількості кнопок у рядку на основі ширини форми
            int buttonsPerRow = this.ClientSize.Width / (buttonWidth + padding);

            for (int i = 0; i < genres.Count; i++)
            {
                var genreButton = new Button
                {
                    Text = genres[i].Name,
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = new Point(startX + (i % buttonsPerRow) * (buttonWidth + padding), startY + (i / buttonsPerRow) * (buttonHeight + padding)),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                genreButton.Click += GenreButton_Click;
                this.Controls.Add(genreButton);
            }

            var addButton = new Button
            {
                Text = "+",
                Size = new Size(buttonWidth, buttonHeight),
                Location = new Point(startX + (genres.Count % buttonsPerRow) * (buttonWidth + padding), startY + (genres.Count / buttonsPerRow) * (buttonHeight + padding)),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            addButton.Click += AddButton_Click;
            this.Controls.Add(addButton);
        }

        private void ClearGenreButtons()
        {
            var buttonsToRemove = this.Controls.OfType<Button>().ToList();
            foreach (var button in buttonsToRemove)
            {
                this.Controls.Remove(button);
            }
        }

        private void GenreButton_Click(object sender, EventArgs e)
        {
            Button genreButton = sender as Button;
            if (genreButton != null)
            {
                string genreName = genreButton.Text;
                Genre infoGenre = new Genre();
                foreach (var genre in _genreService.GetGenres())
                {
                    if (genre.Name == genreName)
                    {
                        infoGenre = genre;
                    }
                }

                GenreInfoForm genreInfoForm = new GenreInfoForm(infoGenre);
                genreInfoForm.GenreClosed += GenreInfoForm_GenreClosed;
                genreInfoForm.ShowDialog();
            }
        }

        private void GenreInfoForm_GenreClosed(object? sender, EventArgs e)
        {
            InitializeGenreButtons();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddGenreForm addGenreForm = new AddGenreForm();
            addGenreForm.GenreAdded += AddGenreForm_GenreAdded;
            addGenreForm.ShowDialog();
        }

        private void AddGenreForm_GenreAdded(object sender, EventArgs e)
        {
            // ReloadGenreButtons();
            InitializeGenreButtons();
        }

        private void ReloadGenreButtons()
        {
            //ClearGenreButtons();
            // InitializeGenreButtons();
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

        private void GenresForm_Resize(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            InitializeGenreButtons();
        }

        private void artistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArtistsForm artistsForm = new ArtistsForm();
            artistsForm.Show();
            Hide();
            artistsForm.FormClosed += (s, args) => this.Show();
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
