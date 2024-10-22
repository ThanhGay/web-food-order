using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFO.Shared.Constant.Database;

namespace WFO.Auth.Domain
{
    [Table(nameof(AuthCustomer), Schema = DbSchema.Auth)]
    public class AuthCustomer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        [Length(10,10)]
        public string Phone { get; set; }


    }
}
