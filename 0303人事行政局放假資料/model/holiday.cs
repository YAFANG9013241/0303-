using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0303人事行政局放假資料.model
{
    public class holiday
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime? date { get; set; }

        [MaxLength(50)]
        public string name { get; set; }

        [MaxLength(50)]
        public string isHoliday { get; set; }

        [MaxLength(50)]
        public string holidayCategory { get; set; }

        [MaxLength(200)]
        public string description { get; set; }
    }
}