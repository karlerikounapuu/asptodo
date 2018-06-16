using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations; 

namespace TodoApi.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonalIdentifier { get; set; }
        public bool IsComplete { get; set; }

        public virtual IEnumerable<TodoItem> Todos {get; set;}
    }
}