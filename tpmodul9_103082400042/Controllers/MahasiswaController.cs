using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tpmodul9_103082400042.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        // Poin 3.E: Gunakan static variable
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            // Poin 3.C: Nama kamu di urutan pertama
            new Mahasiswa("Andra", "103082400042"),
            new Mahasiswa("Stephen Curry", "1302000002"),
            new Mahasiswa("LeBron James", "1302000001")
        };

        // GET: api/mahasiswa
        [HttpGet]
        public IEnumerable<Mahasiswa> Get() => daftarMahasiswa;

        // GET: api/mahasiswa/{id}
        [HttpGet("{id}")]
        public Mahasiswa Get(int id) => daftarMahasiswa[id];

        // POST: api/mahasiswa
        [HttpPost]
        public void Post([FromBody] Mahasiswa baru) => daftarMahasiswa.Add(baru);

        // DELETE: api/mahasiswa/{id}
        [HttpDelete("{id}")]
        public void Delete(int id) => daftarMahasiswa.RemoveAt(id);
    }
}