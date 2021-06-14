﻿using System;
using System.Collections.Generic;
using TheGigHub.Models;

namespace TheGigHub.ViewModel
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime DateTime => DateTime.Parse($"{Date} {Time}");
    }
}