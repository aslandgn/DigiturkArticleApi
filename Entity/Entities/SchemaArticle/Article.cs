using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entities.SchemaArticle
{
    [Table("Article", Schema = "ARTICLE")]
    public class Article : SharedEntity
    {
        public int ID { get; set; }
        public string HEADER { get; set; }
        public string CONTENT { get; set; }
    }
}
