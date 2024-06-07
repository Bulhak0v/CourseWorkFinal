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
    public partial class AddStudioForm : Form
    {
        private StudioService _studioService;
        private List<Studio> _studioList;
        private Studio _studioToEdit;
        public event EventHandler StudioAdded;
        public event EventHandler StudioEdited;

        public AddStudioForm()
        {
            InitializeComponent();
            ApplicationContext context = ApplicationContext.GetInstance();
            _studioService = context.StudioService;

            _studioList = _studioService.GetStudios();
        }

        public AddStudioForm(Studio studioToEdit) : this()
        {
            _studioToEdit = studioToEdit;
            LoadStudioData(studioToEdit);
        }

        private void LoadStudioData(Studio studioToEdit)
        {
            NewStudioTitle.Text = studioToEdit.Name;
            NewStudioDescription.Text = studioToEdit.Description;
            NewStudioAddress.Text = studioToEdit.Address;
        }

        private void AddStudioForm_Load(object sender, EventArgs e)
        {

        }

        private void AddStudioButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewStudioTitle.Text))
            {
                MessageBox.Show("Please enter the studio title");
                return;
            }
            if (string.IsNullOrWhiteSpace(NewStudioDescription.Text))
            {
                MessageBox.Show("Please enter the studio description");
                return;
            }
            if (string.IsNullOrWhiteSpace(NewStudioAddress.Text))
            {
                MessageBox.Show("Please enter the studio address");
                return;
            }

            if (_studioToEdit == null)
            {
                foreach (var cStudio in _studioList)
                {
                    if (NewStudioTitle.Text == cStudio.Name)
                    {
                        MessageBox.Show("There already is a studio with this title. Enter another title");
                        return;
                    }
                }

                _studioService.AddStudio(NewStudioTitle.Text, NewStudioDescription.Text, NewStudioAddress.Text);
                StudioAdded?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                if (_studioToEdit.Name == NewStudioTitle.Text && _studioToEdit.Description == NewStudioDescription.Text && _studioToEdit.Address == NewStudioAddress.Text)
                {
                    MessageBox.Show("No changes detected.");
                    return;
                }
                _studioToEdit.Name = NewStudioTitle.Text;
                _studioToEdit.Description = NewStudioDescription.Text;
                _studioToEdit.Address = NewStudioAddress.Text;
                _studioService.UpdateStudio(_studioToEdit);
                StudioEdited?.Invoke(this, EventArgs.Empty);
            }

            this.Close();
        }
    }
}
