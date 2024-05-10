using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UIModels
{
    public class UiEmployee
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public char Sex { get; set; }
        public string WorkPosition { get; set; }
        public DateTime DateHired{ get; set; }
        public string Email { get; set; }
        public string WorkPhone { get; set; }
    }
}