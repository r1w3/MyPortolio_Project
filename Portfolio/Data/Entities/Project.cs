using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Görsel Url Boş bırakılamaz.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Proje Boş bırakılamaz.")]
        [MinLength(3,ErrorMessage = "Proje adı en az 3 karakter olmalı.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proje açıklaması boş bırakılamaz.")]
        [MaxLength(100, ErrorMessage = "Proje açıklaması en fazla 100 karakter olmalıdır.")]
        public string Comment { get; set; }

        [Required(ErrorMessage = "Github URL boş bırakılamaz.")]
        public string GithubUrl { get; set; }

        public List<ProjectTechStack>? ProjectTechStacks { get; set; }
    }
}
