using CourseWork.Model;
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
    public partial class AddArtistForm : Form
    {
        private ArtistService _artistService;
        private List<Artist> _artistList;
        private Artist _artistToEdit;
        public event EventHandler ArtistAdded;
        public event EventHandler ArtistEdited;

        public AddArtistForm()
        {
            InitializeComponent();
            ApplicationContext context = ApplicationContext.GetInstance();
            _artistService = context.ArtistService;
            _artistList = _artistService.GetArtists();
        }

        public AddArtistForm(Artist artistToEdit) : this()
        {
            _artistToEdit = artistToEdit;
            LoadArtistData(artistToEdit);
        }

        private void LoadArtistData(Artist artistToEdit)
        {
            NewArtistTitle.Text = artistToEdit.Name;
            NewArtistBiography.Text = artistToEdit.Biography;
        }

        private void AddArtistForm_Load(object sender, EventArgs e)
        {

        }

        private void AddArtistButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewArtistTitle.Text))
            {
                MessageBox.Show("Please enter the artist name");
                return;
            }
            if (string.IsNullOrWhiteSpace(NewArtistBiography.Text))
            {
                MessageBox.Show("Please enter the artist biography");
                return;
            }

            if (_artistToEdit == null)
            {
                foreach (var cArtist in _artistList)
                {
                    if (NewArtistTitle.Text == cArtist.Name)
                    {
                        MessageBox.Show("There already is an artist with this name. Enter another name");
                        return;
                    }
                }

                _artistService.AddArtist(NewArtistTitle.Text, NewArtistBiography.Text);
                ArtistAdded?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                if (_artistToEdit.Name == NewArtistTitle.Text && _artistToEdit.Biography == NewArtistBiography.Text)
                {
                    MessageBox.Show("No changes detected.");
                    return;
                }
                _artistToEdit.Name = NewArtistTitle.Text;
                _artistToEdit.Biography = NewArtistBiography.Text;
                _artistService.UpdateArtist(_artistToEdit);
                ArtistEdited?.Invoke(this, EventArgs.Empty);
            }

            this.Close();
        }
    }
}
