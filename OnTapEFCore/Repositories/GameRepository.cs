using Microsoft.EntityFrameworkCore;
using OnTapEFCore.Data;
using OnTapEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapEFCore.Repositories
{
    public class GameRepository
    {
        GameNet1021Context _context;
        DbSet<Game> _gameSet;

        public GameRepository()
        {
            _context = new GameNet1021Context();
            _gameSet = _context.Games;
        }

        public List<Game> GetGames() // Lay toan bo bang
        {
            return _gameSet.ToList();
        }

        public void AddGame(Game game)
        {
            _gameSet.Add(game); // Thêm game vào bảng games
            _context.SaveChanges(); // Lưu thay đổi
        }

        public void RemoveGame(Game game)
        {
            _gameSet.Remove(game);
            _context.SaveChanges();

        }
        public void UpdateGame(Game game) // Cập nhật
        {
            _gameSet.Update(game);
            _context.SaveChanges();
        }

        public List<string> GetGenres()
        {
            return _gameSet.Select(g=>g.Genre).Distinct().ToList();
        }

    }
}
