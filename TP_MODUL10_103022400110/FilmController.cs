using Microsoft.AspNetCore.Mvc;
using TP_MODUL10_103022400110;

namespace TP_MODUL10_103022400110
{
    // Controller untuk mengelola data film
    [ApiController]
    [Route("api/[controller]")]
    public class FilmController : ControllerBase
    {
        // Static list (tanpa database)
        private static List<Film> films = new List<Film>
        {
            new Film {
                Judul = "Inception",
                Sutradara = "Christopher Nolan",
                Tahun = "2010",
                Genre = "Sci-Fi",
                Rating = "9.0"
            },
            new Film {
                Judul = "Interstellar",
                Sutradara = "Christopher Nolan",
                Tahun = "2014",
                Genre = "Sci-Fi",
                Rating = "8.7"
            },
            new Film {
                Judul = "Parasite",
                Sutradara = "Bong Joon-ho",
                Tahun = "2019",
                Genre = "Thriller",
                Rating = "8.6"
            }
        };

        // GET /api/Film
        [HttpGet]
        public ActionResult<List<Film>> GetAll()
        {
            return films;
        }

        // GET /api/Film/{index}
        [HttpGet("{index}")]
        public ActionResult<Film> GetByIndex(int index)
        {
            // Validasi index
            if (index < 0 || index >= films.Count)
                return NotFound("Index tidak ditemukan");

            return films[index];
        }

        // POST /api/Film
        [HttpPost]
        public ActionResult AddFilm([FromBody] Film film)
        {
            // Validasi input
            films.Add(film);
            return Ok("Film berhasil ditambahkan");
        }

        // DELETE /api/Film/{index}
        [HttpDelete("{index}")]
        public ActionResult DeleteFilm(int index)
        {
            // Validasi index
            if (index < 0 || index >= films.Count)
                return NotFound("Index tidak ditemukan");

            // Hapus film dari list
            films.RemoveAt(index);
            return Ok("Film berhasil dihapus");
        }
    }
}