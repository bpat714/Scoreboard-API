using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace msaPhase2.Models
{
    public class Scoreboard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int scoreboardId { get; set; }
        //conpublic Array winingBoard { get; set; }
        public string playerX { get; set; }
        public string playerO { get; set; }
        public string winner { get; set; }
        [Timestamp]
        public DateTime timeCreated { get; set; }
    }
}
