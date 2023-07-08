using CRUD_API.Helpers.Models;
using CRUD_API.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CRUD_API.Database
{
    public class AppDbContext:DbContext
    {
        public DbSet<Resident> Residents { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        private List<Resident> _getResidents()
        {
            var residents = new List<Resident>();

            var clientTmpResidents = new HttpClient();
            var requestTmpResidents = new HttpRequestMessage(HttpMethod.Get, "http://testlodtask20172.azurewebsites.net/task");
            var responseTmpResidents = clientTmpResidents.Send(requestTmpResidents);
            responseTmpResidents.EnsureSuccessStatusCode();
            var jsonStringTmpResidents = responseTmpResidents.Content.ReadAsStringAsync().Result;

            var tmpResidents = JsonConvert.DeserializeObject<List<tmpResident>>(jsonStringTmpResidents);


            var clientTmpAge = new HttpClient();
            foreach (var tmpResident in tmpResidents)
            {
                var requestTmpAge = new HttpRequestMessage(HttpMethod.Get, $"http://testlodtask20172.azurewebsites.net/task/{tmpResident.Id}");
                var responseTmpAge = clientTmpAge.Send(requestTmpAge);
                responseTmpAge.EnsureSuccessStatusCode();
                var jsonStringTmpAge = responseTmpAge.Content.ReadAsStringAsync().Result;
                var tmpAge = JsonConvert.DeserializeObject<tmpAge>(jsonStringTmpAge);
                var newResident = new Resident
                {
                    Id = tmpResident.Id,
                    Name = tmpResident.Name,
                    Sex = tmpResident.Sex,
                    Age = Convert.ToInt32(tmpAge.Age)
                };
                residents.Add(newResident);
            }

            return residents;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resident>().HasData(_getResidents());
        }
    }
}
