﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> Entries { get; set; }

        public TeamModel Winner { get; set; }

        public int MatchupRound { get; set; }

    }
}