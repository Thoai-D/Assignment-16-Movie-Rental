using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_16_Movie_Rental
{
    public partial class Form1 : Form
    {
        Movie[] Movies;

        public Form1()
        {
            InitializeComponent();
            Movies = new Movie[]
            {
                new Movie("Men In Black", 120),
                new Movie("Avatar", 110),
                new Movie("Forrest Gump", 100),
                new Movie("Sexy Beast", 130),
            };
            AddMovies();
        }

        public void AddMovies()
        {
            for (int i = 0; i < Movies.Length; i++)
            {
                string Name = Movies[i].GetName();
                MoviePicker.Items.Add(Name);
            }
        }

        private void MoviePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = MoviePicker.SelectedIndex;
            Movie ChosenMovie = Movies[i];

            MovieNameLabel.Text = ChosenMovie.GetName();
            LengthLabel.Text = ChosenMovie.GetLength().ToString();
            AvailableLabel.Text = ChosenMovie.IsAvailable().ToString();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            int i = MoviePicker.SelectedIndex;
            Movie ChosenMovie = Movies[i];

            ChosenMovie.BorrowMovie();
            AvailableLabel.Text = ChosenMovie.IsAvailable().ToString();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            int i = MoviePicker.SelectedIndex;
            Movie ChosenMovie = Movies[i];

            ChosenMovie.ReturnMovie();
            AvailableLabel.Text = ChosenMovie.IsAvailable().ToString();
        }
    }

   
    
}
