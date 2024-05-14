﻿#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace BindingListJsonSample.Models;

public class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateOnly BirthDay { get; set; }

    public string Email { get; set; }

    public Gender? Gender { get; set; }

    public Customer()
    {
        
    }

    public Customer(int id)
    {
        Id = id;
    }
}