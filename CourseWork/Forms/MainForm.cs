using CourseWork.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoviesForm moviesForm = new MoviesForm();
            moviesForm.Show();
            Hide();
            moviesForm.FormClosed += (s, args) => this.Show();

            //moviesForm.FormClosed += (s, args) => this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenresForm genresForm = new GenresForm();
            genresForm.Show();
            Hide();
            genresForm.FormClosed += (s, args) => this.Show();
        }

        private void studioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudiosForm studiosForm = new StudiosForm();
            studiosForm.Show();
            Hide();
            studiosForm.FormClosed += (s, args) => this.Show();
        }

        private void artistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArtistsForm artistsForm = new ArtistsForm();
            artistsForm.Show();
            Hide();
            artistsForm.FormClosed += (s, args) => this.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var context = ApplicationContext.GetInstance();
            context.SaveModel();
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            MoviesForm moviesForm = new MoviesForm();
            moviesForm.Show();
            Hide();

            moviesForm.FormClosed += (s, args) => this.Show();
        }

        private void ArtistsButton_Click(object sender, EventArgs e)
        {
            ArtistsForm artistsForm = new ArtistsForm();
            artistsForm.Show();
            Hide();
            artistsForm.FormClosed += (s, args) => this.Show();
        }

        private void GenresButton_Click(object sender, EventArgs e)
        {
            GenresForm genresForm = new GenresForm();
            genresForm.Show();
            Hide();
            genresForm.FormClosed += (s, args) => this.Show();
        }

        private void StudiosButton_Click(object sender, EventArgs e)
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
