using System;
using System.Collections.Generic;

namespace DataAcessLayer.Models;

public partial class Grade
{
    public string IdStudent { get; set; } = null!;

    public string IdClass { get; set; } = null!;

    public int? Mark1 { get; set; }

    public int? Mark2 { get; set; }

    public int? Mark3 { get; set; }

    public virtual Class IdClassNavigation { get; set; } = null!;

    public virtual Account IdStudentNavigation { get; set; } = null!;
}
