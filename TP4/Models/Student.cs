using System.ComponentModel.DataAnnotations;

namespace TP4.Models;

public class Student
{
    [Key]
    public int Id { get; init; }

    public string? first_name { get; set; }

    public string? last_name { get; set; }

    public string? phone_number { get; set; }

    public string? university { get; set; }

    public DateTime timestamp { get; set; }

    public string? course { get; init; }
}