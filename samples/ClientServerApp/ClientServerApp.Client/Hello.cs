﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Blazor.Runtime.Components;
using System.Threading.Tasks;

namespace ClientServerApp.Client
{
    public class Hello : PageModel
    {
        [Required]
        public int MyProperty { get; set; }

        [StringLength(10)]
        [Display(Name = "Test")]
        public string AnotherProp { get; set; }

        public void IncrementCount()
        {
            MyProperty++;
        }

        public void OnResetCounter()
        {
            MyProperty = 0;
        }

        public override Task InitAsync()
        {
            Console.WriteLine("HelloModel overriding InitAsync");
            return null;
        }
        public override Task InitAsync(int id)
        {
            Console.WriteLine("Calling init async with id " + id);
            return null;
        }
    }
}
