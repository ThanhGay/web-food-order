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
    [Table(nameof(AuthUser), Schema = DbSchema.Auth)]
    public class AuthUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Email { get; set; }
        [MinLength(6)]
        public string Password { get; set; }
        public int? CustomerId { get; set; }
    }
}
