﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.API.Entities;

[Table("Photos")]
public class Photo
{
    public Guid Id { get; set; }
    public required string Url { get; set; }
    public bool IsMain { get; set; }
    public string? PublicId { get; set; }

    // Navigation properties
    public Guid AppUserId { get; set; }
    public AppUser AppUser { get; set; } = null;
}