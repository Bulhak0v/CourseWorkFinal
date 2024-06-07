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
    public partial class AddGenreForm : Form
    {
        private GenreService _genreService;
        private List<Genre> _genreList;
        private Genre _genreToEdit;
        public event EventHandler GenreAdded;
        public event EventHandler GenreEdited;
        public AddGenreForm()
        {
            InitializeComponent();
            ApplicationContext context = ApplicationContext.GetInstance();
            _genreService = context.GenreService;

            _genreList = _genreService.GetGenres();
        }

        public AddGenreForm(Genre genreToEdit) : this()
        {
            _genreToEdit = genreToEdit;
            LoadGenreData(genreToEdit);
        }

        private void LoadGenreData(Genre genreToEdit)
        {
            NewGenreTitle.Text = genreToEdit.Name;
            NewGenreDescription.Text = genreToEdit.Description;
        }

        private void AddGenreForm_Load(object sender, EventArgs e)
        {

        }

        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewGenreTitle.Text))
            {
                MessageBox.Show("Please enter the genre title");
                return;
            }
            if (string.IsNullOrWhiteSpace(NewGenreDescription.Text))
            {
                MessageBox.Show("Please enter the genre description");
                return;
            }
            
            if(_genreToEdit == null)
            {
                foreach (var cGenre in _genreList)
                {
                    if (NewGenreTitle.Text == cGenre.Name)
                    {
                        MessageBox.Show("There already is a genre with this title. Enter another title");
                        return;
                    }
                }

                _genreService.AddGenre(NewGenreTitle.Text, NewGenreDescription.Text);
                GenreAdded?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                if (_genreToEdit.Name == NewGenreTitle.Text && _genreToEdit.Description == NewGenreDescription.Text)
                {
                    MessageBox.Show("No changes detected.");
                    return;
                }
                _genreToEdit.Name = NewGenreTitle.Text;
                _genreToEdit.Description = NewGenreDescription.Text;
                GenreEdited?.Invoke(this, EventArgs.Empty);
            }
            
            this.Close();
        }


    }
}
