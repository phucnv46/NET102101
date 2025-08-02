using OnTapEFCore.Models;
using OnTapEFCore.Repositories;

namespace OnTapEFCore
{
    public partial class Form1 : Form
    {
        GameRepository _gameRepository = new GameRepository();
        public Form1()
        {
            InitializeComponent();
            LoadControls();
        }

        private void LoadControls()
        {
            dataGridView1.DataSource = _gameRepository.GetGames();
            comboBoxGenre.DataSource = _gameRepository.GetGenres();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataBoundItem de lay object an trong tung dong
            if (dataGridView1.CurrentRow.DataBoundItem is Game game)
            {
                textBoxID.Text = game.GameId.ToString();
                textBoxTilte.Text = game.Title;
                comboBoxGenre.SelectedItem = game.Genre.Trim();
                numericUpDownYear.Value = (decimal)game.ReleaseYear;
                textBoxDev.Text = game.Developer;

            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            //   game.GameId =  int.Parse(textBoxID.Text.Trim());
            game.Title = textBoxTilte.Text;
            game.Genre = (string)comboBoxGenre.SelectedItem;
            game.ReleaseYear = (int)numericUpDownYear.Value;
            game.Developer = textBoxDev.Text;
            _gameRepository.AddGame(game);
            LoadControls();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Game game)
            {
                game.Title = textBoxTilte.Text;
                game.Genre = (string)comboBoxGenre.SelectedItem;
                game.ReleaseYear = (int)numericUpDownYear.Value;
                game.Developer = textBoxDev.Text;
                _gameRepository.UpdateGame(game);
                LoadControls();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Game game)
            {
                _gameRepository.RemoveGame(game);
                LoadControls();
            }
        }

        private void buttonRF_Click(object sender, EventArgs e)
        {
            textBoxID.ResetText();
            textBoxTilte.ResetText();
            textBoxDev.ResetText();
            comboBoxGenre.SelectedIndex = -1;
            numericUpDownYear.Value = 0;
            
        }
    }
}

