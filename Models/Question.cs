using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CallaciProjektMaui.Models
{
    [Table("Question")]
    public class Question
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Mark { get; set; }

        [MaxLength(250), Unique]
        public string QuestionText { get; set; }

        [MaxLength(250), Unique]
        public string Solution { get; set; }

        [MaxLength(250), Unique]
        public string Image { get; set; }

        [MaxLength(300)]
        public string Answers { get; set; }
    }
}
