using System;
using System.Collections.Generic;

namespace DataAcessLayer.Models;

public partial class Class
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string IdTeacher { get; set; } = null!;

    public int? NumberSlot { get; set; }

    public virtual ICollection<Grade> Grades { get; } = new List<Grade>();

    public virtual Account IdTeacherNavigation { get; set; } = null!;

    public virtual ICollection<Schedule> Schedules { get; } = new List<Schedule>();
}
