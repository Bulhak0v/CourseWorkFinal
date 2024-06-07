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
    public partial class StudiosForm : Form
    {
        private StudioService _studioService;
        private static int buttonWidth = 210;
        private static int padding = 40;

        public StudiosForm()
        {
            InitializeComponent();
            ApplicationContext context = ApplicationContext.GetInstance();
            _studioService = context.StudioService;
            InitializeStudioButtons();
        }

        private void InitializeStudioButtons()
        {
            ClearStudioButtons();
            var studios = _studioService.GetStudios();
            studios = studios.OrderBy(g => g.Name).ToList();

            int buttonHeight = 100;
            int startX = padding;
            int startY = padding;


            int buttonsPerRow = this.ClientSize.Width / (buttonWidth + padding);

            for (int i = 0; i < studios.Count; i++)
            {
                var studioButton = new Button
                {
                    Text = studios[i].Name,
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = new Point(startX + (i % buttonsPerRow) * (buttonWidth + padding), startY + (i / buttonsPerRow) * (buttonHeight + padding)),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                studioButton.Click += StudioButton_Click;
                this.Controls.Add(studioButton);
            }

            var addButton = new Button
            {
                Text = "+",
                Size = new Size(buttonWidth, buttonHeight),
                Location = new Point(startX + (studios.Count % buttonsPerRow) * (buttonWidth + padding), startY + (studios.Count / buttonsPerRow) * (buttonHeight + padding)),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            addButton.Click += AddButton_Click;
            this.Controls.Add(addButton);
        }

        private void ClearStudioButtons()
        {
            var buttonsToRemove = this.Controls.OfType<Button>().ToList();
            foreach (var button in buttonsToRemove)
            {
                this.Controls.Remove(button);
            }
        }

        private void StudioButton_Click(object sender, EventArgs e)
        {
            Button studioButton = sender as Button;
            if (studioButton != null)
            {
                string studioName = studioButton.Text;
                Studio infoStudio = new Studio();
                foreach (var studio in _studioService.GetStudios())
                {
                    if (studio.Name == studioName)
                    {
                        infoStudio = studio;
                    }
                }

                StudioInfoForm studioInfoForm = new StudioInfoForm(infoStudio);
                studioInfoForm.StudioClosed += StudioInfoForm_StudioClosed;
                studioInfoForm.ShowDialog();
            }
        }

        private void StudioInfoForm_StudioClosed(object? sender, EventArgs e)
        {
            InitializeStudioButtons();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddStudioForm addStudioForm = new AddStudioForm();
            addStudioForm.StudioAdded += AddStudioForm_StudioAdded;
            addStudioForm.ShowDialog();
        }

        private void AddStudioForm_StudioAdded(object? sender, EventArgs e)
        {
            InitializeStudioButtons();
        }

        private void StudiosForm_Load(object sender, EventArgs e)
        {

        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenresForm genresForm = new GenresForm();
            genresForm.Show();
            Hide();
            genresForm.FormClosed += (s, args) => this.Show();
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoviesForm moviesForm = new MoviesForm();
            moviesForm.Show();
            Hide();
            moviesForm.FormClosed += (s, args) => this.Show();
        }

        private void StudiosForm_Resize(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            InitializeStudioButtons();
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
