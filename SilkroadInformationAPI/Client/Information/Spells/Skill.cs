﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilkroadInformationAPI.Client.Information.Spells
{
    public class Skill
    {
        /// <summary>
        /// Skill reference id in (skilldata).
        /// </summary>
        public uint SkillID { get; set; }

        /// <summary>
        /// Skill time duration left.
        /// </summary>
        public uint Duration { get; set; }

        /// <summary>
        /// If the character is the creator of the skill (Recovery division, etc..)
        /// </summary>
        public byte isCreator { get; set; }

        public Skill(uint id, uint dur, byte creator)
        {
            SkillID = id;
            Duration = dur;
            isCreator = creator;
        }

        public Skill()
        {

        }

        public int Enabled; //??
    }
}
