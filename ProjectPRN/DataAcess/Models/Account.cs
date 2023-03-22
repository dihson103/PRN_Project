using System;
using System.Collections.Generic;

namespace DataAcessLayer.Models;

public partial class Account
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool Sex { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Class> Classes { get; } = new List<Class>();

    public virtual ICollection<Grade> Grades { get; } = new List<Grade>();

    public virtual ICollection<Schedule> Schedules { get; } = new List<Schedule>();
}
