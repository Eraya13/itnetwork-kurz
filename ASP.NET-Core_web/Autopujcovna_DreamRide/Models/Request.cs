﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopujcovna_DreamRide.Models
{
    public class Request
    {
        public int Id { get; set; }
        
        [ForeignKey("ClientId")]
        public int ClientId { get; set; }
        
        [ForeignKey("CarId")]
        public int CarId { get; set; }

        //public string ExpType { get; set; }             // typ půjčení - todo - zatím nabízet jen půjčení od do
        [StringLength (500, ErrorMessage = "Zpráva nesmí být delší než 500 znaků")]
        public string Note { get; set; } = "";
        [Required]
        public string PrefferedContactWay { get; set; } = "";

        [Required (ErrorMessage = "Je nutné zvolit předpokládaný datum vypůjčení auta")]
        [DataType(DataType.Date)]       // pouze datum nikoliv čas
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDay { get; set; }
        
        [Required (ErrorMessage = "Je nutné vybrat počet dnů")]
        [Range (1, 31, ErrorMessage = "Vyberte počet dnů v rozmezí 1-31")]
        public int RentDays { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = "Nová";
    }
}
