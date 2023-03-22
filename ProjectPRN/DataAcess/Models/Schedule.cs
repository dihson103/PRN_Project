using System;
using System.Collections.Generic;

namespace DataAcessLayer.Models;

public partial class Schedule
{
    public string IdStudent { get; set; } = null!;

    public string IdClass { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Slot { get; set; } = null!;

    public bool? IsAttended { get; set; }

    public virtual Class IdClassNavigation { get; set; } = null!;

    public virtual Account IdStudentNavigation { get; set; } = null!;
}
